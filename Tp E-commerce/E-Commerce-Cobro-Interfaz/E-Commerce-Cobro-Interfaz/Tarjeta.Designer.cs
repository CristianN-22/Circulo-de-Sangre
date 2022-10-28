namespace E_Commerce_Cobro_Interfaz
{
    partial class Tarjeta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cobro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNroTarjeta = new System.Windows.Forms.TextBox();
            this.textNombreApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCodigoSegurirdad = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.comboCuotas = new System.Windows.Forms.ComboBox();
            this.buttonPagarFin = new System.Windows.Forms.Button();
            this.dateTimeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.comboFormaPago = new System.Windows.Forms.ComboBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Cobro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 70);
            this.panel1.TabIndex = 6;
            // 
            // Cobro
            // 
            this.Cobro.AutoSize = true;
            this.Cobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cobro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cobro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cobro.Location = new System.Drawing.Point(30, 21);
            this.Cobro.Name = "Cobro";
            this.Cobro.Size = new System.Drawing.Size(299, 31);
            this.Cobro.TabIndex = 5;
            this.Cobro.Text = "Ingrese datos de tarjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(45, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNroTarjeta
            // 
            this.textNroTarjeta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textNroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNroTarjeta.ForeColor = System.Drawing.Color.Black;
            this.textNroTarjeta.Location = new System.Drawing.Point(35, 161);
            this.textNroTarjeta.Name = "textNroTarjeta";
            this.textNroTarjeta.PlaceholderText = "Número de Tarjeta";
            this.textNroTarjeta.Size = new System.Drawing.Size(331, 31);
            this.textNroTarjeta.TabIndex = 10;
            this.textNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNroTarjeta_KeyPress);
            // 
            // textNombreApellido
            // 
            this.textNombreApellido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombreApellido.ForeColor = System.Drawing.Color.Black;
            this.textNombreApellido.Location = new System.Drawing.Point(35, 215);
            this.textNombreApellido.Name = "textNombreApellido";
            this.textNombreApellido.PlaceholderText = "Nombre y apellido";
            this.textNombreApellido.Size = new System.Drawing.Size(331, 31);
            this.textNombreApellido.TabIndex = 11;
            this.textNombreApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(31, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha de vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(231, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Código de seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(31, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cuotas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(231, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DNI";
            // 
            // textCodigoSegurirdad
            // 
            this.textCodigoSegurirdad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textCodigoSegurirdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCodigoSegurirdad.ForeColor = System.Drawing.Color.Black;
            this.textCodigoSegurirdad.Location = new System.Drawing.Point(231, 274);
            this.textCodigoSegurirdad.Name = "textCodigoSegurirdad";
            this.textCodigoSegurirdad.PlaceholderText = "CVV";
            this.textCodigoSegurirdad.Size = new System.Drawing.Size(135, 21);
            this.textCodigoSegurirdad.TabIndex = 16;
            this.textCodigoSegurirdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigoSegurirdad_KeyPress);
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDNI.ForeColor = System.Drawing.Color.Black;
            this.textDNI.Location = new System.Drawing.Point(231, 319);
            this.textDNI.Name = "textDNI";
            this.textDNI.PlaceholderText = "Número";
            this.textDNI.Size = new System.Drawing.Size(135, 21);
            this.textDNI.TabIndex = 17;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDNI_KeyPress);
            // 
            // comboCuotas
            // 
            this.comboCuotas.FormattingEnabled = true;
            this.comboCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6 ",
            "12"});
            this.comboCuotas.Location = new System.Drawing.Point(34, 318);
            this.comboCuotas.Name = "comboCuotas";
            this.comboCuotas.Size = new System.Drawing.Size(167, 23);
            this.comboCuotas.TabIndex = 21;
            this.comboCuotas.Text = "Seleccione cantidad de cuotas";
            // 
            // buttonPagarFin
            // 
            this.buttonPagarFin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPagarFin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPagarFin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPagarFin.Location = new System.Drawing.Point(285, 362);
            this.buttonPagarFin.Name = "buttonPagarFin";
            this.buttonPagarFin.Size = new System.Drawing.Size(81, 35);
            this.buttonPagarFin.TabIndex = 22;
            this.buttonPagarFin.Text = "Pagar";
            this.buttonPagarFin.UseVisualStyleBackColor = false;
            this.buttonPagarFin.Click += new System.EventHandler(this.buttonPagarFin_Click);
            // 
            // dateTimeVencimiento
            // 
            this.dateTimeVencimiento.CustomFormat = "";
            this.dateTimeVencimiento.Location = new System.Drawing.Point(35, 272);
            this.dateTimeVencimiento.Name = "dateTimeVencimiento";
            this.dateTimeVencimiento.Size = new System.Drawing.Size(166, 23);
            this.dateTimeVencimiento.TabIndex = 24;
            this.dateTimeVencimiento.Value = new System.DateTime(2022, 10, 27, 0, 0, 0, 0);
            this.dateTimeVencimiento.ValueChanged += new System.EventHandler(this.dateTimeVencimiento_ValueChanged);
            // 
            // comboFormaPago
            // 
            this.comboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFormaPago.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboFormaPago.FormattingEnabled = true;
            this.comboFormaPago.Items.AddRange(new object[] {
            "Tarjeta de credito",
            "Tarjeta de debito"});
            this.comboFormaPago.Location = new System.Drawing.Point(34, 114);
            this.comboFormaPago.Name = "comboFormaPago";
            this.comboFormaPago.Size = new System.Drawing.Size(332, 33);
            this.comboFormaPago.TabIndex = 25;
            this.comboFormaPago.Text = "Seleccionar forma de pago";
            this.comboFormaPago.SelectedIndexChanged += new System.EventHandler(this.comboFormaPago_SelectedIndexChanged);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonVolver.Location = new System.Drawing.Point(34, 363);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(167, 34);
            this.buttonVolver.TabIndex = 26;
            this.buttonVolver.Text = "Volver al carrito";
            this.buttonVolver.UseMnemonic = false;
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Tarjeta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(404, 411);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.comboFormaPago);
            this.Controls.Add(this.dateTimeVencimiento);
            this.Controls.Add(this.buttonPagarFin);
            this.Controls.Add(this.comboCuotas);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textCodigoSegurirdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombreApellido);
            this.Controls.Add(this.textNroTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjeta";
            this.Load += new System.EventHandler(this.Tarjeta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Cobro;
        private Label label1;
        private TextBox textNroTarjeta;
        private TextBox textNombreApellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textCodigoSegurirdad;
        private TextBox textDNI;
        private ComboBox comboCuotas;
        private Button buttonPagarFin;
        private DateTimePicker dateTimeVencimiento;
        private ComboBox comboFormaPago;
        private Button buttonVolver;
    }
}