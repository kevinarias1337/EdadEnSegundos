using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasificaciondeedad
{
    public partial class Form1 : Form
    {
        Clasificacion clasificacion = new Clasificacion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btncontinuar_Click(object sender, EventArgs e)
        {
            clasificacion.setEdad(double.Parse(txtedad.Text));

            double lbltotal2 = clasificacion.getEdad();

            if (lbltotal2 >= 0 && lbltotal2 <=10)
            {
                MessageBox.Show("¡Niño!");
            }
            if (lbltotal2>=11 && lbltotal2<=14)
            {
                MessageBox.Show("¡Pre-Adolescente!");
            }
            if (lbltotal2>=15 && lbltotal2<=18)
            {
                MessageBox.Show("¡Adolescente!");
            }
            if (lbltotal2>=19 && lbltotal2<=25)
            {
                MessageBox.Show("¡Jóven!");
            }
            if (lbltotal2>=26 && lbltotal2<=65)
            {
                MessageBox.Show("¡Adulto!");
            }
            if (lbltotal2>=66)
            {
                MessageBox.Show("¡Anciano!");
            }
        }
    }
}
