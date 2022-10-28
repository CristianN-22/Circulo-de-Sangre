namespace E_Commerce_Cobro_Interfaz
{
    partial class Factura
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
            this.textMostrar = new System.Windows.Forms.TextBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.Cobro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMostrar
            // 
            this.textMostrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textMostrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMostrar.Location = new System.Drawing.Point(23, 47);
            this.textMostrar.Multiline = true;
            this.textMostrar.Name = "textMostrar";
            this.textMostrar.Size = new System.Drawing.Size(352, 362);
            this.textMostrar.TabIndex = 0;
            this.textMostrar.TextChanged += new System.EventHandler(this.textMostrar_TextChanged);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFinalizar.Location = new System.Drawing.Point(300, 415);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 1;
            this.buttonFinalizar.Text = "Aceptar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // Cobro
            // 
            this.Cobro.AutoSize = true;
            this.Cobro.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cobro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Cobro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cobro.Location = new System.Drawing.Point(45, 3);
            this.Cobro.Name = "Cobro";
            this.Cobro.Size = new System.Drawing.Size(299, 33);
            this.Cobro.TabIndex = 6;
            this.Cobro.Text = "Datos de Facturación";
            this.Cobro.Click += new System.EventHandler(this.Cobro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Cobro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 41);
            this.panel1.TabIndex = 7;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.textMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textMostrar;
        private Button buttonFinalizar;
        private Label Cobro;
        private Panel panel1;
    }
}