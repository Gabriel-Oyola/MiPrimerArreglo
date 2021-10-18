
namespace MiPrimerArreglo
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
            this.btDias = new System.Windows.Forms.Button();
            this.lblDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDias
            // 
            this.btDias.Location = new System.Drawing.Point(12, 12);
            this.btDias.Name = "btDias";
            this.btDias.Size = new System.Drawing.Size(75, 23);
            this.btDias.TabIndex = 0;
            this.btDias.Text = "DIAS";
            this.btDias.UseVisualStyleBackColor = true;
            this.btDias.Click += new System.EventHandler(this.btDias_Click);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(32, 38);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(0, 16);
            this.lblDias.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.btDias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDias;
        private System.Windows.Forms.Label lblDias;
    }
}

