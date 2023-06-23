﻿namespace pryGerhauser_I.E.LP1
{
    partial class frmCargaVentas
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
            this.tabControlCargaVenta = new System.Windows.Forms.TabControl();
            this.VentanaRegistro = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.mrcUltimaVenta = new System.Windows.Forms.GroupBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.mrcCargaVenta = new System.Windows.Forms.GroupBox();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.lblErrorID = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPtoducto = new System.Windows.Forms.Label();
            this.nUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.nUDID = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.VentanaConsulta = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.nUDCantidadConsulta = new System.Windows.Forms.NumericUpDown();
            this.rbCantidad = new System.Windows.Forms.RadioButton();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.cmbProductoConsulta = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlCargaVenta.SuspendLayout();
            this.VentanaRegistro.SuspendLayout();
            this.mrcUltimaVenta.SuspendLayout();
            this.mrcCargaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).BeginInit();
            this.VentanaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCargaVenta
            // 
            this.tabControlCargaVenta.Controls.Add(this.VentanaRegistro);
            this.tabControlCargaVenta.Controls.Add(this.VentanaConsulta);
            this.tabControlCargaVenta.Location = new System.Drawing.Point(14, 15);
            this.tabControlCargaVenta.Name = "tabControlCargaVenta";
            this.tabControlCargaVenta.SelectedIndex = 0;
            this.tabControlCargaVenta.Size = new System.Drawing.Size(373, 497);
            this.tabControlCargaVenta.TabIndex = 0;
            // 
            // VentanaRegistro
            // 
            this.VentanaRegistro.Controls.Add(this.btnCancelar);
            this.VentanaRegistro.Controls.Add(this.btnRegistrar);
            this.VentanaRegistro.Controls.Add(this.mrcUltimaVenta);
            this.VentanaRegistro.Controls.Add(this.mrcCargaVenta);
            this.VentanaRegistro.Location = new System.Drawing.Point(4, 22);
            this.VentanaRegistro.Name = "VentanaRegistro";
            this.VentanaRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaRegistro.Size = new System.Drawing.Size(365, 471);
            this.VentanaRegistro.TabIndex = 0;
            this.VentanaRegistro.Text = "Registrar";
            this.VentanaRegistro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(82, 383);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // mrcUltimaVenta
            // 
            this.mrcUltimaVenta.Controls.Add(this.lblDetalle);
            this.mrcUltimaVenta.Location = new System.Drawing.Point(82, 309);
            this.mrcUltimaVenta.Name = "mrcUltimaVenta";
            this.mrcUltimaVenta.Size = new System.Drawing.Size(201, 71);
            this.mrcUltimaVenta.TabIndex = 9;
            this.mrcUltimaVenta.TabStop = false;
            this.mrcUltimaVenta.Text = "UltimaVenta";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(6, 16);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "Detalle";
            // 
            // mrcCargaVenta
            // 
            this.mrcCargaVenta.Controls.Add(this.lblErrorCantidad);
            this.mrcCargaVenta.Controls.Add(this.lblErrorID);
            this.mrcCargaVenta.Controls.Add(this.lblTitulo);
            this.mrcCargaVenta.Controls.Add(this.lblFecha);
            this.mrcCargaVenta.Controls.Add(this.lblCantidad);
            this.mrcCargaVenta.Controls.Add(this.lblID);
            this.mrcCargaVenta.Controls.Add(this.lblPtoducto);
            this.mrcCargaVenta.Controls.Add(this.nUDCantidad);
            this.mrcCargaVenta.Controls.Add(this.nUDID);
            this.mrcCargaVenta.Controls.Add(this.dtpFecha);
            this.mrcCargaVenta.Controls.Add(this.cmbProducto);
            this.mrcCargaVenta.Location = new System.Drawing.Point(82, 22);
            this.mrcCargaVenta.Name = "mrcCargaVenta";
            this.mrcCargaVenta.Size = new System.Drawing.Size(201, 281);
            this.mrcCargaVenta.TabIndex = 8;
            this.mrcCargaVenta.TabStop = false;
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorCantidad.Location = new System.Drawing.Point(22, 198);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(70, 13);
            this.lblErrorCantidad.TabIndex = 13;
            this.lblErrorCantidad.Text = "No hay stock";
            this.lblErrorCantidad.Visible = false;
            // 
            // lblErrorID
            // 
            this.lblErrorID.AutoSize = true;
            this.lblErrorID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorID.Location = new System.Drawing.Point(21, 116);
            this.lblErrorID.Name = "lblErrorID";
            this.lblErrorID.Size = new System.Drawing.Size(136, 26);
            this.lblErrorID.TabIndex = 12;
            this.lblErrorID.Text = "ID incorrecto, ingrese \r\nuno valido(minimo 4 digitos)";
            this.lblErrorID.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitulo.Location = new System.Drawing.Point(69, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 17);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Venta";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(21, 221);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(22, 159);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // lblPtoducto
            // 
            this.lblPtoducto.AutoSize = true;
            this.lblPtoducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtoducto.Location = new System.Drawing.Point(21, 29);
            this.lblPtoducto.Name = "lblPtoducto";
            this.lblPtoducto.Size = new System.Drawing.Size(58, 13);
            this.lblPtoducto.TabIndex = 4;
            this.lblPtoducto.Text = "Producto";
            // 
            // nUDCantidad
            // 
            this.nUDCantidad.Location = new System.Drawing.Point(25, 175);
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(120, 20);
            this.nUDCantidad.TabIndex = 3;
            // 
            // nUDID
            // 
            this.nUDID.Location = new System.Drawing.Point(24, 93);
            this.nUDID.Name = "nUDID";
            this.nUDID.Size = new System.Drawing.Size(120, 20);
            this.nUDID.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(24, 237);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(141, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(24, 45);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 0;
            // 
            // VentanaConsulta
            // 
            this.VentanaConsulta.Controls.Add(this.btnConsultar);
            this.VentanaConsulta.Controls.Add(this.nUDCantidadConsulta);
            this.VentanaConsulta.Controls.Add(this.rbCantidad);
            this.VentanaConsulta.Controls.Add(this.rbProducto);
            this.VentanaConsulta.Controls.Add(this.cmbProductoConsulta);
            this.VentanaConsulta.Controls.Add(this.dataGridView1);
            this.VentanaConsulta.Location = new System.Drawing.Point(4, 22);
            this.VentanaConsulta.Name = "VentanaConsulta";
            this.VentanaConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaConsulta.Size = new System.Drawing.Size(365, 471);
            this.VentanaConsulta.TabIndex = 1;
            this.VentanaConsulta.Text = "Consultar";
            this.VentanaConsulta.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(252, 435);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(105, 24);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // nUDCantidadConsulta
            // 
            this.nUDCantidadConsulta.Location = new System.Drawing.Point(146, 38);
            this.nUDCantidadConsulta.Name = "nUDCantidadConsulta";
            this.nUDCantidadConsulta.Size = new System.Drawing.Size(84, 20);
            this.nUDCantidadConsulta.TabIndex = 4;
            // 
            // rbCantidad
            // 
            this.rbCantidad.AutoSize = true;
            this.rbCantidad.Location = new System.Drawing.Point(93, 15);
            this.rbCantidad.Name = "rbCantidad";
            this.rbCantidad.Size = new System.Drawing.Size(67, 17);
            this.rbCantidad.TabIndex = 3;
            this.rbCantidad.TabStop = true;
            this.rbCantidad.Text = "Cantidad";
            this.rbCantidad.UseVisualStyleBackColor = true;
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Location = new System.Drawing.Point(19, 15);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(68, 17);
            this.rbProducto.TabIndex = 2;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            // 
            // cmbProductoConsulta
            // 
            this.cmbProductoConsulta.FormattingEnabled = true;
            this.cmbProductoConsulta.Location = new System.Drawing.Point(19, 38);
            this.cmbProductoConsulta.Name = "cmbProductoConsulta";
            this.cmbProductoConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbProductoConsulta.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.ID,
            this.Cantidad,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(6, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 55;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 55;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 17);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlCargaVenta);
            this.Name = "frmCargaVentas";
            this.Text = "frmCargaVentas";
            this.tabControlCargaVenta.ResumeLayout(false);
            this.VentanaRegistro.ResumeLayout(false);
            this.mrcUltimaVenta.ResumeLayout(false);
            this.mrcUltimaVenta.PerformLayout();
            this.mrcCargaVenta.ResumeLayout(false);
            this.mrcCargaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).EndInit();
            this.VentanaConsulta.ResumeLayout(false);
            this.VentanaConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCargaVenta;
        private System.Windows.Forms.TabPage VentanaRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox mrcUltimaVenta;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.GroupBox mrcCargaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPtoducto;
        private System.Windows.Forms.NumericUpDown nUDCantidad;
        private System.Windows.Forms.NumericUpDown nUDID;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TabPage VentanaConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.NumericUpDown nUDCantidadConsulta;
        private System.Windows.Forms.RadioButton rbCantidad;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.ComboBox cmbProductoConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblErrorCantidad;
        private System.Windows.Forms.Label lblErrorID;
    }
}