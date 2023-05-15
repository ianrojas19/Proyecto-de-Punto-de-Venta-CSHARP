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
    public partial class Fm_Proveedores : Form
    {
        public Fm_Proveedores()
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
            box_idProveedor.Text = "";
            box_nombreProveedor.Clear();
            box_direccionProveedor.Text = "";
            down_metodoPagoProveedor.Text= "";
            box_telefonoProveedor.Clear();
            box_correoProveedor.Clear();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DFRQDD ; database= Proyecto_Farmacia ; integrated security = true");
        string respuesta;

        private void Fm_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void box_idProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_crearProveedor_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comprobar = new SqlCommand("SELECT COUNT(*) FROM Cliente WHERE cedulaCliente = @cedCliente", conexion);
            comprobar.Parameters.AddWithValue("@cedCliente", int.Parse(box_idProveedor.Text));
            int count = (int)comprobar.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Ya existe un proveedor con ese ID.", "Error");
            }
            else
            {
               // try
                //{
                    SqlCommand comando = new SqlCommand("sp_crearProveedor", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idProv", int.Parse(box_idProveedor.Text));
                    comando.Parameters.AddWithValue("@nomProv", box_nombreProveedor.Text);
                    comando.Parameters.AddWithValue("@direccProv", box_direccionProveedor.Text);
                    if (down_metodoPagoProveedor.Text == "Efectivo")
                    {
                        comando.Parameters.AddWithValue("@idMetPago", 1);
                    }
                    else if(down_metodoPagoProveedor.Text == "Tarjeta Débito/Crédito")
                    {
                        comando.Parameters.AddWithValue("@idMetPago", 2);
                    }
                    else
                    {
                        MessageBox.Show("El campo metodo de pago no puede estar vacio.", "Error");
                        down_metodoPagoProveedor.Focus();
                        conexion.Close();
                    }
                    comando.Parameters.AddWithValue("@telProv", int.Parse(box_telefonoProveedor.Text));
                    comando.Parameters.AddWithValue("@emailProv", box_correoProveedor.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El proveedor se creó correctamente", "Éxito");
                    LimpiarCampos();
                    conexion.Close();
              //  }
              //  catch (Exception ex)
               // {
                 //   respuesta = ex.Message;
                 //   MessageBox.Show("No se pudieron ingresar los datos debido al siguiente problema \n" + respuesta);
               // }
               // finally
               // {
                //    if (conexion.State == ConnectionState.Open)
                //    {
                        conexion.Close();
                //    }
               // }
            }
        }

        private void btn_buscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_buscarProveedor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProv", int.Parse(box_idProveedor.Text));
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    box_nombreProveedor.Text = leer["nombreProveedor"].ToString();
                    box_direccionProveedor.Text = leer["direcciónProveedor"].ToString();
                    box_telefonoProveedor.Text = leer["telefonoProveedor"].ToString();
                    box_correoProveedor.Text = leer["emailProveedor"].ToString();
                    down_metodoPagoProveedor.Text = leer["nombreMetodoPago"].ToString();
                    MessageBox.Show("La búsqueda del proveedor fue exitosa.", "Éxito");
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos", "Error");
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron encontrar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btn_actualizarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_actualizarProveedor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProv", int.Parse(box_idProveedor.Text));
                comando.Parameters.AddWithValue("@nomProv", box_nombreProveedor.Text);
                comando.Parameters.AddWithValue("@direccProv", box_direccionProveedor.Text);
                comando.Parameters.AddWithValue("@telProv", int.Parse(box_telefonoProveedor.Text));
                comando.Parameters.AddWithValue("@emailProv", box_correoProveedor.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("El proveedor se actualizó correctamente", "Éxito");
                LimpiarCampos();
                conexion.Close();
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

        private void btn_eliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_eliminarProveedor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProv", int.Parse(box_idProveedor.Text));
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se eliminaron correctamente", "Éxito");
                LimpiarCampos();
                conexion.Close();
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron eliminar los datos debido al siguiente problema \n" + respuesta);
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
