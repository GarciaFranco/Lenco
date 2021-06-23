
namespace LenCo.Vista
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnAdmCompras = new System.Windows.Forms.Button();
            this.btnAdmProductos = new System.Windows.Forms.Button();
            this.btnAdmDevoluc = new System.Windows.Forms.Button();
            this.btnAdmVentas = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsuarioLog = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.btnDevoluc = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.lblUsuarioLog);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.picbLogo);
            this.panelMenu.Controls.Add(this.btnDevoluc);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 660);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(55, 597);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 35);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.Gray;
            this.panelSubMenu.Controls.Add(this.btnAdmCompras);
            this.panelSubMenu.Controls.Add(this.btnAdmProductos);
            this.panelSubMenu.Controls.Add(this.btnAdmDevoluc);
            this.panelSubMenu.Controls.Add(this.btnAdmVentas);
            this.panelSubMenu.Location = new System.Drawing.Point(63, 169);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(147, 104);
            this.panelSubMenu.TabIndex = 10;
            // 
            // btnAdmCompras
            // 
            this.btnAdmCompras.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdmCompras.FlatAppearance.BorderSize = 0;
            this.btnAdmCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdmCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmCompras.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmCompras.Location = new System.Drawing.Point(3, 52);
            this.btnAdmCompras.Name = "btnAdmCompras";
            this.btnAdmCompras.Size = new System.Drawing.Size(144, 26);
            this.btnAdmCompras.TabIndex = 13;
            this.btnAdmCompras.Text = "Compras";
            this.btnAdmCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmCompras.UseVisualStyleBackColor = false;
            this.btnAdmCompras.Click += new System.EventHandler(this.btnAdmCompras_Click);
            // 
            // btnAdmProductos
            // 
            this.btnAdmProductos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdmProductos.FlatAppearance.BorderSize = 0;
            this.btnAdmProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdmProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmProductos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmProductos.Location = new System.Drawing.Point(3, 0);
            this.btnAdmProductos.Name = "btnAdmProductos";
            this.btnAdmProductos.Size = new System.Drawing.Size(144, 26);
            this.btnAdmProductos.TabIndex = 10;
            this.btnAdmProductos.Text = "Productos";
            this.btnAdmProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmProductos.UseVisualStyleBackColor = false;
            this.btnAdmProductos.Click += new System.EventHandler(this.btnAdmProductos_Click);
            // 
            // btnAdmDevoluc
            // 
            this.btnAdmDevoluc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdmDevoluc.FlatAppearance.BorderSize = 0;
            this.btnAdmDevoluc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdmDevoluc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmDevoluc.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmDevoluc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmDevoluc.Location = new System.Drawing.Point(3, 78);
            this.btnAdmDevoluc.Name = "btnAdmDevoluc";
            this.btnAdmDevoluc.Size = new System.Drawing.Size(144, 26);
            this.btnAdmDevoluc.TabIndex = 12;
            this.btnAdmDevoluc.Text = "Devoluciones";
            this.btnAdmDevoluc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmDevoluc.UseVisualStyleBackColor = false;
            this.btnAdmDevoluc.Click += new System.EventHandler(this.btnAdmDevoluc_Click);
            // 
            // btnAdmVentas
            // 
            this.btnAdmVentas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdmVentas.FlatAppearance.BorderSize = 0;
            this.btnAdmVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdmVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmVentas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmVentas.Location = new System.Drawing.Point(3, 26);
            this.btnAdmVentas.Name = "btnAdmVentas";
            this.btnAdmVentas.Size = new System.Drawing.Size(144, 26);
            this.btnAdmVentas.TabIndex = 11;
            this.btnAdmVentas.Text = "Ventas";
            this.btnAdmVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmVentas.UseVisualStyleBackColor = false;
            this.btnAdmVentas.Click += new System.EventHandler(this.btnAdmVentas_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 555);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.AutoSize = true;
            this.lblUsuarioLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLog.Location = new System.Drawing.Point(31, 522);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(144, 18);
            this.lblUsuarioLog.TabIndex = 0;
            this.lblUsuarioLog.Text = "Bienvenido Usuario";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 132);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(210, 36);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "   Administración";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // picbLogo
            // 
            this.picbLogo.Image = ((System.Drawing.Image)(resources.GetObject("picbLogo.Image")));
            this.picbLogo.Location = new System.Drawing.Point(12, 12);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(184, 89);
            this.picbLogo.TabIndex = 7;
            this.picbLogo.TabStop = false;
            // 
            // btnDevoluc
            // 
            this.btnDevoluc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDevoluc.FlatAppearance.BorderSize = 0;
            this.btnDevoluc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDevoluc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluc.Image = ((System.Drawing.Image)(resources.GetObject("btnDevoluc.Image")));
            this.btnDevoluc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluc.Location = new System.Drawing.Point(0, 363);
            this.btnDevoluc.Name = "btnDevoluc";
            this.btnDevoluc.Size = new System.Drawing.Size(210, 36);
            this.btnDevoluc.TabIndex = 5;
            this.btnDevoluc.Text = "Devoluciones";
            this.btnDevoluc.UseVisualStyleBackColor = false;
            this.btnDevoluc.Click += new System.EventHandler(this.btnDevoluc_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 321);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(210, 36);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 277);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(210, 38);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Location = new System.Drawing.Point(210, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1070, 660);
            this.panelContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1070, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naná Lenceria";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDevoluc;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblUsuarioLog;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdmCompras;
        private System.Windows.Forms.Button btnAdmDevoluc;
        private System.Windows.Forms.Button btnAdmVentas;
        private System.Windows.Forms.Button btnAdmProductos;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}