using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Cap4_WinForm_Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int X;

            if (!int.TryParse(textBox1.Text, out X))
            {
                MessageBox.Show("El número dado por el usuario es incorrecto.");
                MessageBox.Show("¿Digame otra Temperatura de la Caldera?");
                return;
            }

            if (X > 50 || X > 70)
            {
                label3.Text = ("HAY QUE REDUCIR LA TEMPERATURA");
            }
            else
            {
                label3.Text = ("LA TEMPERATURA SE ENCUENTRA EN EL RANGO DE LO NORMAL.");
            }
        }
    }
}
