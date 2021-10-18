
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblDimension = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDimensionar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
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
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(214, 113);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(280, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(521, 110);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 3;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(602, 110);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 4;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(214, 48);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(130, 20);
            this.txtCant.TabIndex = 5;
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(211, 32);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(110, 13);
            this.lblDimension.TabIndex = 6;
            this.lblDimension.Text = "Cantidad de nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres:";
            // 
            // btDimensionar
            // 
            this.btDimensionar.Location = new System.Drawing.Point(350, 48);
            this.btDimensionar.Name = "btDimensionar";
            this.btDimensionar.Size = new System.Drawing.Size(75, 23);
            this.btDimensionar.TabIndex = 8;
            this.btDimensionar.Text = "Dimensionar";
            this.btDimensionar.UseVisualStyleBackColor = true;
            this.btDimensionar.Click += new System.EventHandler(this.btDimensionar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(211, 154);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(0, 18);
            this.lblLista.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btDimensionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDimension);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.txtNombres);
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
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDimensionar;
        private System.Windows.Forms.Label lblLista;
    }
}

