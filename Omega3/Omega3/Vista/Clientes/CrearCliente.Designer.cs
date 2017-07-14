namespace Omega3.Vista.Clientes
{
    partial class CrearCliente
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
            this.combo_documento = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.lbl_razon = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.combo_provincia = new System.Windows.Forms.ComboBox();
            this.combo_localidad = new System.Windows.Forms.ComboBox();
            this.facturacion = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_pago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_tipo_factura = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_condicion = new System.Windows.Forms.ComboBox();
            this.datos_generales = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cargar = new System.Windows.Forms.Button();
            this.txt_cod_postal = new System.Windows.Forms.TextBox();
            this.facturacion.SuspendLayout();
            this.datos_generales.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_documento
            // 
            this.combo_documento.FormattingEnabled = true;
            this.combo_documento.Location = new System.Drawing.Point(30, 83);
            this.combo_documento.Name = "combo_documento";
            this.combo_documento.Size = new System.Drawing.Size(116, 21);
            this.combo_documento.TabIndex = 0;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(28, 63);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(101, 13);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Tipo de Documento";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(174, 84);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(149, 20);
            this.txt_documento.TabIndex = 2;
            // 
            // lbl_razon
            // 
            this.lbl_razon.AutoSize = true;
            this.lbl_razon.Location = new System.Drawing.Point(429, 63);
            this.lbl_razon.Name = "lbl_razon";
            this.lbl_razon.Size = new System.Drawing.Size(70, 13);
            this.lbl_razon.TabIndex = 3;
            this.lbl_razon.Text = "Razon Social";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(432, 84);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(268, 20);
            this.txt_razon_social.TabIndex = 4;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(30, 127);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(82, 13);
            this.lbl_direccion.TabIndex = 5;
            this.lbl_direccion.Text = "Dirección Fiscal";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(30, 143);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(292, 20);
            this.txt_direccion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(432, 143);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(268, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Location = new System.Drawing.Point(31, 193);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(51, 13);
            this.lbl_provincia.TabIndex = 10;
            this.lbl_provincia.Text = "Provincia";
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.Location = new System.Drawing.Point(429, 193);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(53, 13);
            this.lbl_localidad.TabIndex = 11;
            this.lbl_localidad.Text = "Localidad";
            // 
            // combo_provincia
            // 
            this.combo_provincia.FormattingEnabled = true;
            this.combo_provincia.Location = new System.Drawing.Point(30, 209);
            this.combo_provincia.Name = "combo_provincia";
            this.combo_provincia.Size = new System.Drawing.Size(292, 21);
            this.combo_provincia.TabIndex = 12;
            // 
            // combo_localidad
            // 
            this.combo_localidad.FormattingEnabled = true;
            this.combo_localidad.Location = new System.Drawing.Point(432, 209);
            this.combo_localidad.Name = "combo_localidad";
            this.combo_localidad.Size = new System.Drawing.Size(268, 21);
            this.combo_localidad.TabIndex = 13;
            // 
            // facturacion
            // 
            this.facturacion.Controls.Add(this.label3);
            this.facturacion.Controls.Add(this.combo_pago);
            this.facturacion.Controls.Add(this.label2);
            this.facturacion.Controls.Add(this.combo_tipo_factura);
            this.facturacion.Controls.Add(this.label4);
            this.facturacion.Controls.Add(this.combo_condicion);
            this.facturacion.Location = new System.Drawing.Point(7, 313);
            this.facturacion.Name = "facturacion";
            this.facturacion.Size = new System.Drawing.Size(726, 111);
            this.facturacion.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Facturación";
            // 
            // combo_pago
            // 
            this.combo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pago.FormattingEnabled = true;
            this.combo_pago.Location = new System.Drawing.Point(434, 76);
            this.combo_pago.Name = "combo_pago";
            this.combo_pago.Size = new System.Drawing.Size(121, 21);
            this.combo_pago.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Configuración Impositiva";
            // 
            // combo_tipo_factura
            // 
            this.combo_tipo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_factura.FormattingEnabled = true;
            this.combo_tipo_factura.Location = new System.Drawing.Point(434, 46);
            this.combo_tipo_factura.Name = "combo_tipo_factura";
            this.combo_tipo_factura.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_factura.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tratamiento Impositivo";
            // 
            // combo_condicion
            // 
            this.combo_condicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_condicion.FormattingEnabled = true;
            this.combo_condicion.Location = new System.Drawing.Point(39, 76);
            this.combo_condicion.Name = "combo_condicion";
            this.combo_condicion.Size = new System.Drawing.Size(121, 21);
            this.combo_condicion.TabIndex = 2;
            this.combo_condicion.SelectedIndexChanged += new System.EventHandler(this.combo_condicion_SelectedIndexChanged);
            // 
            // datos_generales
            // 
            this.datos_generales.Controls.Add(this.txt_cod_postal);
            this.datos_generales.Controls.Add(this.cargar);
            this.datos_generales.Controls.Add(this.label5);
            this.datos_generales.Controls.Add(this.combo_documento);
            this.datos_generales.Controls.Add(this.lbl_tipo);
            this.datos_generales.Controls.Add(this.combo_localidad);
            this.datos_generales.Controls.Add(this.txt_documento);
            this.datos_generales.Controls.Add(this.combo_provincia);
            this.datos_generales.Controls.Add(this.lbl_razon);
            this.datos_generales.Controls.Add(this.lbl_localidad);
            this.datos_generales.Controls.Add(this.txt_razon_social);
            this.datos_generales.Controls.Add(this.lbl_provincia);
            this.datos_generales.Controls.Add(this.txt_direccion);
            this.datos_generales.Controls.Add(this.lbl_direccion);
            this.datos_generales.Controls.Add(this.txt_telefono);
            this.datos_generales.Controls.Add(this.label1);
            this.datos_generales.Location = new System.Drawing.Point(15, 12);
            this.datos_generales.Name = "datos_generales";
            this.datos_generales.Size = new System.Drawing.Size(718, 295);
            this.datos_generales.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Datos Generales";
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(320, 83);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(29, 22);
            this.cargar.TabIndex = 15;
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // txt_cod_postal
            // 
            this.txt_cod_postal.Location = new System.Drawing.Point(432, 248);
            this.txt_cod_postal.Name = "txt_cod_postal";
            this.txt_cod_postal.Size = new System.Drawing.Size(268, 20);
            this.txt_cod_postal.TabIndex = 16;
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 483);
            this.Controls.Add(this.datos_generales);
            this.Controls.Add(this.facturacion);
            this.Controls.Add(this.button1);
            this.Name = "CrearCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CrearCliente_Load);
            this.facturacion.ResumeLayout(false);
            this.facturacion.PerformLayout();
            this.datos_generales.ResumeLayout(false);
            this.datos_generales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_documento;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Label lbl_razon;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.ComboBox combo_provincia;
        private System.Windows.Forms.ComboBox combo_localidad;
        private System.Windows.Forms.Panel facturacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_pago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_tipo_factura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_condicion;
        private System.Windows.Forms.Panel datos_generales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.TextBox txt_cod_postal;
    }
}