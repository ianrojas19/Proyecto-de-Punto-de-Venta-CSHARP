using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PDV_Farmacia
{
    public partial class Fm_menuMain : Form
    {
        public Fm_menuMain()
        {
            InitializeComponent();
            label_activeApartment.Visible = false;
            panelContenedor.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        Fm_logIn logIn = new Fm_logIn();   
        
        public void iniciarMenuPrincipal()
        {            
            controlPanel_main.Visible = true;
            panel_logOut.Visible = false;
            panelContenedor.Visible = true;
            label_activeApartment.Visible = true;
        }

        public void formSwitch(Form formElect)
        {
            //Si hay algun formulario o contenido dentro del panel lo va a eliminar
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            

            //Asigna propiedades al formulario para que rellene y adapte el contenido al panel contenedor
            formElect.TopLevel = false;
            formElect.Dock = DockStyle.Fill;

            //Agrega el formulario al panel contenedor
            this.panelContenedor.Controls.Add(formElect);

            //Muestra el contenido del formulario que tenga agregado el panel contenedor
            formElect.Show();
        }

        private void btn_showFacturacion_Click(object sender, EventArgs e)
        {            
            label_activeApartment.Text = "Facturación unitaria";            
            iniciarMenuPrincipal();
            formSwitch(new Fm_FacturaUnitaria());
        }
        
        // INVENTARIO
        private void btn_showInventario_Click(object sender, EventArgs e)
        {
            label_activeApartment.Text = "Productos";            
            iniciarMenuPrincipal();
            formSwitch(new Fm_Productos());            
        }

        private void btn_showProveedores_Click(object sender, EventArgs e)
        {
            label_activeApartment.Text = "Proveedores";
            iniciarMenuPrincipal();
            formSwitch(new Fm_Proveedores());
        }
        private void btn_showPersonal_Click(object sender, EventArgs e)
        {
            label_activeApartment.Text = "Empleados";
            iniciarMenuPrincipal();
            formSwitch(new Fm_Empleados());
        }
        private void btn_showClientes_Click(object sender, EventArgs e)
        {
            label_activeApartment.Text = "Clientes";
            controlPanel_main.Visible = true;
            iniciarMenuPrincipal();
            formSwitch(new Fm_Clientes());
        }
        private void btn_showCaja_Click(object sender, EventArgs e)
        {
            label_activeApartment.Text = "Caja registradora";
            controlPanel_main.Visible = true;
            iniciarMenuPrincipal();
            formSwitch(new Fm_Caja());

        }

        private void btn_closeWindow_Click(object sender, EventArgs e)
        {           
            this.WindowState = FormWindowState.Minimized;
        }
        
        
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            panel_logOut.Visible = true;
            controlPanel_main.Visible = false;
            panelContenedor.Visible = false;
            panel_logOut.Height = 370;
            panel_logOut.Width = 495;

        }

        private void btn_stayHere_Click(object sender, EventArgs e)
        {
            controlPanel_main.Visible = true;
            panel_logOut.Visible = false;
            panelContenedor.Visible = true;
        }

        private void btn_logOutCONFIRM_Click(object sender, EventArgs e)
        {            
            this.Hide();
            logIn.Show();
        }

        private void Fm_menuMain_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }


        private void controlPanel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fm_menuMain_Load(object sender, EventArgs e)
        {

        }

        private void panel_logOut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
                     
        }

        private void panel_opcionesMenuMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_doSome_Click(object sender, EventArgs e)
        {

        }
    }
}
