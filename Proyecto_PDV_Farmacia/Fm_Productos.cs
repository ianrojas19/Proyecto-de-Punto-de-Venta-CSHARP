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
    public partial class Fm_Productos : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DFRQDD ; database= Proyecto_Farmacia ; integrated security = true");
        string respuesta;

        public Fm_Productos()
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
            box_idProducto.Text = "";
            box_nombreProducto.Clear();
            box_descProducto.Clear();
            box_precioProducto.Clear();
            pick_cantidadInicialProducto.Value = 10;
            box_idProveedorProd.Clear();
            box_nombreProveedorProducto.Clear();
            box_tipoProductoProducto.Clear();
            box_idTipoProd.Clear();
            date_fechaCaducidad.Value = DateTime.Now;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pick_cantidadInicialProducto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_fechaCaducidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void box_precioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_nombreProveedorProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_idProveedorProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void btn_crearProducto_Click(object sender, EventArgs e)
        {            
            try
            {
                conexion.Open();
                SqlCommand comprobar = new SqlCommand("SELECT COUNT(*) FROM Producto WHERE idProducto = @idProd", conexion);
                comprobar.Parameters.AddWithValue("@idProd", int.Parse(box_idProducto.Text));
                int count = (int)comprobar.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un producto con ese ID.", "Error");
                }
                else
                {
                    SqlCommand comando = new SqlCommand("sp_crearProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idProd", int.Parse(box_idProducto.Text));
                    comando.Parameters.AddWithValue("@nombreProd", box_nombreProducto.Text);
                    comando.Parameters.AddWithValue("@descripcionProd", box_descProducto.Text);
                    comando.Parameters.AddWithValue("@fechaCad", date_fechaCaducidad.Text);
                    if (radio_NORequiereReceta.Checked == false)
                    {
                        comando.Parameters.AddWithValue("@bajoRec", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@bajoRec", 0);
                    }
                    comando.Parameters.AddWithValue("@precioProd", int.Parse(box_precioProducto.Text));
                    comando.Parameters.AddWithValue("@existenciasProd", int.Parse(pick_cantidadInicialProducto.Text));
                    comando.Parameters.AddWithValue("@idProv", int.Parse(box_idProveedorProd.Text));
                    comando.Parameters.AddWithValue("@idTipoProd", int.Parse(box_idTipoProd.Text));
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente", "Éxito");
                    LimpiarCampos();
                }
                    conexion.Close();
                
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron guardar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                bool receta;
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_buscarProducto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProd", int.Parse(box_idProducto.Text));
                SqlDataReader leer; 
                leer = comando.ExecuteReader(); 
                if (leer.Read()) 
                {
                    box_nombreProducto.Text = leer["nombreProducto"].ToString();
                    box_descProducto.Text = leer["descripcionProducto"].ToString();
                    date_fechaCaducidad.Value = (DateTime)leer["fechaCaducidad"];
                    receta = leer.GetBoolean(leer.GetOrdinal("bajoReceta"));
                if (receta == true)
                    {
                        radio_requiereReceta.Checked = true;
                    }
                    else
                    {
                        radio_NORequiereReceta.Checked = true;
                    }

                    box_precioProducto.Text = leer["precioProducto"].ToString();
                    pick_cantidadInicialProducto.Text = leer["existenciasProducto"].ToString();
                    box_idProveedorProd.Text = leer["idProveedor"].ToString();
                    box_nombreProveedorProducto.Text = leer["nombreProveedor"].ToString();
                    box_idTipoProd.Text = leer["idTipoProducto"].ToString();
                    box_tipoProductoProducto.Text = leer["nombreTipoProducto"].ToString();
                    MessageBox.Show("La busqueda del producto fue exitosa.", "Éxito");
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

        private void btn_actualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_actualizarProducto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProd", int.Parse(box_idProducto.Text));
                comando.Parameters.AddWithValue("@nombreProd", box_nombreProducto.Text);
                comando.Parameters.AddWithValue("@descripcionProd", box_descProducto.Text);
                comando.Parameters.AddWithValue("@fechaCad", date_fechaCaducidad.Text);
                if (radio_NORequiereReceta.Checked == false)
                {
                    comando.Parameters.AddWithValue("@bajoRec", 1);
                }
                else
                {
                    comando.Parameters.AddWithValue("@bajoRec", 0);
                }
                comando.Parameters.AddWithValue("@precioProd", int.Parse(box_precioProducto.Text));
                comando.Parameters.AddWithValue("@existenciasProd", int.Parse(pick_cantidadInicialProducto.Text));
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se actualizaron correctamente", "Éxito");
                LimpiarCampos();
                conexion.Close();
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron guardar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_eliminarProducto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProd", int.Parse(box_idProducto.Text));
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

        private void radio_requiereReceta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_NORequiereReceta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box_idProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void box_idProveedorProd_Leave(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "SELECT nombreProveedor FROM Proveedor WHERE idProveedor = @idprov";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                try { 
                command.Parameters.AddWithValue("@idprov", int.Parse(box_idProveedorProd.Text));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    box_nombreProveedorProducto.Text = reader["nombreProveedor"].ToString();
                }
                else
                {
                    MessageBox.Show("Proveedor inexistente en el sistema");
                    box_nombreProveedorProducto.Text = null;
                }
                conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca un ID de proveedor valido");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void box_idTipoProductoProducto_Leave(object sender, EventArgs e)
        {
            conexion.Close();
            conexion.Open();
            string query = "SELECT nombreTipoProducto FROM TipoProducto WHERE idTipoProducto = @idTipoProducto";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                try
                {
                    command.Parameters.AddWithValue("@idTipoProducto", int.Parse(box_idTipoProd.Text));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        box_tipoProductoProducto.Text = reader["nombreTipoProducto"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de producto inexistente en el sistema");
                        box_nombreProveedorProducto.Text = null;
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca un ID de tipo de producto valido");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void Fm_Productos_Load(object sender, EventArgs e)
        {

        }

        private void box_idProveedorProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

