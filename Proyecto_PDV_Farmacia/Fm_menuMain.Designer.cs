
namespace Proyecto_PDV_Farmacia
{
    partial class Fm_menuMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_menuMain));
            this.panel_opcionesMenuMain = new System.Windows.Forms.Panel();
            this.btn_showPersonal = new FontAwesome.Sharp.IconButton();
            this.btn_showCaja = new FontAwesome.Sharp.IconButton();
            this.btn_showProveedores = new FontAwesome.Sharp.IconButton();
            this.btn_showClientes = new FontAwesome.Sharp.IconButton();
            this.btn_showProductos = new FontAwesome.Sharp.IconButton();
            this.btn_showFacturacion = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nameFarm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logOut = new FontAwesome.Sharp.IconButton();
            this.panel_logOut = new System.Windows.Forms.Panel();
            this.btn_stayHere = new System.Windows.Forms.Button();
            this.btn_logOutCONFIRM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label_activeApartment = new System.Windows.Forms.Label();
            this.controlPanel_main = new System.Windows.Forms.Panel();
            this.panel_opcionesMenuMain.SuspendLayout();
            this.panel_logOut.SuspendLayout();
            this.controlPanel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_opcionesMenuMain
            // 
            this.panel_opcionesMenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_opcionesMenuMain.Controls.Add(this.btn_showPersonal);
            this.panel_opcionesMenuMain.Controls.Add(this.btn_showCaja);
            this.panel_opcionesMenuMain.Controls.Add(this.btn_showProveedores);
            this.panel_opcionesMenuMain.Controls.Add(this.btn_showClientes);
            this.panel_opcionesMenuMain.Controls.Add(this.btn_showProductos);
            this.panel_opcionesMenuMain.Controls.Add(this.btn_showFacturacion);
            this.panel_opcionesMenuMain.Controls.Add(this.label1);
            this.panel_opcionesMenuMain.Controls.Add(this.label_nameFarm);
            this.panel_opcionesMenuMain.Controls.Add(this.panel2);
            this.panel_opcionesMenuMain.Location = new System.Drawing.Point(-2, -1);
            this.panel_opcionesMenuMain.Name = "panel_opcionesMenuMain";
            this.panel_opcionesMenuMain.Size = new System.Drawing.Size(503, 1017);
            this.panel_opcionesMenuMain.TabIndex = 0;
            this.panel_opcionesMenuMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_opcionesMenuMain_Paint);
            // 
            // btn_showPersonal
            // 
            this.btn_showPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showPersonal.FlatAppearance.BorderSize = 0;
            this.btn_showPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showPersonal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_showPersonal.ForeColor = System.Drawing.Color.White;
            this.btn_showPersonal.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_showPersonal.IconColor = System.Drawing.Color.White;
            this.btn_showPersonal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_showPersonal.IconSize = 50;
            this.btn_showPersonal.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_showPersonal.Location = new System.Drawing.Point(77, 646);
            this.btn_showPersonal.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btn_showPersonal.Name = "btn_showPersonal";
            this.btn_showPersonal.Size = new System.Drawing.Size(369, 65);
            this.btn_showPersonal.TabIndex = 10;
            this.btn_showPersonal.Text = "      Empleados";
            this.btn_showPersonal.UseVisualStyleBackColor = false;
            this.btn_showPersonal.Click += new System.EventHandler(this.btn_showPersonal_Click);
            // 
            // btn_showCaja
            // 
            this.btn_showCaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_showCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showCaja.FlatAppearance.BorderSize = 0;
            this.btn_showCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showCaja.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_showCaja.ForeColor = System.Drawing.Color.White;
            this.btn_showCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_showCaja.IconColor = System.Drawing.Color.White;
            this.btn_showCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_showCaja.IconSize = 50;
            this.btn_showCaja.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_showCaja.Location = new System.Drawing.Point(77, 862);
            this.btn_showCaja.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btn_showCaja.Name = "btn_showCaja";
            this.btn_showCaja.Size = new System.Drawing.Size(369, 65);
            this.btn_showCaja.TabIndex = 9;
            this.btn_showCaja.Text = "      Caja registradora";
            this.btn_showCaja.UseVisualStyleBackColor = false;
            this.btn_showCaja.Click += new System.EventHandler(this.btn_showCaja_Click);
            // 
            // btn_showProveedores
            // 
            this.btn_showProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showProveedores.FlatAppearance.BorderSize = 0;
            this.btn_showProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showProveedores.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_showProveedores.ForeColor = System.Drawing.Color.White;
            this.btn_showProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btn_showProveedores.IconColor = System.Drawing.Color.White;
            this.btn_showProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_showProveedores.IconSize = 50;
            this.btn_showProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_showProveedores.Location = new System.Drawing.Point(77, 538);
            this.btn_showProveedores.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btn_showProveedores.Name = "btn_showProveedores";
            this.btn_showProveedores.Size = new System.Drawing.Size(369, 65);
            this.btn_showProveedores.TabIndex = 8;
            this.btn_showProveedores.Text = "      Proveedores";
            this.btn_showProveedores.UseVisualStyleBackColor = false;
            this.btn_showProveedores.Click += new System.EventHandler(this.btn_showProveedores_Click);
            // 
            // btn_showClientes
            // 
            this.btn_showClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showClientes.FlatAppearance.BorderSize = 0;
            this.btn_showClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showClientes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_showClientes.ForeColor = System.Drawing.Color.White;
            this.btn_showClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btn_showClientes.IconColor = System.Drawing.Color.White;
            this.btn_showClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_showClientes.IconSize = 50;
            this.btn_showClientes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_showClientes.Location = new System.Drawing.Point(77, 754);
            this.btn_showClientes.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btn_showClientes.Name = "btn_showClientes";
            this.btn_showClientes.Size = new System.Drawing.Size(369, 65);
            this.btn_showClientes.TabIndex = 7;
            this.btn_showClientes.Text = "      Clientes";
            this.btn_showClientes.UseVisualStyleBackColor = false;
            this.btn_showClientes.Click += new System.EventHandler(this.btn_showClientes_Click);
            // 
            // btn_showProductos
            // 
            this.btn_showProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showProductos.FlatAppearance.BorderSize = 0;
            this.btn_showProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showProductos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_showProductos.ForeColor = System.Drawing.Color.White;
            this.btn_showProductos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btn_showProductos.IconColor = System.Drawing.Color.White;
            this.btn_showProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_showProductos.IconSize = 50;
            this.btn_showProductos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_showProductos.Location = new System.Drawing.Point(77, 430);
            this.btn_showProductos.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btn_showProductos.Name = "btn_showProductos";
            this.btn_showProductos.Size = new System.Drawing.Size(369, 65);
            this.btn_showProductos.TabIndex = 6;
            this.btn_showProductos.Text = "      Productos";
            this.btn_showProductos.UseVisualStyleBackColor = false;
            this.btn_showProductos.Click += new System.EventHandler(this.btn_showInventario_Click);
            // 
            // btn_showFacturacion
            // 
            this.btn_showFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showFacturacion.FlatAppearance.BorderSize = 0;
            this.btn_showFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showFacturacion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_showFacturacion.ForeColor = System.Drawing.Color.White;
            this.btn_showFacturacion.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btn_showFacturacion.IconColor = System.Drawing.Color.White;
            this.btn_showFacturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_showFacturacion.IconSize = 50;
            this.btn_showFacturacion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_showFacturacion.Location = new System.Drawing.Point(77, 314);
            this.btn_showFacturacion.Name = "btn_showFacturacion";
            this.btn_showFacturacion.Size = new System.Drawing.Size(369, 65);
            this.btn_showFacturacion.TabIndex = 4;
            this.btn_showFacturacion.Text = "      Factura unitaria";
            this.btn_showFacturacion.UseVisualStyleBackColor = false;
            this.btn_showFacturacion.Click += new System.EventHandler(this.btn_showFacturacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aurora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nameFarm
            // 
            this.label_nameFarm.AutoSize = true;
            this.label_nameFarm.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label_nameFarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.label_nameFarm.Location = new System.Drawing.Point(55, 98);
            this.label_nameFarm.Name = "label_nameFarm";
            this.label_nameFarm.Size = new System.Drawing.Size(223, 62);
            this.label_nameFarm.TabIndex = 1;
            this.label_nameFarm.Text = "Farmacia";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(231, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 256);
            this.panel2.TabIndex = 3;
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.ForeColor = System.Drawing.Color.Coral;
            this.btn_logOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btn_logOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.btn_logOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logOut.IconSize = 50;
            this.btn_logOut.Location = new System.Drawing.Point(1575, 12);
            this.btn_logOut.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(50, 50);
            this.btn_logOut.TabIndex = 2;
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // panel_logOut
            // 
            this.panel_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panel_logOut.Controls.Add(this.btn_stayHere);
            this.panel_logOut.Controls.Add(this.btn_logOutCONFIRM);
            this.panel_logOut.Controls.Add(this.label3);
            this.panel_logOut.Location = new System.Drawing.Point(859, 312);
            this.panel_logOut.Name = "panel_logOut";
            this.panel_logOut.Size = new System.Drawing.Size(0, 0);
            this.panel_logOut.TabIndex = 5;
            this.panel_logOut.Visible = false;
            this.panel_logOut.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_logOut_Paint);
            // 
            // btn_stayHere
            // 
            this.btn_stayHere.BackColor = System.Drawing.Color.White;
            this.btn_stayHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stayHere.FlatAppearance.BorderSize = 0;
            this.btn_stayHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stayHere.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btn_stayHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.btn_stayHere.Location = new System.Drawing.Point(52, 237);
            this.btn_stayHere.Name = "btn_stayHere";
            this.btn_stayHere.Size = new System.Drawing.Size(390, 67);
            this.btn_stayHere.TabIndex = 22;
            this.btn_stayHere.Text = "No, deseo permanecer aquí.";
            this.btn_stayHere.UseVisualStyleBackColor = false;
            this.btn_stayHere.Click += new System.EventHandler(this.btn_stayHere_Click);
            // 
            // btn_logOutCONFIRM
            // 
            this.btn_logOutCONFIRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.btn_logOutCONFIRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logOutCONFIRM.FlatAppearance.BorderSize = 0;
            this.btn_logOutCONFIRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOutCONFIRM.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btn_logOutCONFIRM.ForeColor = System.Drawing.Color.White;
            this.btn_logOutCONFIRM.Location = new System.Drawing.Point(52, 131);
            this.btn_logOutCONFIRM.Name = "btn_logOutCONFIRM";
            this.btn_logOutCONFIRM.Size = new System.Drawing.Size(390, 67);
            this.btn_logOutCONFIRM.TabIndex = 21;
            this.btn_logOutCONFIRM.Text = "Sí, deseo cerrar sesión.";
            this.btn_logOutCONFIRM.UseVisualStyleBackColor = false;
            this.btn_logOutCONFIRM.Click += new System.EventHandler(this.btn_logOutCONFIRM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.label3.Location = new System.Drawing.Point(43, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 51);
            this.label3.TabIndex = 20;
            this.label3.Text = "¿Desea cerrar sesión?";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Location = new System.Drawing.Point(501, 136);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1147, 871);
            this.panelContenedor.TabIndex = 12;
            this.panelContenedor.Visible = false;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // label_activeApartment
            // 
            this.label_activeApartment.AutoSize = true;
            this.label_activeApartment.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label_activeApartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.label_activeApartment.Location = new System.Drawing.Point(24, 17);
            this.label_activeApartment.Name = "label_activeApartment";
            this.label_activeApartment.Size = new System.Drawing.Size(109, 57);
            this.label_activeApartment.TabIndex = 11;
            this.label_activeApartment.Text = "Caja";
            this.label_activeApartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // controlPanel_main
            // 
            this.controlPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel_main.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel_main.Controls.Add(this.label_activeApartment);
            this.controlPanel_main.Location = new System.Drawing.Point(502, 57);
            this.controlPanel_main.Name = "controlPanel_main";
            this.controlPanel_main.Size = new System.Drawing.Size(1150, 73);
            this.controlPanel_main.TabIndex = 4;
            this.controlPanel_main.Visible = false;
            this.controlPanel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel_main_Paint);
            // 
            // Fm_menuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1649, 1010);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.controlPanel_main);
            this.Controls.Add(this.panel_logOut);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.panel_opcionesMenuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 1200);
            this.MinimumSize = new System.Drawing.Size(18, 982);
            this.Name = "Fm_menuMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Aurora (Menú Principal)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fm_menuMain_FormClosing);
            this.Load += new System.EventHandler(this.Fm_menuMain_Load);
            this.panel_opcionesMenuMain.ResumeLayout(false);
            this.panel_opcionesMenuMain.PerformLayout();
            this.panel_logOut.ResumeLayout(false);
            this.panel_logOut.PerformLayout();
            this.controlPanel_main.ResumeLayout(false);
            this.controlPanel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_opcionesMenuMain;
        private System.Windows.Forms.Label label_nameFarm;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_showFacturacion;
        private FontAwesome.Sharp.IconButton btn_showProveedores;
        private FontAwesome.Sharp.IconButton btn_showClientes;
        private FontAwesome.Sharp.IconButton btn_showProductos;
        private FontAwesome.Sharp.IconButton btn_showCaja;
        private FontAwesome.Sharp.IconButton btn_showPersonal;
        private FontAwesome.Sharp.IconButton btn_logOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_logOut;
        private System.Windows.Forms.Button btn_stayHere;
        private System.Windows.Forms.Button btn_logOutCONFIRM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label_activeApartment;
        private System.Windows.Forms.Panel controlPanel_main;
    }
}