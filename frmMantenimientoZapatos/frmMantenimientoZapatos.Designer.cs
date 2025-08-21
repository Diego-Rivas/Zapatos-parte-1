namespace frmMantenimientoZapatos
{
    partial class frmMantenimientoZapatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabZapatos = new System.Windows.Forms.TabControl();
            this.tpRegistrarZapato = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAñadirImg = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.gbSecundario = new System.Windows.Forms.GroupBox();
            this.dgvProductosAlmacen = new System.Windows.Forms.DataGridView();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioZapato = new System.Windows.Forms.TextBox();
            this.txtNombreZapato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpActualizarInformacion = new System.Windows.Forms.TabPage();
            this.gbPrincipalActInfo = new System.Windows.Forms.GroupBox();
            this.gbSecundarioActInfo = new System.Windows.Forms.GroupBox();
            this.dgvMostrarProducAlmacen = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreZapatoActInfo = new System.Windows.Forms.TextBox();
            this.txtPrecioActInfo = new System.Windows.Forms.TextBox();
            this.dtpFechaIngresoActInfo = new System.Windows.Forms.DateTimePicker();
            this.cmbCategoriaActInfo = new System.Windows.Forms.ComboBox();
            this.txtBuscarInfo = new System.Windows.Forms.TextBox();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabZapatos.SuspendLayout();
            this.tpRegistrarZapato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAlmacen)).BeginInit();
            this.gbPrincipal.SuspendLayout();
            this.tpActualizarInformacion.SuspendLayout();
            this.gbPrincipalActInfo.SuspendLayout();
            this.gbSecundarioActInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProducAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabZapatos
            // 
            this.tabZapatos.Controls.Add(this.tpRegistrarZapato);
            this.tabZapatos.Controls.Add(this.tpActualizarInformacion);
            this.tabZapatos.Location = new System.Drawing.Point(4, 2);
            this.tabZapatos.Margin = new System.Windows.Forms.Padding(4);
            this.tabZapatos.Name = "tabZapatos";
            this.tabZapatos.SelectedIndex = 0;
            this.tabZapatos.Size = new System.Drawing.Size(922, 550);
            this.tabZapatos.TabIndex = 1;
            // 
            // tpRegistrarZapato
            // 
            this.tpRegistrarZapato.Controls.Add(this.btnEliminar);
            this.tpRegistrarZapato.Controls.Add(this.btnRegistrar);
            this.tpRegistrarZapato.Controls.Add(this.btnAñadirImg);
            this.tpRegistrarZapato.Controls.Add(this.pbImagen);
            this.tpRegistrarZapato.Controls.Add(this.gbSecundario);
            this.tpRegistrarZapato.Controls.Add(this.gbPrincipal);
            this.tpRegistrarZapato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRegistrarZapato.Location = new System.Drawing.Point(4, 25);
            this.tpRegistrarZapato.Margin = new System.Windows.Forms.Padding(4);
            this.tpRegistrarZapato.Name = "tpRegistrarZapato";
            this.tpRegistrarZapato.Padding = new System.Windows.Forms.Padding(4);
            this.tpRegistrarZapato.Size = new System.Drawing.Size(914, 521);
            this.tpRegistrarZapato.TabIndex = 0;
            this.tpRegistrarZapato.Text = "Registrar Zapatos";
            this.tpRegistrarZapato.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(754, 242);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(754, 207);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 28);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAñadirImg
            // 
            this.btnAñadirImg.Location = new System.Drawing.Point(754, 171);
            this.btnAñadirImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirImg.Name = "btnAñadirImg";
            this.btnAñadirImg.Size = new System.Drawing.Size(88, 28);
            this.btnAñadirImg.TabIndex = 3;
            this.btnAñadirImg.Text = "Añadir imagen";
            this.btnAñadirImg.UseVisualStyleBackColor = true;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(692, 22);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(201, 134);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // gbSecundario
            // 
            this.gbSecundario.Controls.Add(this.dgvProductosAlmacen);
            this.gbSecundario.Location = new System.Drawing.Point(16, 272);
            this.gbSecundario.Margin = new System.Windows.Forms.Padding(4);
            this.gbSecundario.Name = "gbSecundario";
            this.gbSecundario.Padding = new System.Windows.Forms.Padding(4);
            this.gbSecundario.Size = new System.Drawing.Size(877, 233);
            this.gbSecundario.TabIndex = 1;
            this.gbSecundario.TabStop = false;
            this.gbSecundario.Text = "Productos de Almacen";
            // 
            // dgvProductosAlmacen
            // 
            this.dgvProductosAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAlmacen.Location = new System.Drawing.Point(7, 23);
            this.dgvProductosAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosAlmacen.Name = "dgvProductosAlmacen";
            this.dgvProductosAlmacen.Size = new System.Drawing.Size(862, 206);
            this.dgvProductosAlmacen.TabIndex = 0;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.cmbCategoria);
            this.gbPrincipal.Controls.Add(this.dtpFechaRegistro);
            this.gbPrincipal.Controls.Add(this.txtPrecioZapato);
            this.gbPrincipal.Controls.Add(this.txtNombreZapato);
            this.gbPrincipal.Controls.Add(this.label4);
            this.gbPrincipal.Controls.Add(this.label3);
            this.gbPrincipal.Controls.Add(this.label2);
            this.gbPrincipal.Controls.Add(this.label1);
            this.gbPrincipal.Location = new System.Drawing.Point(16, 17);
            this.gbPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.gbPrincipal.Size = new System.Drawing.Size(653, 247);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Info. Zapato";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(193, 160);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(293, 24);
            this.cmbCategoria.TabIndex = 7;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(193, 123);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(293, 22);
            this.dtpFechaRegistro.TabIndex = 6;
            // 
            // txtPrecioZapato
            // 
            this.txtPrecioZapato.Location = new System.Drawing.Point(193, 84);
            this.txtPrecioZapato.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioZapato.Name = "txtPrecioZapato";
            this.txtPrecioZapato.Size = new System.Drawing.Size(293, 22);
            this.txtPrecioZapato.TabIndex = 5;
            // 
            // txtNombreZapato
            // 
            this.txtNombreZapato.Location = new System.Drawing.Point(193, 42);
            this.txtNombreZapato.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreZapato.Name = "txtNombreZapato";
            this.txtNombreZapato.Size = new System.Drawing.Size(293, 22);
            this.txtNombreZapato.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Registro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Zapato:";
            // 
            // tpActualizarInformacion
            // 
            this.tpActualizarInformacion.Controls.Add(this.btnBuscar);
            this.tpActualizarInformacion.Controls.Add(this.btnActualizarRegistro);
            this.tpActualizarInformacion.Controls.Add(this.txtBuscarInfo);
            this.tpActualizarInformacion.Controls.Add(this.label9);
            this.tpActualizarInformacion.Controls.Add(this.gbSecundarioActInfo);
            this.tpActualizarInformacion.Controls.Add(this.gbPrincipalActInfo);
            this.tpActualizarInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpActualizarInformacion.Location = new System.Drawing.Point(4, 25);
            this.tpActualizarInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.tpActualizarInformacion.Name = "tpActualizarInformacion";
            this.tpActualizarInformacion.Padding = new System.Windows.Forms.Padding(4);
            this.tpActualizarInformacion.Size = new System.Drawing.Size(914, 521);
            this.tpActualizarInformacion.TabIndex = 1;
            this.tpActualizarInformacion.Text = "Actualizar Informacion";
            this.tpActualizarInformacion.UseVisualStyleBackColor = true;
            // 
            // gbPrincipalActInfo
            // 
            this.gbPrincipalActInfo.Controls.Add(this.cmbCategoriaActInfo);
            this.gbPrincipalActInfo.Controls.Add(this.dtpFechaIngresoActInfo);
            this.gbPrincipalActInfo.Controls.Add(this.txtPrecioActInfo);
            this.gbPrincipalActInfo.Controls.Add(this.txtNombreZapatoActInfo);
            this.gbPrincipalActInfo.Controls.Add(this.label8);
            this.gbPrincipalActInfo.Controls.Add(this.label7);
            this.gbPrincipalActInfo.Controls.Add(this.label6);
            this.gbPrincipalActInfo.Controls.Add(this.label5);
            this.gbPrincipalActInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrincipalActInfo.Location = new System.Drawing.Point(21, 7);
            this.gbPrincipalActInfo.Name = "gbPrincipalActInfo";
            this.gbPrincipalActInfo.Size = new System.Drawing.Size(503, 260);
            this.gbPrincipalActInfo.TabIndex = 0;
            this.gbPrincipalActInfo.TabStop = false;
            this.gbPrincipalActInfo.Text = "Info. Zapatos";
            // 
            // gbSecundarioActInfo
            // 
            this.gbSecundarioActInfo.Controls.Add(this.dgvMostrarProducAlmacen);
            this.gbSecundarioActInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSecundarioActInfo.Location = new System.Drawing.Point(21, 273);
            this.gbSecundarioActInfo.Name = "gbSecundarioActInfo";
            this.gbSecundarioActInfo.Size = new System.Drawing.Size(881, 241);
            this.gbSecundarioActInfo.TabIndex = 1;
            this.gbSecundarioActInfo.TabStop = false;
            this.gbSecundarioActInfo.Text = "Productos Almacen";
            // 
            // dgvMostrarProducAlmacen
            // 
            this.dgvMostrarProducAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProducAlmacen.Location = new System.Drawing.Point(6, 21);
            this.dgvMostrarProducAlmacen.Name = "dgvMostrarProducAlmacen";
            this.dgvMostrarProducAlmacen.Size = new System.Drawing.Size(869, 214);
            this.dgvMostrarProducAlmacen.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre del Zapato :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Precio :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha de Registro :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Categoria :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Buscar";
            // 
            // txtNombreZapatoActInfo
            // 
            this.txtNombreZapatoActInfo.Location = new System.Drawing.Point(200, 29);
            this.txtNombreZapatoActInfo.Name = "txtNombreZapatoActInfo";
            this.txtNombreZapatoActInfo.Size = new System.Drawing.Size(283, 22);
            this.txtNombreZapatoActInfo.TabIndex = 4;
            // 
            // txtPrecioActInfo
            // 
            this.txtPrecioActInfo.Location = new System.Drawing.Point(200, 76);
            this.txtPrecioActInfo.Name = "txtPrecioActInfo";
            this.txtPrecioActInfo.Size = new System.Drawing.Size(283, 22);
            this.txtPrecioActInfo.TabIndex = 5;
            // 
            // dtpFechaIngresoActInfo
            // 
            this.dtpFechaIngresoActInfo.Location = new System.Drawing.Point(200, 138);
            this.dtpFechaIngresoActInfo.Name = "dtpFechaIngresoActInfo";
            this.dtpFechaIngresoActInfo.Size = new System.Drawing.Size(283, 22);
            this.dtpFechaIngresoActInfo.TabIndex = 6;
            // 
            // cmbCategoriaActInfo
            // 
            this.cmbCategoriaActInfo.FormattingEnabled = true;
            this.cmbCategoriaActInfo.Location = new System.Drawing.Point(200, 196);
            this.cmbCategoriaActInfo.Name = "cmbCategoriaActInfo";
            this.cmbCategoriaActInfo.Size = new System.Drawing.Size(283, 24);
            this.cmbCategoriaActInfo.TabIndex = 7;
            // 
            // txtBuscarInfo
            // 
            this.txtBuscarInfo.Location = new System.Drawing.Point(541, 36);
            this.txtBuscarInfo.Multiline = true;
            this.txtBuscarInfo.Name = "txtBuscarInfo";
            this.txtBuscarInfo.Size = new System.Drawing.Size(268, 38);
            this.txtBuscarInfo.TabIndex = 3;
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.Location = new System.Drawing.Point(541, 222);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(361, 45);
            this.btnActualizarRegistro.TabIndex = 4;
            this.btnActualizarRegistro.Text = "Actualizar Registro";
            this.btnActualizarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(827, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 38);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoZapatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.tabZapatos);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantenimientoZapatos";
            this.Text = "frmMantenimientoZapatos";
            this.Load += new System.EventHandler(this.frmMantenimientoZapatos_Load);
            this.tabZapatos.ResumeLayout(false);
            this.tpRegistrarZapato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbSecundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAlmacen)).EndInit();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.tpActualizarInformacion.ResumeLayout(false);
            this.tpActualizarInformacion.PerformLayout();
            this.gbPrincipalActInfo.ResumeLayout(false);
            this.gbPrincipalActInfo.PerformLayout();
            this.gbSecundarioActInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProducAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabZapatos;
        private System.Windows.Forms.TabPage tpRegistrarZapato;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.GroupBox gbSecundario;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.TabPage tpActualizarInformacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAñadirImg;
        private System.Windows.Forms.DataGridView dgvProductosAlmacen;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.TextBox txtPrecioZapato;
        private System.Windows.Forms.TextBox txtNombreZapato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbSecundarioActInfo;
        private System.Windows.Forms.DataGridView dgvMostrarProducAlmacen;
        private System.Windows.Forms.GroupBox gbPrincipalActInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.TextBox txtBuscarInfo;
        private System.Windows.Forms.ComboBox cmbCategoriaActInfo;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoActInfo;
        private System.Windows.Forms.TextBox txtPrecioActInfo;
        private System.Windows.Forms.TextBox txtNombreZapatoActInfo;
    }
}

