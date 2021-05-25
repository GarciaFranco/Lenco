
namespace LenCo
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTalle = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.rbPack = new System.Windows.Forms.RadioButton();
            this.rbIndividual = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtStockN1 = new System.Windows.Forms.TextBox();
            this.lblStockN1 = new System.Windows.Forms.Label();
            this.txtStockN2 = new System.Windows.Forms.TextBox();
            this.lblStockN2 = new System.Windows.Forms.Label();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.btnCargarStock = new System.Windows.Forms.Button();
            this.btnEditarStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbProducto.SuspendLayout();
            this.gbStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(778, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar:";
            // 
            // txtBuqueda
            // 
            this.txtBuqueda.Location = new System.Drawing.Point(854, 12);
            this.txtBuqueda.Name = "txtBuqueda";
            this.txtBuqueda.Size = new System.Drawing.Size(174, 20);
            this.txtBuqueda.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1034, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 22);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(324, 45);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProductos.Size = new System.Drawing.Size(735, 311);
            this.dgvProductos.TabIndex = 10;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlta.Image")));
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(324, 8);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(104, 30);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "PRODUCTO";
            this.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(146, 282);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(141, 22);
            this.txtDescrip.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 77;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Talle";
            // 
            // cbTalle
            // 
            this.cbTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTalle.FormattingEnabled = true;
            this.cbTalle.Location = new System.Drawing.Point(146, 121);
            this.cbTalle.Margin = new System.Windows.Forms.Padding(4);
            this.cbTalle.Name = "cbTalle";
            this.cbTalle.Size = new System.Drawing.Size(141, 24);
            this.cbTalle.TabIndex = 67;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCargar.Location = new System.Drawing.Point(226, 312);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(62, 28);
            this.btnCargar.TabIndex = 79;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rbPack
            // 
            this.rbPack.AutoSize = true;
            this.rbPack.Location = new System.Drawing.Point(225, 222);
            this.rbPack.Margin = new System.Windows.Forms.Padding(4);
            this.rbPack.Name = "rbPack";
            this.rbPack.Size = new System.Drawing.Size(50, 17);
            this.rbPack.TabIndex = 74;
            this.rbPack.TabStop = true;
            this.rbPack.Text = "Pack";
            this.rbPack.UseVisualStyleBackColor = true;
            // 
            // rbIndividual
            // 
            this.rbIndividual.AutoSize = true;
            this.rbIndividual.Location = new System.Drawing.Point(147, 222);
            this.rbIndividual.Margin = new System.Windows.Forms.Padding(4);
            this.rbIndividual.Name = "rbIndividual";
            this.rbIndividual.Size = new System.Drawing.Size(70, 17);
            this.rbIndividual.TabIndex = 73;
            this.rbIndividual.TabStop = true;
            this.rbIndividual.Text = "Individual";
            this.rbIndividual.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(146, 252);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(93, 22);
            this.txtPrecio.TabIndex = 76;
            // 
            // cbColor
            // 
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(146, 185);
            this.cbColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(141, 24);
            this.cbColor.TabIndex = 71;
            // 
            // cbRubro
            // 
            this.cbRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(146, 153);
            this.cbRubro.Margin = new System.Windows.Forms.Padding(4);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(141, 24);
            this.cbRubro.TabIndex = 69;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(146, 91);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(93, 22);
            this.txtArticulo.TabIndex = 65;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(146, 29);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 22);
            this.txtCodigo.TabIndex = 61;
            // 
            // cbMarca
            // 
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(146, 59);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(141, 24);
            this.cbMarca.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Articulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Color";
            // 
            // lblPres
            // 
            this.lblPres.AutoSize = true;
            this.lblPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPres.Location = new System.Drawing.Point(20, 221);
            this.lblPres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(107, 18);
            this.lblPres.TabIndex = 72;
            this.lblPres.Text = "Presentacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Marca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 60;
            this.label10.Text = "Codigo";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(881, 363);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 30);
            this.btnModificar.TabIndex = 80;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(974, 363);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 30);
            this.btnEliminar.TabIndex = 81;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.label10);
            this.gbProducto.Controls.Add(this.label2);
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Controls.Add(this.txtDescrip);
            this.gbProducto.Controls.Add(this.lblPres);
            this.gbProducto.Controls.Add(this.label9);
            this.gbProducto.Controls.Add(this.label5);
            this.gbProducto.Controls.Add(this.label8);
            this.gbProducto.Controls.Add(this.label6);
            this.gbProducto.Controls.Add(this.cbTalle);
            this.gbProducto.Controls.Add(this.label7);
            this.gbProducto.Controls.Add(this.cbMarca);
            this.gbProducto.Controls.Add(this.rbPack);
            this.gbProducto.Controls.Add(this.txtCodigo);
            this.gbProducto.Controls.Add(this.btnCargar);
            this.gbProducto.Controls.Add(this.rbIndividual);
            this.gbProducto.Controls.Add(this.txtArticulo);
            this.gbProducto.Controls.Add(this.txtPrecio);
            this.gbProducto.Controls.Add(this.cbRubro);
            this.gbProducto.Controls.Add(this.cbColor);
            this.gbProducto.Location = new System.Drawing.Point(25, 14);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(295, 343);
            this.gbProducto.TabIndex = 82;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Gestionar producto";
            // 
            // txtStockN1
            // 
            this.txtStockN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockN1.Location = new System.Drawing.Point(76, 25);
            this.txtStockN1.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockN1.Name = "txtStockN1";
            this.txtStockN1.Size = new System.Drawing.Size(53, 22);
            this.txtStockN1.TabIndex = 83;
            // 
            // lblStockN1
            // 
            this.lblStockN1.AutoSize = true;
            this.lblStockN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockN1.Location = new System.Drawing.Point(7, 28);
            this.lblStockN1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockN1.Name = "lblStockN1";
            this.lblStockN1.Size = new System.Drawing.Size(61, 16);
            this.lblStockN1.TabIndex = 82;
            this.lblStockN1.Text = "Nana 1:";
            // 
            // txtStockN2
            // 
            this.txtStockN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockN2.Location = new System.Drawing.Point(213, 25);
            this.txtStockN2.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockN2.Name = "txtStockN2";
            this.txtStockN2.Size = new System.Drawing.Size(53, 22);
            this.txtStockN2.TabIndex = 85;
            // 
            // lblStockN2
            // 
            this.lblStockN2.AutoSize = true;
            this.lblStockN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockN2.Location = new System.Drawing.Point(144, 28);
            this.lblStockN2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockN2.Name = "lblStockN2";
            this.lblStockN2.Size = new System.Drawing.Size(61, 16);
            this.lblStockN2.TabIndex = 84;
            this.lblStockN2.Text = "Nana 2:";
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.btnCargarStock);
            this.gbStock.Controls.Add(this.txtStockN2);
            this.gbStock.Controls.Add(this.lblStockN1);
            this.gbStock.Controls.Add(this.lblStockN2);
            this.gbStock.Controls.Add(this.txtStockN1);
            this.gbStock.Location = new System.Drawing.Point(25, 373);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(287, 98);
            this.gbStock.TabIndex = 86;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Gestionar Stock";
            // 
            // btnCargarStock
            // 
            this.btnCargarStock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCargarStock.FlatAppearance.BorderSize = 0;
            this.btnCargarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCargarStock.Location = new System.Drawing.Point(204, 55);
            this.btnCargarStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarStock.Name = "btnCargarStock";
            this.btnCargarStock.Size = new System.Drawing.Size(62, 28);
            this.btnCargarStock.TabIndex = 87;
            this.btnCargarStock.Text = "Cargar";
            this.btnCargarStock.UseVisualStyleBackColor = false;
            this.btnCargarStock.Click += new System.EventHandler(this.btnCargarStock_Click);
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarStock.Location = new System.Drawing.Point(324, 363);
            this.btnEditarStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(128, 30);
            this.btnEditarStock.TabIndex = 87;
            this.btnEditarStock.Text = "Editar Stock";
            this.btnEditarStock.UseVisualStyleBackColor = true;
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.btnEditarStock);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTalle;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton rbPack;
        private System.Windows.Forms.RadioButton rbIndividual;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.TextBox txtStockN1;
        private System.Windows.Forms.Label lblStockN1;
        private System.Windows.Forms.TextBox txtStockN2;
        private System.Windows.Forms.Label lblStockN2;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Button btnCargarStock;
        private System.Windows.Forms.Button btnEditarStock;
    }
}