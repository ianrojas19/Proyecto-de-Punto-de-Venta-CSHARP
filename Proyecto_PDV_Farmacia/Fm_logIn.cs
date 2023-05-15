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
    public partial class Fm_logIn : Form
    {
        public Fm_logIn()
        {
            InitializeComponent();            
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DFRQDD ; database= Proyecto_Farmacia ; integrated security = true");
        string respuesta;

        private void label_username_Click(object sender, EventArgs e)
        {
            box_logUsername.Focus();
            
        }

        private void label_password_Click(object sender, EventArgs e)
        {
            box_logPassword.Focus();
        }

        private void link_registerLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            if (box_logPassword.UseSystemPasswordChar)
            {
                box_logPassword.UseSystemPasswordChar = false;
                link_registerLog.Text = "Ocultar contraseña";
            }
            else
            {
                box_logPassword.UseSystemPasswordChar = true;
                link_registerLog.Text = "Mostrar contraseña";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            conexion.Open();
            
            string query = "SELECT COUNT(*) FROM Empleado WHERE nombreUsuarioEmpleado = @nombreUsuario AND contraseñaUsuarioEmpleado = @password";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                // Se agregan los valores como parámetros
                command.Parameters.AddWithValue("@nombreUsuario", box_logUsername.Text);
                command.Parameters.AddWithValue("@password", box_logPassword.Text);
                
                // Se utiliza ExecuteScalar para obtener un valor de una sola celda de una consulta
                int count = (int)command.ExecuteScalar();
                
                // Se verifica si la cuenta es mayor que 0 o si las credenciales son las del administrador
                if (count > 0 || (box_logUsername.Text == "winquiros11" && box_logPassword.Text == "12345"))
                {
                    MessageBox.Show("Inicio de sesión exitoso", "Éxito");
                    this.Hide();
                    Fm_menuMain fm_m = new Fm_menuMain();
                    fm_m.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error");
                }
            }

            conexion.Close();
        }

        private void box_logUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_formLogIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fm_logIn_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Application.Exit();            
        }
    }
}


