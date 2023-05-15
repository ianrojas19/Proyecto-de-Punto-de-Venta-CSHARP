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
    public partial class Fm_FacturaUnitaria : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DFRQDD ; database= Proyecto_Farmacia ; integrated security = true");
        string respuesta;

        public Fm_FacturaUnitaria()
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
            box_idFacturaUnitaria.Text = "";
            box_idEmpleadoFactura.Clear();
            box_nombreEmpleadoFactura.Clear();
            box_idClienteFactura.Clear();
            box_nombreClienteFactura.Clear();
            box_idEmpleadoFactura.Clear();
            box_idEmpleadoFactura.Clear();
            box_idProductoFactura.Clear();
            box_nombreProductoFactura.Clear();
            box_precioProductoFactura.Clear();
            pick_cantidadProductoFactura.Value = 1;                        
            box_totalFactura.Text = "0";
            box_subtotalFactura.Text = "0";
            box_ivaFactura.Text = "0";
            box_totalFactura.Text = "0";
            down_metodoPagoFactura.Text = "";
            box_totalRecibidoFactura.Text = "0";
            box_vueltoExcedenteFactura.Text = "0";
            date_fechaEmisionFactura.Value = DateTime.Now;
        }

        private void gbox_dataCliente_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pick_cantidadInicialProducto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fm_FacturaUnitaria_Load(object sender, EventArgs e)
        {

        }

        private void box_idClienteFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_crearFactura_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comprobar = new SqlCommand("SELECT COUNT(*) FROM Factura_Unitaria WHERE idFacturaUnitaria = @idFacturaUnit", conexion);
                comprobar.Parameters.AddWithValue("@idFacturaUnit", int.Parse(box_idFacturaUnitaria.Text));
                int count = (int)comprobar.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe una factura con ese ID.", "Error");
                }
                else
                {
                    SqlCommand comando = new SqlCommand("sp_crearFacturaUnitaria", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idFacturaUnit", int.Parse(box_idFacturaUnitaria.Text));
                    comando.Parameters.AddWithValue("@idEmpleado", int.Parse(box_idEmpleadoFactura.Text));
                    comando.Parameters.AddWithValue("@idProducto", int.Parse(box_idEmpleadoFactura.Text));
                    comando.Parameters.AddWithValue("@cedCliente", int.Parse(box_idClienteFactura.Text));
                    comando.Parameters.AddWithValue("@cantProd", int.Parse(pick_cantidadProductoFactura.Text));
                    comando.Parameters.AddWithValue("@fechaEmisionFacturaUnitaria", date_fechaEmisionFactura.Text);

                    if (down_metodoPagoFactura.Text == "Efectivo")
                    {
                        comando.Parameters.AddWithValue("@idMetodoPago", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@idMetodoPago", 2);
                    }

                    comando.Parameters.AddWithValue("@subtotalFac", int.Parse(box_subtotalFactura.Text));
                    comando.Parameters.AddWithValue("@IVA", int.Parse(box_ivaFactura.Text));
                    comando.Parameters.AddWithValue("@totalFac", int.Parse(box_totalFactura.Text));
                    comando.Parameters.AddWithValue("@totalPagado", int.Parse(box_totalRecibidoFactura.Text));
                    comando.Parameters.AddWithValue("@totalVuelto", int.Parse(box_vueltoExcedenteFactura.Text));
                    comando.ExecuteNonQuery();

                    SqlCommand comando1 = new SqlCommand("sp_ingresarVentaEfectivo", conexion);
                    comando1.CommandType = CommandType.StoredProcedure;
                    comando1.Parameters.Clear();
                    comando1.Parameters.AddWithValue("@idCaja", 1);
                    comando1.Parameters.AddWithValue("@totalVEF", int.Parse(box_totalFactura.Text));
                    comando1.ExecuteNonQuery();

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

        private void btn_buscarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_buscarFacturaUnitaria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idFacturaUnit", int.Parse(box_idFacturaUnitaria.Text));
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    box_idEmpleadoFactura.Text = leer["idEmpleado"].ToString();
                    box_nombreEmpleadoFactura.Text = leer["nombreEmpleado"].ToString();
                    box_idClienteFactura.Text = leer["cedulaCliente"].ToString();
                    box_nombreClienteFactura.Text = leer["nombreCliente"].ToString();
                    box_idProductoFactura.Text = leer["idProducto"].ToString();
                    box_nombreProductoFactura.Text = leer["nombreProducto"].ToString();
                    box_precioProductoFactura.Text = leer["precioProducto"].ToString();
                    pick_cantidadProductoFactura.Text = leer["cantProducto"].ToString();
                    date_fechaEmisionFactura.Text = leer["fechaEmisionFacturaUnitaria"].ToString();
                    box_subtotalFactura.Text = leer["subtotalFacturaUnitaria"].ToString();
                    box_ivaFactura.Text = leer["IVAFacturaUnitaria"].ToString();
                    box_totalFactura.Text = leer["totalFacturaUnitaria"].ToString();
                    string mp = leer["idMetodoPago"].ToString();
                    if (mp == "1")
                    {
                        down_metodoPagoFactura.Text = "Efectivo";
                    }
                    else
                    {
                        down_metodoPagoFactura.Text = "Tarjeta Débito/Crédito";
                    }
                    box_totalRecibidoFactura.Text = leer["totalPagado"].ToString();
                    box_vueltoExcedenteFactura.Text = leer["totalDevolucion"].ToString();
                    MessageBox.Show("Busqueda de factura exitosa", "Éxito");
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos", "Error");
                    LimpiarCampos();
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

        private void box_idEmpleadoFactura_Leave(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "SELECT nombreEmpleado FROM Empleado WHERE idEmpleado = @idEmpleado";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                try
                {
                    command.Parameters.AddWithValue("@idEmpleado", int.Parse(box_idEmpleadoFactura.Text));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        box_nombreEmpleadoFactura.Text = reader["nombreEmpleado"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Empleado inexistente en el sistema", "Error");
                        box_nombreEmpleadoFactura.Text = null;
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca un ID de Empleado valido", "Error");

                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        private void box_cedCliente_Leave(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "SELECT nombreCliente FROM Cliente WHERE cedulaCliente = @cedCliente";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                try
                {
                    command.Parameters.AddWithValue("@cedCliente", int.Parse(box_idClienteFactura.Text));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        box_nombreClienteFactura.Text = reader["nombreCliente"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente inexistente en el sistema", "Error");
                        box_nombreClienteFactura.Text = null;
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca una cedula de Cliente valida", "Error");
                    box_nombreClienteFactura.Text = null;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void box_idProducto_Leave(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "SELECT nombreProducto, precioProducto FROM Producto WHERE idProducto = @idProd";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                try
                {
                    command.Parameters.AddWithValue("@idProd", int.Parse(box_idProductoFactura.Text));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        box_nombreProductoFactura.Text = reader["nombreProducto"].ToString();
                        box_precioProductoFactura.Text = reader["precioProducto"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Producto inexistente en el sistema");
                        box_nombreProductoFactura.Text = "";
                        box_precioProductoFactura.Text = "";
                        box_subtotalFactura.Text = "0";
                        box_ivaFactura.Text = "0";
                        box_totalFactura.Text = "0";
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca una ID de Producto valido");
                    box_nombreProductoFactura.Text = "";
                    box_precioProductoFactura.Text = "";
                    box_subtotalFactura.Text = "0";
                    box_ivaFactura.Text = "0";
                    box_totalFactura.Text = "0";

                }
                finally
                {
                    conexion.Close();
                }
            }
        }
        private void cantProd_Leave(object sender, EventArgs e)
        {
            try { 
            int cant = (int)pick_cantidadProductoFactura.Value;
            int subtotal = cant * int.Parse(box_precioProductoFactura.Text);
            int iva = (subtotal * 13) / 100;
            int total = subtotal + iva;

            box_subtotalFactura.Text = subtotal.ToString();
            box_ivaFactura.Text = iva.ToString();
            box_totalFactura.Text = total.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void metodoPago_Leave(object sender, EventArgs e)
        {
            if (down_metodoPagoFactura.Text != "Efectivo")
            {
                box_vueltoExcedenteFactura.Text = "0";
                box_totalRecibidoFactura.Text = box_totalFactura.Text;
            }
        }

        private void totalRecibido_Leave(object sender, EventArgs e)
        {
            if (box_totalRecibidoFactura.Text != "") {
                try {
                    if (down_metodoPagoFactura.Text == "Efectivo")
                    {
                        int totalPago = int.Parse(box_totalFactura.Text);
                        int totalRecibido = int.Parse(box_totalRecibidoFactura.Text);
                        int vuelto = totalRecibido - totalPago;

                        if (totalPago > totalRecibido)
                        {
                            MessageBox.Show("El efectivo recibido es menor al total a pagar", "Error");
                            box_vueltoExcedenteFactura.Text = "0";
                            box_totalRecibidoFactura.Text = "";
                        }
                        else if (totalPago == totalRecibido)
                        {
                            box_vueltoExcedenteFactura.Text = "0";
                        }
                        else
                        {
                            box_vueltoExcedenteFactura.Text = vuelto.ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error en el proceso, introduzca solamente valores validos.", "Error");
                }
            }
            else
            {
                box_totalRecibidoFactura.Text = "0";
            }
        }

        private void btn_actualizarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_actualizarFacturaUnitaria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idFactu", int.Parse(box_idFacturaUnitaria.Text));
                comando.Parameters.AddWithValue("@newFechaEmis", date_fechaEmisionFactura.Text);               
                comando.ExecuteNonQuery();
                MessageBox.Show("La factura unitaria se actualizó correctamente", "Éxito");
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

        private void btn_eliminarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_eliminarFacturaUnitaria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idFactu", int.Parse(box_idFacturaUnitaria.Text));                
                comando.ExecuteNonQuery();
                MessageBox.Show("La factura unitaria se eliminó correctamente", "Éxito");
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
