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
    public partial class Fm_Empleados : Form
    {
        public Fm_Empleados()
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
            box_idEmpleado.Text = "";
            box_nombreEmpleado.Clear();
            box_usuarioEmpleado.Text = "";
            box_contraEmpleado.Clear();
            box_telefonoEmpleado.Clear();
            box_correoEmpleado.Clear();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DFRQDD ; database= Proyecto_Farmacia ; integrated security = true");
        string respuesta;

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Fm_Vacunacion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbox_dataCliente_Enter(object sender, EventArgs e)
        {

        }

        private void box_telefonoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_crearEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre la conexión a la base de datos
                conexion.Open();

                // Verifica si el ID del empleado ya existe en la tabla Empleado
                SqlCommand comprobarID = new SqlCommand("SELECT COUNT(*) FROM Empleado WHERE idEmpleado = @idEmpleado", conexion);
                comprobarID.Parameters.AddWithValue("@idEmpleado", int.Parse(box_idEmpleado.Text));
                int count = (int)comprobarID.ExecuteScalar();

                // Verifica si el nombre de usuario del empleado ya existe en la tabla Empleado
                SqlCommand comprobarUsuario = new SqlCommand("SELECT COUNT(*) FROM Empleado WHERE nombreUsuarioEmpleado = @userEmpleado", conexion);
                comprobarUsuario.Parameters.AddWithValue("@userEmpleado", box_usuarioEmpleado.Text);
                int count2 = (int)comprobarUsuario.ExecuteScalar();

                // Si el ID del empleado ya existe, muestra un mensaje de error
                if (count > 0)
                {
                    MessageBox.Show("Ya existe un empleado con ese ID.", "Error");
                    box_idEmpleado.Focus();
                }
                // Si el nombre de usuario del empleado ya existe, muestra un mensaje de error
                else if (count2 > 0)
                {
                    MessageBox.Show("Ya existe un empleado con ese nombre de usuario.", "Error");
                    box_nombreEmpleado.Focus();
                }
                // Si el ID del empleado y el nombre de usuario no existen, crea un nuevo empleado en la tabla Empleado
                else
                {
                    SqlCommand comando = new SqlCommand("sp_crearEmpleado", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idEmpleado", box_idEmpleado.Text);
                    comando.Parameters.AddWithValue("@nombreEmpleado", box_nombreEmpleado.Text);
                    comando.Parameters.AddWithValue("@usuarioEmpleado", box_usuarioEmpleado.Text);
                    comando.Parameters.AddWithValue("@contraEmpleado", box_contraEmpleado.Text);
                    comando.Parameters.AddWithValue("@telefonoEmpleado", box_telefonoEmpleado.Text);
                    comando.Parameters.AddWithValue("@emailEmpleado", box_correoEmpleado.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente", "Éxito");
                    LimpiarCampos();
                }

                // Cierra la conexión a la base de datos
                conexion.Close();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, muestra un mensaje de error
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron guardar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                // Si la conexión a la base de datos está abierta, ciérrala
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }

        private void btn_buscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexión a la base de datos
                conexion.Open();

                // Crear un nuevo comando de SQL para ejecutar el procedimiento almacenado "sp_buscarEmpleado"
                SqlCommand comando = new SqlCommand("sp_buscarEmpleado", conexion);

                // Especificar que el comando es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;

                // Limpiar los parámetros existentes en el comando
                comando.Parameters.Clear();

                // Agregar el parámetro "@idEmpleado" al comando y establecer su valor como el contenido del control "box_idEmpleado"
                comando.Parameters.AddWithValue("@idEmpleado", int.Parse(box_idEmpleado.Text));

                // Ejecutar el comando y obtener un objeto SqlDataReader para leer los resultados
                SqlDataReader leer;
                leer = comando.ExecuteReader();

                // Si se encontraron datos, actualizar los controles correspondientes con los valores leídos de la base de datos y mostrar un mensaje de éxito
                if (leer.Read())
                {
                    box_nombreEmpleado.Text = leer["nombreEmpleado"].ToString();
                    box_usuarioEmpleado.Text = leer["nombreUsuarioEmpleado"].ToString();
                    box_contraEmpleado.Text = leer["contraseñaUsuarioEmpleado"].ToString();
                    box_telefonoEmpleado.Text = leer["telefonoContactoEmpleado"].ToString();
                    box_correoEmpleado.Text = leer["emailContactoEmpleado"].ToString();
                    MessageBox.Show("La búsqueda del empleado fue exitosa.", "Éxito");

                    // Cerrar la conexión a la base de datos
                    conexion.Close();
                }
                // De lo contrario, mostrar un mensaje de error
                else
                {
                    MessageBox.Show("No se encontraron datos", "Error");
                }

                // Cerrar la conexión a la base de datos
                conexion.Close();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, mostrar un mensaje de error que incluya la descripción del problema
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron encontrar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                // Si la conexión todavía está abierta, cerrarla
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        private void btn_actualizarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre la conexión a la base de datos
                conexion.Open();

                // Crea un nuevo comando de SQL y lo configura para llamar a un procedimiento almacenado llamado "sp_actualizarEmpleado"
                SqlCommand comando = new SqlCommand("sp_actualizarEmpleado", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();

                // Crea otro comando de SQL para comprobar si ya existe un empleado con el mismo nombre de usuario
                SqlCommand comprobarUsuario = new SqlCommand("SELECT COUNT(*) FROM Empleado WHERE nombreUsuarioEmpleado = @userEmpleado", conexion);
                comprobarUsuario.Parameters.AddWithValue("@userEmpleado", box_usuarioEmpleado.Text);

                // Ejecuta el comando y obtiene el resultado
                int count = (int)comprobarUsuario.ExecuteScalar();

                // Si ya existe un empleado con el mismo nombre de usuario, muestra un mensaje de error y enfoca el cuadro de texto correspondiente
                if (count >= 1)
                {
                    MessageBox.Show("Ya existe un empleado con ese nombre de usuario.", "Error");
                    box_usuarioEmpleado.Focus();
                }
                else // De lo contrario
                {
                    // Configura los parámetros del comando "sp_actualizarEmpleado" con los valores de los cuadros de texto correspondientes
                    comando.Parameters.AddWithValue("@idEmpleado", int.Parse(box_idEmpleado.Text));
                    comando.Parameters.AddWithValue("@nombreEmpleado", box_nombreEmpleado.Text);
                    comando.Parameters.AddWithValue("@usuarioEmpleado", box_usuarioEmpleado.Text);
                    comando.Parameters.AddWithValue("@contraEmpleado", box_contraEmpleado.Text);
                    comando.Parameters.AddWithValue("@telefonoEmpleado", int.Parse(box_telefonoEmpleado.Text));
                    comando.Parameters.AddWithValue("@emailEmpleado", box_correoEmpleado.Text);

                    // Ejecuta el comando para actualizar los datos en la base de datos
                    comando.ExecuteNonQuery();

                    // Muestra un mensaje de éxito y limpia los cuadros de texto
                    MessageBox.Show("Los datos se actualizarón correctamente", "Éxito");
                    LimpiarCampos();
                }

                // Cierra la conexión a la base de datos
                conexion.Close();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, muestra un mensaje de error con la información de la excepción
                respuesta = ex.Message;
                MessageBox.Show("No se pudieron actualizar los datos debido al siguiente problema \n" + respuesta);
            }
            finally
            {
                // Asegura que la conexión a la base de datos se cierre, incluso si ocurre una excepción
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        private void btn_eliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open(); // Abrir conexión a la base de datos
                SqlCommand comando = new SqlCommand("sp_eliminarEmpleado", conexion); // Crear comando SQL con el nombre del procedimiento almacenado y la conexión
                comando.CommandType = CommandType.StoredProcedure; // Establecer el tipo de comando como procedimiento almacenado
                comando.Parameters.Clear(); // Limpiar los parámetros del comando
                comando.Parameters.AddWithValue("@idEmpleado", int.Parse(box_idEmpleado.Text)); // Agregar un parámetro al comando con el valor del cuadro de texto de ID del empleado
                comando.ExecuteNonQuery(); // Ejecutar el comando SQL para eliminar el empleado
                MessageBox.Show("Los datos se eliminaron correctamente", "Éxito"); // Mostrar un mensaje de éxito
                LimpiarCampos(); // Llamar a un método para limpiar los campos de entrada
                conexion.Close(); // Cerrar la conexión a la base de datos
            }
            catch (Exception ex)
            {
                respuesta = ex.Message; // Capturar el mensaje de error
                MessageBox.Show("No se pudieron eliminar los datos, a continuacion las posibles causas: \n\n 1. El empleado esta asociado a una factura unitaria \n 2. El ID de empleado proporcionado no existe \n 3. Faltan campos por rellenar \n\n Elimine cualquier registro que incluya a este empleado para poder eliminarlo.", "Error"); // Mostrar un mensaje de error con las posibles causas de fallo
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); // Cerrar la conexión a la base de datos si todavía está abierta
                }
            }
        }

    }
}
