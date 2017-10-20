﻿namespace Omega3.Vista.Clientes
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
            this.lbl_razon = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.combo_provincia = new System.Windows.Forms.ComboBox();
            this.facturacion = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_condicion = new System.Windows.Forms.ComboBox();
            this.datos_generales = new System.Windows.Forms.Panel();
            this.combo_lista = new System.Windows.Forms.ComboBox();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.txt_cuit = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cod_postal = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail_contacto = new System.Windows.Forms.TextBox();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.txt_cod_postal = new System.Windows.Forms.TextBox();
            this.cargar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.facturacion.SuspendLayout();
            this.datos_generales.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_documento
            // 
            this.combo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_documento.FormattingEnabled = true;
            this.combo_documento.Location = new System.Drawing.Point(34, 83);
            this.combo_documento.Name = "combo_documento";
            this.combo_documento.Size = new System.Drawing.Size(116, 26);
            this.combo_documento.TabIndex = 0;
            this.combo_documento.SelectedIndexChanged += new System.EventHandler(this.combo_documento_SelectedIndexChanged);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(30, 62);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(156, 18);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Tipo de Documento";
            // 
            // lbl_razon
            // 
            this.lbl_razon.AutoSize = true;
            this.lbl_razon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razon.Location = new System.Drawing.Point(429, 62);
            this.lbl_razon.Name = "lbl_razon";
            this.lbl_razon.Size = new System.Drawing.Size(109, 18);
            this.lbl_razon.TabIndex = 3;
            this.lbl_razon.Text = "Razon Social";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon_social.Location = new System.Drawing.Point(432, 85);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(268, 24);
            this.txt_razon_social.TabIndex = 4;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(31, 112);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(130, 18);
            this.lbl_direccion.TabIndex = 5;
            this.lbl_direccion.Text = "Dirección Fiscal";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(33, 133);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(292, 24);
            this.txt_direccion.TabIndex = 5;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(429, 112);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(74, 18);
            this.lbl_telefono.TabIndex = 7;
            this.lbl_telefono.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(432, 133);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(268, 24);
            this.txt_telefono.TabIndex = 6;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provincia.Location = new System.Drawing.Point(31, 160);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(78, 18);
            this.lbl_provincia.TabIndex = 10;
            this.lbl_provincia.Text = "Provincia";
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_localidad.Location = new System.Drawing.Point(429, 210);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(80, 18);
            this.lbl_localidad.TabIndex = 11;
            this.lbl_localidad.Text = "Localidad";
            // 
            // combo_provincia
            // 
            this.combo_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_provincia.FormattingEnabled = true;
            this.combo_provincia.Location = new System.Drawing.Point(33, 181);
            this.combo_provincia.Name = "combo_provincia";
            this.combo_provincia.Size = new System.Drawing.Size(292, 26);
            this.combo_provincia.TabIndex = 7;
            // 
            // facturacion
            // 
            this.facturacion.Controls.Add(this.label2);
            this.facturacion.Controls.Add(this.label4);
            this.facturacion.Controls.Add(this.combo_condicion);
            this.facturacion.Location = new System.Drawing.Point(7, 423);
            this.facturacion.Name = "facturacion";
            this.facturacion.Size = new System.Drawing.Size(737, 111);
            this.facturacion.TabIndex = 14;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tratamiento Impositivo";
            // 
            // combo_condicion
            // 
            this.combo_condicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_condicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_condicion.FormattingEnabled = true;
            this.combo_condicion.Location = new System.Drawing.Point(39, 76);
            this.combo_condicion.Name = "combo_condicion";
            this.combo_condicion.Size = new System.Drawing.Size(292, 26);
            this.combo_condicion.TabIndex = 0;
            // 
            // datos_generales
            // 
            this.datos_generales.Controls.Add(this.combo_lista);
            this.datos_generales.Controls.Add(this.lbl_lista);
            this.datos_generales.Controls.Add(this.txt_documento);
            this.datos_generales.Controls.Add(this.txt_cuit);
            this.datos_generales.Controls.Add(this.lbl_cod_postal);
            this.datos_generales.Controls.Add(this.lbl_mail);
            this.datos_generales.Controls.Add(this.txt_mail_contacto);
            this.datos_generales.Controls.Add(this.txt_contacto);
            this.datos_generales.Controls.Add(this.lbl_contacto);
            this.datos_generales.Controls.Add(this.txt_localidad);
            this.datos_generales.Controls.Add(this.txt_cod_postal);
            this.datos_generales.Controls.Add(this.cargar);
            this.datos_generales.Controls.Add(this.label5);
            this.datos_generales.Controls.Add(this.combo_documento);
            this.datos_generales.Controls.Add(this.lbl_tipo);
            this.datos_generales.Controls.Add(this.combo_provincia);
            this.datos_generales.Controls.Add(this.lbl_razon);
            this.datos_generales.Controls.Add(this.lbl_localidad);
            this.datos_generales.Controls.Add(this.txt_razon_social);
            this.datos_generales.Controls.Add(this.lbl_provincia);
            this.datos_generales.Controls.Add(this.txt_direccion);
            this.datos_generales.Controls.Add(this.lbl_direccion);
            this.datos_generales.Controls.Add(this.txt_telefono);
            this.datos_generales.Controls.Add(this.lbl_telefono);
            this.datos_generales.Location = new System.Drawing.Point(7, 12);
            this.datos_generales.Name = "datos_generales";
            this.datos_generales.Size = new System.Drawing.Size(737, 405);
            this.datos_generales.TabIndex = 2;
            // 
            // combo_lista
            // 
            this.combo_lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_lista.FormattingEnabled = true;
            this.combo_lista.Location = new System.Drawing.Point(432, 279);
            this.combo_lista.Name = "combo_lista";
            this.combo_lista.Size = new System.Drawing.Size(268, 26);
            this.combo_lista.TabIndex = 24;
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.Location = new System.Drawing.Point(429, 258);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(44, 18);
            this.lbl_lista.TabIndex = 23;
            this.lbl_lista.Text = "Lista";
            // 
            // txt_documento
            // 
            this.txt_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_documento.Location = new System.Drawing.Point(156, 83);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(101, 24);
            this.txt_documento.TabIndex = 1;
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_documento_KeyPress);
            // 
            // txt_cuit
            // 
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit.Location = new System.Drawing.Point(156, 83);
            this.txt_cuit.Mask = "99-99999999-9";
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(101, 24);
            this.txt_cuit.TabIndex = 2;
            this.txt_cuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_cod_postal
            // 
            this.lbl_cod_postal.AutoSize = true;
            this.lbl_cod_postal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_postal.Location = new System.Drawing.Point(429, 160);
            this.lbl_cod_postal.Name = "lbl_cod_postal";
            this.lbl_cod_postal.Size = new System.Drawing.Size(115, 18);
            this.lbl_cod_postal.TabIndex = 22;
            this.lbl_cod_postal.Text = "Codigo Postal";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(31, 258);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(113, 18);
            this.lbl_mail.TabIndex = 21;
            this.lbl_mail.Text = "Mail Contacto";
            // 
            // txt_mail_contacto
            // 
            this.txt_mail_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail_contacto.Location = new System.Drawing.Point(33, 279);
            this.txt_mail_contacto.MaxLength = 100;
            this.txt_mail_contacto.Name = "txt_mail_contacto";
            this.txt_mail_contacto.Size = new System.Drawing.Size(292, 24);
            this.txt_mail_contacto.TabIndex = 11;
            // 
            // txt_contacto
            // 
            this.txt_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contacto.Location = new System.Drawing.Point(34, 231);
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(292, 24);
            this.txt_contacto.TabIndex = 9;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contacto.Location = new System.Drawing.Point(31, 210);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(77, 18);
            this.lbl_contacto.TabIndex = 18;
            this.lbl_contacto.Text = "Contacto";
            // 
            // txt_localidad
            // 
            this.txt_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_localidad.Location = new System.Drawing.Point(432, 231);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(268, 24);
            this.txt_localidad.TabIndex = 10;
            // 
            // txt_cod_postal
            // 
            this.txt_cod_postal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_postal.Location = new System.Drawing.Point(432, 183);
            this.txt_cod_postal.Name = "txt_cod_postal";
            this.txt_cod_postal.Size = new System.Drawing.Size(268, 24);
            this.txt_cod_postal.TabIndex = 8;
            this.txt_cod_postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cod_postal_KeyPress);
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(263, 85);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(29, 22);
            this.cargar.TabIndex = 3;
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
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
            // btn_crear
            // 
            this.btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.Location = new System.Drawing.Point(335, 540);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(81, 27);
            this.btn_crear.TabIndex = 2;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 600);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.datos_generales);
            this.Controls.Add(this.facturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "CrearCliente";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.CrearCliente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CrearCliente_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CrearCliente_KeyDown);
            this.facturacion.ResumeLayout(false);
            this.facturacion.PerformLayout();
            this.datos_generales.ResumeLayout(false);
            this.datos_generales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_documento;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_razon;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.ComboBox combo_provincia;
        private System.Windows.Forms.Panel facturacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_condicion;
        private System.Windows.Forms.Panel datos_generales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.TextBox txt_cod_postal;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label lbl_cod_postal;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_mail_contacto;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.MaskedTextBox txt_cuit;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.ComboBox combo_lista;
    }
}