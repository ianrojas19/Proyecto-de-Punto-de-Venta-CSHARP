
namespace Proyecto_PDV_Farmacia
{
    partial class Fm_Proveedores
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
            this.box_idProveedor = new System.Windows.Forms.TextBox();
            this.label_idProducto = new System.Windows.Forms.Label();
            this.box_nombreProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_direccionProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.box_correoProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_telefonoProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.down_metodoPagoProveedor = new System.Windows.Forms.DomainUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_eliminarProveedor = new FontAwesome.Sharp.IconButton();
            this.btn_actualizarProveedor = new FontAwesome.Sharp.IconButton();
            this.btn_buscarProveedor = new FontAwesome.Sharp.IconButton();
            this.btn_crearProveedor = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_idProveedor
            // 
            this.box_idProveedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_idProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_idProveedor.Location = new System.Drawing.Point(261, 41);
            this.box_idProveedor.Name = "box_idProveedor";
            this.box_idProveedor.Size = new System.Drawing.Size(321, 38);
            this.box_idProveedor.TabIndex = 1;
            this.box_idProveedor.TextChanged += new System.EventHandler(this.box_idProveedor_TextChanged);
            // 
            // label_idProducto
            // 
            this.label_idProducto.AutoSize = true;
            this.label_idProducto.BackColor = System.Drawing.Color.White;
            this.label_idProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.label_idProducto.Location = new System.Drawing.Point(38, 44);
            this.label_idProducto.Name = "label_idProducto";
            this.label_idProducto.Size = new System.Drawing.Size(217, 32);
            this.label_idProducto.TabIndex = 34;
            this.label_idProducto.Text = "ID del proveedor:";
            // 
            // box_nombreProveedor
            // 
            this.box_nombreProveedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_nombreProveedor.Location = new System.Drawing.Point(329, 101);
            this.box_nombreProveedor.Name = "box_nombreProveedor";
            this.box_nombreProveedor.Size = new System.Drawing.Size(442, 38);
            this.box_nombreProveedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(38, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre del proveedor:";
            // 
            // box_direccionProveedor
            // 
            this.box_direccionProveedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_direccionProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_direccionProveedor.Location = new System.Drawing.Point(344, 166);
            this.box_direccionProveedor.Multiline = true;
            this.box_direccionProveedor.Name = "box_direccionProveedor";
            this.box_direccionProveedor.Size = new System.Drawing.Size(592, 154);
            this.box_direccionProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(38, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dirección del proveedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.label10.Location = new System.Drawing.Point(38, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(466, 32);
            this.label10.TabIndex = 50;
            this.label10.Text = "Información de contacto del proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label9.Location = new System.Drawing.Point(725, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 30);
            this.label9.TabIndex = 49;
            this.label9.Text = "Correos electronicos soportados";
            // 
            // box_correoProveedor
            // 
            this.box_correoProveedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_correoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_correoProveedor.Location = new System.Drawing.Point(261, 568);
            this.box_correoProveedor.Name = "box_correoProveedor";
            this.box_correoProveedor.Size = new System.Drawing.Size(393, 38);
            this.box_correoProveedor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(39, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 30);
            this.label6.TabIndex = 48;
            this.label6.Text = "Correo electrónico:";
            // 
            // box_telefonoProveedor
            // 
            this.box_telefonoProveedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_telefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_telefonoProveedor.Location = new System.Drawing.Point(281, 499);
            this.box_telefonoProveedor.Name = "box_telefonoProveedor";
            this.box_telefonoProveedor.Size = new System.Drawing.Size(367, 38);
            this.box_telefonoProveedor.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label8.Location = new System.Drawing.Point(39, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 30);
            this.label8.TabIndex = 46;
            this.label8.Text = "Teléfono de contacto:";
            // 
            // down_metodoPagoProveedor
            // 
            this.down_metodoPagoProveedor.BackColor = System.Drawing.Color.White;
            this.down_metodoPagoProveedor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.down_metodoPagoProveedor.Items.Add("Efectivo");
            this.down_metodoPagoProveedor.Items.Add("Tarjeta Débito/Crédito");
            this.down_metodoPagoProveedor.Location = new System.Drawing.Point(390, 361);
            this.down_metodoPagoProveedor.Name = "down_metodoPagoProveedor";
            this.down_metodoPagoProveedor.ReadOnly = true;
            this.down_metodoPagoProveedor.Size = new System.Drawing.Size(381, 39);
            this.down_metodoPagoProveedor.TabIndex = 4;
            this.down_metodoPagoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label18.Location = new System.Drawing.Point(39, 364);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(345, 30);
            this.label18.TabIndex = 62;
            this.label18.Text = "Método de pago del proveedor:";
            // 
            // btn_eliminarProveedor
            // 
            this.btn_eliminarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_eliminarProveedor.BackColor = System.Drawing.Color.Red;
            this.btn_eliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_eliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarProveedor.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_eliminarProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_eliminarProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_eliminarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarProveedor.Location = new System.Drawing.Point(790, 762);
            this.btn_eliminarProveedor.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_eliminarProveedor.MaximumSize = new System.Drawing.Size(182, 59);
            this.btn_eliminarProveedor.MinimumSize = new System.Drawing.Size(182, 59);
            this.btn_eliminarProveedor.Name = "btn_eliminarProveedor";
            this.btn_eliminarProveedor.Size = new System.Drawing.Size(182, 59);
            this.btn_eliminarProveedor.TabIndex = 10;
            this.btn_eliminarProveedor.Text = "ELIMINAR";
            this.btn_eliminarProveedor.UseVisualStyleBackColor = false;
            this.btn_eliminarProveedor.Click += new System.EventHandler(this.btn_eliminarProveedor_Click);
            // 
            // btn_actualizarProveedor
            // 
            this.btn_actualizarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_actualizarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.btn_actualizarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_actualizarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarProveedor.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_actualizarProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_actualizarProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_actualizarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizarProveedor.Location = new System.Drawing.Point(576, 762);
            this.btn_actualizarProveedor.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_actualizarProveedor.MaximumSize = new System.Drawing.Size(186, 59);
            this.btn_actualizarProveedor.MinimumSize = new System.Drawing.Size(186, 59);
            this.btn_actualizarProveedor.Name = "btn_actualizarProveedor";
            this.btn_actualizarProveedor.Size = new System.Drawing.Size(186, 59);
            this.btn_actualizarProveedor.TabIndex = 9;
            this.btn_actualizarProveedor.Text = "ACTUALIZAR";
            this.btn_actualizarProveedor.UseVisualStyleBackColor = false;
            this.btn_actualizarProveedor.Click += new System.EventHandler(this.btn_actualizarProveedor_Click);
            // 
            // btn_buscarProveedor
            // 
            this.btn_buscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_buscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.btn_buscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_buscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarProveedor.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_buscarProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_buscarProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_buscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_buscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarProveedor.Location = new System.Drawing.Point(364, 762);
            this.btn_buscarProveedor.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_buscarProveedor.MaximumSize = new System.Drawing.Size(184, 59);
            this.btn_buscarProveedor.MinimumSize = new System.Drawing.Size(184, 59);
            this.btn_buscarProveedor.Name = "btn_buscarProveedor";
            this.btn_buscarProveedor.Size = new System.Drawing.Size(184, 59);
            this.btn_buscarProveedor.TabIndex = 8;
            this.btn_buscarProveedor.Text = "BUSCAR";
            this.btn_buscarProveedor.UseVisualStyleBackColor = false;
            this.btn_buscarProveedor.Click += new System.EventHandler(this.btn_buscarProveedor_Click);
            // 
            // btn_crearProveedor
            // 
            this.btn_crearProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_crearProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.btn_crearProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearProveedor.FlatAppearance.BorderSize = 0;
            this.btn_crearProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearProveedor.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_crearProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_crearProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_crearProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_crearProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crearProveedor.Location = new System.Drawing.Point(164, 762);
            this.btn_crearProveedor.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_crearProveedor.MaximumSize = new System.Drawing.Size(172, 59);
            this.btn_crearProveedor.MinimumSize = new System.Drawing.Size(172, 59);
            this.btn_crearProveedor.Name = "btn_crearProveedor";
            this.btn_crearProveedor.Size = new System.Drawing.Size(172, 59);
            this.btn_crearProveedor.TabIndex = 7;
            this.btn_crearProveedor.Text = "CREAR";
            this.btn_crearProveedor.UseVisualStyleBackColor = false;
            this.btn_crearProveedor.Click += new System.EventHandler(this.btn_crearProveedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label7.Location = new System.Drawing.Point(726, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 120);
            this.label7.TabIndex = 47;
            this.label7.Text = "1. Outlook\r\n2. Gmail\r\n3. Protonmail\r\n4. Hotmail\r\n5. Correos institucionales (term" +
    "inados en .co.cr)\r\n6. Correos gubernamentales nacionales.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(130, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "IMPORTANTE: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(262, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(763, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Debe asegurarse de que ningún producto esté asociado al proveedor que desee elimi" +
    "nar.";
            // 
            // Fm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 871);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminarProveedor);
            this.Controls.Add(this.btn_actualizarProveedor);
            this.Controls.Add(this.btn_buscarProveedor);
            this.Controls.Add(this.btn_crearProveedor);
            this.Controls.Add(this.down_metodoPagoProveedor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_correoProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_telefonoProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.box_direccionProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_nombreProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_idProveedor);
            this.Controls.Add(this.label_idProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Proveedores";
            this.Text = "Fm_Proveedores";
            this.Load += new System.EventHandler(this.Fm_Proveedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_idProveedor;
        private System.Windows.Forms.Label label_idProducto;
        private System.Windows.Forms.TextBox box_nombreProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_direccionProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox box_correoProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_telefonoProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown down_metodoPagoProveedor;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btn_eliminarProveedor;
        private FontAwesome.Sharp.IconButton btn_actualizarProveedor;
        private FontAwesome.Sharp.IconButton btn_buscarProveedor;
        private FontAwesome.Sharp.IconButton btn_crearProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}