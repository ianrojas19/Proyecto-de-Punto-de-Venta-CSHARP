using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_PDV_Farmacia
{
    public partial class Fm_Caja : Form
    {
        public Fm_Caja()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            // Comprobar si se ha presionado Ctrl + L
            if (e.Control && e.KeyCode == Keys.L)
            {
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            box_ingresarDinero.Clear();
            box_retirarDinero.Clear();            
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DFRQDD ; database= Proyecto_Farmacia ; integrated security = true");
        string respuesta;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ingresarDineroCaja_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_ingresarEfectivo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idCaja", 1);
                comando.Parameters.AddWithValue("@totalING", int.Parse(box_ingresarDinero.Text));
                comando.ExecuteNonQuery();
                MessageBox.Show("El dinero se ingresó correctamente", "Éxito");
                LimpiarCampos();                
                conexion.Close();
                cargarDatoscaja();
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron actualizar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    
                }
            }
        }

        private void Fm_Caja_Load(object sender, EventArgs e)
        {
            cargarDatoscaja();
        }

        private void cargarDatoscaja()
        {
           try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_buscarValoresCaja", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idCaja", 1);
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                if (leer.Read())
                {                  
                    box_ventasEfectivo.Text = leer["totalVentasEfectivo"].ToString();
                    box_entradasCaja.Text = leer["totalIngresos"].ToString();
                    box_retirosCaja.Text = leer["totalEgresos"].ToString();
                    box_totalCaja.Text = leer["totalEfectivoCaja"].ToString();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                MessageBox.Show("Error en la contabilidad de caja, razones: \n" + respuesta);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btn_retirarDineroCaja_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_egresarEfectivo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idCaja", 1);
                comando.Parameters.AddWithValue("@totalEGR", int.Parse(box_retirarDinero.Text));

                if (int.Parse(box_totalCaja.Text) < int.Parse(box_retirarDinero.Text))
                {
                    MessageBox.Show("La cantidad a retirar excede el efectivo actual de la caja registradora", "Error");
                    box_retirarDinero.Text = "";
                    conexion.Close();
                }
                else
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El dinero se retiró correctamente", "Éxito");
                    LimpiarCampos();
                    conexion.Close();
                    cargarDatoscaja();
                }                
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron actualizar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }
        }
    }
}
