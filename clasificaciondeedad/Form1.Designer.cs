namespace clasificaciondeedad
{
    partial class Form1
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
            this.btncontinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(52, 61);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(75, 23);
            this.btncontinuar.TabIndex = 0;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.Btncontinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su edad.";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(45, 35);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(88, 20);
            this.txtedad.TabIndex = 2;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbltotal.Location = new System.Drawing.Point(77, 97);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(18, 17);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "--";
            this.lbltotal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 123);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncontinuar);
            this.Name = "Form1";
            this.Text = "Edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbltotal;
    }
}

