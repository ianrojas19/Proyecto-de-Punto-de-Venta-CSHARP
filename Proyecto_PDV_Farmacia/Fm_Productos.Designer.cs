
namespace Proyecto_PDV_Farmacia
{
    partial class Fm_Productos
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
            this.label_idProducto = new System.Windows.Forms.Label();
            this.box_idProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_nombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_descProducto = new System.Windows.Forms.TextBox();
            this.btn_crearProducto = new FontAwesome.Sharp.IconButton();
            this.btn_buscarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_actualizarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_eliminarProducto = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.date_fechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_precioProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pick_cantidadInicialProducto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.box_tipoProductoProducto = new System.Windows.Forms.TextBox();
            this.box_idTipoProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radio_requiereReceta = new System.Windows.Forms.RadioButton();
            this.radio_NORequiereReceta = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.box_idProveedorProd = new System.Windows.Forms.TextBox();
            this.box_nombreProveedorProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pick_cantidadInicialProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label_idProducto
            // 
            this.label_idProducto.AutoSize = true;
            this.label_idProducto.BackColor = System.Drawing.Color.White;
            this.label_idProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.label_idProducto.Location = new System.Drawing.Point(32, 45);
            this.label_idProducto.Name = "label_idProducto";
            this.label_idProducto.Size = new System.Drawing.Size(203, 32);
            this.label_idProducto.TabIndex = 0;
            this.label_idProducto.Text = "ID del producto:";
            this.label_idProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // box_idProducto
            // 
            this.box_idProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_idProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_idProducto.Location = new System.Drawing.Point(242, 42);
            this.box_idProducto.Name = "box_idProducto";
            this.box_idProducto.Size = new System.Drawing.Size(360, 38);
            this.box_idProducto.TabIndex = 1;
            this.box_idProducto.TextChanged += new System.EventHandler(this.box_idProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del producto:";
            // 
            // box_nombreProducto
            // 
            this.box_nombreProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_nombreProducto.Location = new System.Drawing.Point(294, 104);
            this.box_nombreProducto.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.box_nombreProducto.Name = "box_nombreProducto";
            this.box_nombreProducto.Size = new System.Drawing.Size(538, 38);
            this.box_nombreProducto.TabIndex = 2;
            this.box_nombreProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(32, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción del producto:";
            // 
            // box_descProducto
            // 
            this.box_descProducto.BackColor = System.Drawing.Color.White;
            this.box_descProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_descProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_descProducto.Location = new System.Drawing.Point(330, 166);
            this.box_descProducto.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.box_descProducto.MaxLength = 100;
            this.box_descProducto.Multiline = true;
            this.box_descProducto.Name = "box_descProducto";
            this.box_descProducto.Size = new System.Drawing.Size(717, 168);
            this.box_descProducto.TabIndex = 3;
            // 
            // btn_crearProducto
            // 
            this.btn_crearProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_crearProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.btn_crearProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearProducto.FlatAppearance.BorderSize = 0;
            this.btn_crearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearProducto.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearProducto.ForeColor = System.Drawing.Color.White;
            this.btn_crearProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_crearProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_crearProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_crearProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crearProducto.Location = new System.Drawing.Point(169, 744);
            this.btn_crearProducto.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_crearProducto.MaximumSize = new System.Drawing.Size(172, 59);
            this.btn_crearProducto.MinimumSize = new System.Drawing.Size(172, 59);
            this.btn_crearProducto.Name = "btn_crearProducto";
            this.btn_crearProducto.Size = new System.Drawing.Size(172, 59);
            this.btn_crearProducto.TabIndex = 13;
            this.btn_crearProducto.Text = "CREAR";
            this.btn_crearProducto.UseVisualStyleBackColor = false;
            this.btn_crearProducto.Click += new System.EventHandler(this.btn_crearProducto_Click);
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_buscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.btn_buscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarProducto.FlatAppearance.BorderSize = 0;
            this.btn_buscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarProducto.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_buscarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_buscarProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_buscarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_buscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarProducto.Location = new System.Drawing.Point(369, 744);
            this.btn_buscarProducto.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_buscarProducto.MaximumSize = new System.Drawing.Size(184, 59);
            this.btn_buscarProducto.MinimumSize = new System.Drawing.Size(184, 59);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(184, 59);
            this.btn_buscarProducto.TabIndex = 14;
            this.btn_buscarProducto.Text = "BUSCAR";
            this.btn_buscarProducto.UseVisualStyleBackColor = false;
            this.btn_buscarProducto.Click += new System.EventHandler(this.btn_buscarProducto_Click);
            // 
            // btn_actualizarProducto
            // 
            this.btn_actualizarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_actualizarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.btn_actualizarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizarProducto.FlatAppearance.BorderSize = 0;
            this.btn_actualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarProducto.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_actualizarProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_actualizarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_actualizarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizarProducto.Location = new System.Drawing.Point(581, 744);
            this.btn_actualizarProducto.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_actualizarProducto.MaximumSize = new System.Drawing.Size(186, 59);
            this.btn_actualizarProducto.MinimumSize = new System.Drawing.Size(186, 59);
            this.btn_actualizarProducto.Name = "btn_actualizarProducto";
            this.btn_actualizarProducto.Size = new System.Drawing.Size(186, 59);
            this.btn_actualizarProducto.TabIndex = 15;
            this.btn_actualizarProducto.Text = "ACTUALIZAR";
            this.btn_actualizarProducto.UseVisualStyleBackColor = false;
            this.btn_actualizarProducto.Click += new System.EventHandler(this.btn_actualizarProducto_Click);
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_eliminarProducto.BackColor = System.Drawing.Color.Red;
            this.btn_eliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarProducto.FlatAppearance.BorderSize = 0;
            this.btn_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarProducto.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_eliminarProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_eliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_eliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarProducto.Location = new System.Drawing.Point(795, 744);
            this.btn_eliminarProducto.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btn_eliminarProducto.MaximumSize = new System.Drawing.Size(182, 59);
            this.btn_eliminarProducto.MinimumSize = new System.Drawing.Size(182, 59);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Size = new System.Drawing.Size(182, 59);
            this.btn_eliminarProducto.TabIndex = 16;
            this.btn_eliminarProducto.Text = "ELIMINAR";
            this.btn_eliminarProducto.UseVisualStyleBackColor = false;
            this.btn_eliminarProducto.Click += new System.EventHandler(this.btn_eliminarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(32, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de caducidad:";
            // 
            // date_fechaCaducidad
            // 
            this.date_fechaCaducidad.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fechaCaducidad.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.date_fechaCaducidad.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date_fechaCaducidad.Checked = false;
            this.date_fechaCaducidad.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.date_fechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fechaCaducidad.Location = new System.Drawing.Point(273, 381);
            this.date_fechaCaducidad.Name = "date_fechaCaducidad";
            this.date_fechaCaducidad.Size = new System.Drawing.Size(444, 41);
            this.date_fechaCaducidad.TabIndex = 4;
            this.date_fechaCaducidad.ValueChanged += new System.EventHandler(this.date_fechaCaducidad_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(765, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Receta necesaria:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(533, 475);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio por unidad:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // box_precioProducto
            // 
            this.box_precioProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_precioProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_precioProducto.Location = new System.Drawing.Point(753, 472);
            this.box_precioProducto.Name = "box_precioProducto";
            this.box_precioProducto.Size = new System.Drawing.Size(233, 38);
            this.box_precioProducto.TabIndex = 8;
            this.box_precioProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.box_precioProducto.TextChanged += new System.EventHandler(this.box_precioProducto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(32, 475);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantidad de existencias:";
            // 
            // pick_cantidadInicialProducto
            // 
            this.pick_cantidadInicialProducto.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pick_cantidadInicialProducto.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pick_cantidadInicialProducto.Location = new System.Drawing.Point(315, 470);
            this.pick_cantidadInicialProducto.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.pick_cantidadInicialProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pick_cantidadInicialProducto.Name = "pick_cantidadInicialProducto";
            this.pick_cantidadInicialProducto.Size = new System.Drawing.Size(189, 41);
            this.pick_cantidadInicialProducto.TabIndex = 7;
            this.pick_cantidadInicialProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pick_cantidadInicialProducto.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pick_cantidadInicialProducto.ValueChanged += new System.EventHandler(this.pick_cantidadInicialProducto_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label8.Location = new System.Drawing.Point(485, 631);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nombre de tipo de producto:";
            // 
            // box_tipoProductoProducto
            // 
            this.box_tipoProductoProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_tipoProductoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_tipoProductoProducto.Location = new System.Drawing.Point(825, 628);
            this.box_tipoProductoProducto.Name = "box_tipoProductoProducto";
            this.box_tipoProductoProducto.ReadOnly = true;
            this.box_tipoProductoProducto.Size = new System.Drawing.Size(254, 38);
            this.box_tipoProductoProducto.TabIndex = 12;
            // 
            // box_idTipoProd
            // 
            this.box_idTipoProd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_idTipoProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_idTipoProd.Location = new System.Drawing.Point(322, 628);
            this.box_idTipoProd.Name = "box_idTipoProd";
            this.box_idTipoProd.Size = new System.Drawing.Size(144, 38);
            this.box_idTipoProd.TabIndex = 11;
            this.box_idTipoProd.Leave += new System.EventHandler(this.box_idTipoProductoProducto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.label9.Location = new System.Drawing.Point(32, 631);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID de tipo de producto:";
            // 
            // radio_requiereReceta
            // 
            this.radio_requiereReceta.AutoSize = true;
            this.radio_requiereReceta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.radio_requiereReceta.Location = new System.Drawing.Point(771, 402);
            this.radio_requiereReceta.Name = "radio_requiereReceta";
            this.radio_requiereReceta.Size = new System.Drawing.Size(112, 27);
            this.radio_requiereReceta.TabIndex = 5;
            this.radio_requiereReceta.Text = "Si requiere";
            this.radio_requiereReceta.UseVisualStyleBackColor = true;
            this.radio_requiereReceta.CheckedChanged += new System.EventHandler(this.radio_requiereReceta_CheckedChanged);
            // 
            // radio_NORequiereReceta
            // 
            this.radio_NORequiereReceta.AutoSize = true;
            this.radio_NORequiereReceta.Checked = true;
            this.radio_NORequiereReceta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.radio_NORequiereReceta.Location = new System.Drawing.Point(889, 402);
            this.radio_NORequiereReceta.Name = "radio_NORequiereReceta";
            this.radio_NORequiereReceta.Size = new System.Drawing.Size(122, 27);
            this.radio_NORequiereReceta.TabIndex = 6;
            this.radio_NORequiereReceta.TabStop = true;
            this.radio_NORequiereReceta.Text = "No requiere";
            this.radio_NORequiereReceta.UseVisualStyleBackColor = true;
            this.radio_NORequiereReceta.CheckedChanged += new System.EventHandler(this.radio_NORequiereReceta_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.label7.Location = new System.Drawing.Point(32, 557);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID del proveedor:";
            // 
            // box_idProveedorProd
            // 
            this.box_idProveedorProd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_idProveedorProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_idProveedorProd.Location = new System.Drawing.Point(255, 554);
            this.box_idProveedorProd.Name = "box_idProveedorProd";
            this.box_idProveedorProd.Size = new System.Drawing.Size(173, 38);
            this.box_idProveedorProd.TabIndex = 9;
            this.box_idProveedorProd.TextChanged += new System.EventHandler(this.box_idProveedorProd_TextChanged);
            this.box_idProveedorProd.Leave += new System.EventHandler(this.box_idProveedorProd_Leave);
            // 
            // box_nombreProveedorProducto
            // 
            this.box_nombreProveedorProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nombreProveedorProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_nombreProveedorProducto.Location = new System.Drawing.Point(723, 554);
            this.box_nombreProveedorProducto.Name = "box_nombreProveedorProducto";
            this.box_nombreProveedorProducto.ReadOnly = true;
            this.box_nombreProveedorProducto.Size = new System.Drawing.Size(356, 38);
            this.box_nombreProveedorProducto.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label10.Location = new System.Drawing.Point(447, 557);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 32);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nombre del proveedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label11.Location = new System.Drawing.Point(992, 475);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 32);
            this.label11.TabIndex = 32;
            this.label11.Text = "cln.";
            // 
            // Fm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 871);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_idProveedorProd);
            this.Controls.Add(this.box_nombreProveedorProducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radio_NORequiereReceta);
            this.Controls.Add(this.radio_requiereReceta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.box_idTipoProd);
            this.Controls.Add(this.box_tipoProductoProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pick_cantidadInicialProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_precioProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_fechaCaducidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminarProducto);
            this.Controls.Add(this.btn_actualizarProducto);
            this.Controls.Add(this.btn_buscarProducto);
            this.Controls.Add(this.btn_crearProducto);
            this.Controls.Add(this.box_descProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_nombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_idProducto);
            this.Controls.Add(this.label_idProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Productos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Fm_Productos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pick_cantidadInicialProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_idProducto;
        private System.Windows.Forms.TextBox box_idProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_nombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_descProducto;
        private FontAwesome.Sharp.IconButton btn_crearProducto;
        private FontAwesome.Sharp.IconButton btn_buscarProducto;
        private FontAwesome.Sharp.IconButton btn_actualizarProducto;
        private FontAwesome.Sharp.IconButton btn_eliminarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_fechaCaducidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_precioProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown pick_cantidadInicialProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox box_tipoProductoProducto;
        private System.Windows.Forms.TextBox box_idTipoProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radio_requiereReceta;
        private System.Windows.Forms.RadioButton radio_NORequiereReceta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_idProveedorProd;
        private System.Windows.Forms.TextBox box_nombreProveedorProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}