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
    public partial class Fm_Clientes : Form
    {
        public Fm_Clientes()
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
            box_cedulaCliente.Text = "";
            box_nombreCliente.Clear();
            down_sexoCliemte.Text = "";
            box_telefonoCliente.Clear();
            box_correoCliente.Clear();
            pick_edadCliente.Value = 15;
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DFRQDD ; database= Proyecto_Farmacia ; integrated security = true");
        string respuesta;

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void gbox_dataCliente_Enter(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void down_metodoPagoVacunacion_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pick_edadCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comprobar = new SqlCommand("SELECT COUNT(*) FROM Cliente WHERE cedulaCliente = @cedCliente", conexion);
            comprobar.Parameters.AddWithValue("@cedCliente", int.Parse(box_cedulaCliente.Text));
            int count = (int)comprobar.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Ya existe un cliente con esa cédula.", "Error");
            }
            else
            {
                try
                {
                    SqlCommand comando = new SqlCommand("sp_crearCliente", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@cedulaCliente", int.Parse(box_cedulaCliente.Text));
                    comando.Parameters.AddWithValue("@nombreCliente", box_nombreCliente.Text);
                    comando.Parameters.AddWithValue("@edadCliente", int.Parse(pick_edadCliente.Text));
                    comando.Parameters.AddWithValue("@sexoCliente", down_sexoCliemte.Text);
                    comando.Parameters.AddWithValue("@telefonoContactoCliente", int.Parse(box_telefonoCliente.Text));
                    comando.Parameters.AddWithValue("@emailContactoCliente", box_correoCliente.Text);
                    if (box_cedulaCliente.Text.Length != 9)
                    {
                        MessageBox.Show("Ingrese una cedúla con el formato indicado.", "Error");
                        box_cedulaCliente.Focus();
                    }
                    else
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("El cliente se creó correctamente", "Éxito");
                        LimpiarCampos();
                        
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                    MessageBox.Show("No se pudieron ingresar los datos debido al siguiente problema \n" + respuesta);
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

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_buscarCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cedulaCliente", int.Parse(box_cedulaCliente.Text));
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    box_nombreCliente.Text = leer["nombreCliente"].ToString();
                    box_nombreCliente.Text = leer["nombreCliente"].ToString();
                    pick_edadCliente.Value = (int)leer["edadCliente"];
                    down_sexoCliemte.Text = leer["sexoCliente"].ToString();
                    box_telefonoCliente.Text = leer["telefonoContactoCliente"].ToString();
                    box_correoCliente.Text = leer["emailContactoCliente"].ToString();
                    MessageBox.Show("La búsqueda del cliente fue exitosa.", "Éxito");
                    conexion.Close();
                }
                else //De lo contrario
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

        private void btn_actualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_actualizarCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cedulaCliente", int.Parse(box_cedulaCliente.Text));
                comando.Parameters.AddWithValue("@nombreCliente", box_nombreCliente.Text);
                comando.Parameters.AddWithValue("@edadCliente", int.Parse(pick_edadCliente.Text));
                comando.Parameters.AddWithValue("@sexoCliente", down_sexoCliemte.Text);
                comando.Parameters.AddWithValue("@telefonoContactoCliente", int.Parse(box_telefonoCliente.Text));
                comando.Parameters.AddWithValue("@emailContactoCliente", box_correoCliente.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("El cliente se actualizó correctamente", "Éxito");
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

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_eliminarCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cedulaCliente", int.Parse(box_cedulaCliente.Text));
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

        private void Fm_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
