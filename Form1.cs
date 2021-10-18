using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerArreglo
{
    public partial class Form1 : Form
    {
        string[] Nombre;
        int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btDias_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miercoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sabado";
            Dias[6] = "Domingo";

            foreach (string item in Dias)
            {
                lblDias.Text = lblDias.Text + item + "\r\n";
            }


        }

        private void btDimensionar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCant.Text);
            Nombre = new string[cant];

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Nombre[pos] = txtNombres.Text;
            pos = pos + 1;
            txtNombres.Focus();
            txtNombres.SelectAll();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lblLista.Text = "";
            foreach (string item in Nombre)
            {
                lblLista.Text = lblLista.Text + item + "\r\n";
            }
        }

       
    }
}
