namespace ventana_tabla
{
    partial class frmTabla
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
            this.lblTabla = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstTablita = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(51, 54);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(107, 13);
            this.lblTabla.TabIndex = 0;
            this.lblTabla.Text = "¿Que tablita deseas?";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(213, 54);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(100, 20);
            this.txtTabla.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(127, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstTablita
            // 
            this.lstTablita.FormattingEnabled = true;
            this.lstTablita.Location = new System.Drawing.Point(127, 181);
            this.lstTablita.Name = "lstTablita";
            this.lstTablita.Size = new System.Drawing.Size(128, 186);
            this.lstTablita.TabIndex = 3;
            // 
            // frmTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(437, 378);
            this.Controls.Add(this.lstTablita);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.lblTabla);
            this.Name = "frmTabla";
            this.Text = "Tablas de Multiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstTablita;
    }
}

