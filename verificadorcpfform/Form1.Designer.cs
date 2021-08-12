
namespace verificadorcpfform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mskedTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtConfirmador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mskedTxtCpf
            // 
            this.mskedTxtCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskedTxtCpf.Location = new System.Drawing.Point(37, 75);
            this.mskedTxtCpf.Mask = "000,000,000-00";
            this.mskedTxtCpf.Name = "mskedTxtCpf";
            this.mskedTxtCpf.Size = new System.Drawing.Size(112, 25);
            this.mskedTxtCpf.TabIndex = 0;
            this.mskedTxtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(155, 75);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(90, 25);
            this.buttonVerificar.TabIndex = 1;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(37, 31);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(208, 32);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Verificador de CPF";
            // 
            // txtConfirmador
            // 
            this.txtConfirmador.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfirmador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmador.Enabled = false;
            this.txtConfirmador.Location = new System.Drawing.Point(37, 106);
            this.txtConfirmador.Name = "txtConfirmador";
            this.txtConfirmador.ReadOnly = true;
            this.txtConfirmador.Size = new System.Drawing.Size(208, 16);
            this.txtConfirmador.TabIndex = 3;
            this.txtConfirmador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 165);
            this.Controls.Add(this.txtConfirmador);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.mskedTxtCpf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Verificador de CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskedTxtCpf;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtConfirmador;
    }
}

