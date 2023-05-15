
namespace Proyecto_PDV_Farmacia
{
    partial class Fm_logIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_logIn));
            this.panel_logbg = new System.Windows.Forms.Panel();
            this.label_nameFarm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.box_logUsername = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.box_logPassword = new System.Windows.Forms.TextBox();
            this.btn_logIn = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_formLogIn = new System.Windows.Forms.Panel();
            this.link_registerLog = new System.Windows.Forms.LinkLabel();
            this.panel_formLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logbg
            // 
            this.panel_logbg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_logbg.BackgroundImage")));
            this.panel_logbg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_logbg.Location = new System.Drawing.Point(0, -5);
            this.panel_logbg.Name = "panel_logbg";
            this.panel_logbg.Size = new System.Drawing.Size(667, 693);
            this.panel_logbg.TabIndex = 0;
            // 
            // label_nameFarm
            // 
            this.label_nameFarm.AutoSize = true;
            this.label_nameFarm.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold);
            this.label_nameFarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.label_nameFarm.Location = new System.Drawing.Point(110, 41);
            this.label_nameFarm.Name = "label_nameFarm";
            this.label_nameFarm.Size = new System.Drawing.Size(458, 74);
            this.label_nameFarm.TabIndex = 0;
            this.label_nameFarm.Text = "Farmacia Aurora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(237, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Iniciar sesión -";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_username.Location = new System.Drawing.Point(116, 221);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(283, 41);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Nombre de usuario";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // box_logUsername
            // 
            this.box_logUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.box_logUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_logUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 18.5F);
            this.box_logUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_logUsername.Location = new System.Drawing.Point(123, 272);
            this.box_logUsername.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.box_logUsername.MaxLength = 100;
            this.box_logUsername.Name = "box_logUsername";
            this.box_logUsername.Size = new System.Drawing.Size(431, 49);
            this.box_logUsername.TabIndex = 3;
            this.box_logUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_logUsername.TextChanged += new System.EventHandler(this.box_logUsername_TextChanged);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_password.Location = new System.Drawing.Point(116, 339);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(174, 41);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Contraseña";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // box_logPassword
            // 
            this.box_logPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_logPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 18.5F);
            this.box_logPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_logPassword.Location = new System.Drawing.Point(123, 393);
            this.box_logPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.box_logPassword.MaxLength = 400;
            this.box_logPassword.Name = "box_logPassword";
            this.box_logPassword.Size = new System.Drawing.Size(431, 49);
            this.box_logPassword.TabIndex = 5;
            this.box_logPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_logPassword.UseSystemPasswordChar = true;
            // 
            // btn_logIn
            // 
            this.btn_logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.btn_logIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logIn.FlatAppearance.BorderSize = 0;
            this.btn_logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logIn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_logIn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_logIn.ForeColor = System.Drawing.Color.White;
            this.btn_logIn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_logIn.IconColor = System.Drawing.Color.White;
            this.btn_logIn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_logIn.IconSize = 28;
            this.btn_logIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logIn.Location = new System.Drawing.Point(123, 505);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(431, 61);
            this.btn_logIn.TabIndex = 8;
            this.btn_logIn.Text = "Ingresar";
            this.btn_logIn.UseVisualStyleBackColor = false;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(413, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "© Aurora, 2023";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel_formLogIn
            // 
            this.panel_formLogIn.BackColor = System.Drawing.Color.White;
            this.panel_formLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_formLogIn.Controls.Add(this.label4);
            this.panel_formLogIn.Controls.Add(this.btn_logIn);
            this.panel_formLogIn.Controls.Add(this.link_registerLog);
            this.panel_formLogIn.Controls.Add(this.box_logPassword);
            this.panel_formLogIn.Controls.Add(this.label_password);
            this.panel_formLogIn.Controls.Add(this.box_logUsername);
            this.panel_formLogIn.Controls.Add(this.label_username);
            this.panel_formLogIn.Controls.Add(this.label1);
            this.panel_formLogIn.Controls.Add(this.label_nameFarm);
            this.panel_formLogIn.Location = new System.Drawing.Point(653, -2);
            this.panel_formLogIn.Name = "panel_formLogIn";
            this.panel_formLogIn.Size = new System.Drawing.Size(662, 690);
            this.panel_formLogIn.TabIndex = 1;
            this.panel_formLogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_formLogIn_Paint);
            // 
            // link_registerLog
            // 
            this.link_registerLog.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.link_registerLog.AutoSize = true;
            this.link_registerLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_registerLog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_registerLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.link_registerLog.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.link_registerLog.Location = new System.Drawing.Point(391, 461);
            this.link_registerLog.Name = "link_registerLog";
            this.link_registerLog.Size = new System.Drawing.Size(163, 23);
            this.link_registerLog.TabIndex = 7;
            this.link_registerLog.TabStop = true;
            this.link_registerLog.Text = "Mostrar contraseña ";
            this.link_registerLog.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.link_registerLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_registerLog_LinkClicked);
            // 
            // Fm_logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 688);
            this.Controls.Add(this.panel_formLogIn);
            this.Controls.Add(this.panel_logbg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1335, 735);
            this.MinimumSize = new System.Drawing.Size(1335, 735);
            this.Name = "Fm_logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Aurora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fm_logIn_FormClosing);
            this.panel_formLogIn.ResumeLayout(false);
            this.panel_formLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logbg;
        private System.Windows.Forms.Label label_nameFarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox box_logUsername;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox box_logPassword;
        private FontAwesome.Sharp.IconButton btn_logIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_formLogIn;
        private System.Windows.Forms.LinkLabel link_registerLog;
    }
}

