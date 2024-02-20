using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Cap4_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tablaMultiplicar = comboBox1.SelectedIndex + 1;
            if (tablaMultiplicar < 1 || tablaMultiplicar > 10)
            {
                MessageBox.Show("Número inválido. Por favor, seleccione un número del 1 al 10");
                return;
            }

            TablaMultiplicar tabla = new TablaMultiplicar(tablaMultiplicar);
            label3.Text = tabla.GenerarTabla();
        }
    }

    public class TablaMultiplicar
    {
        private int numero;

        public TablaMultiplicar(int numero)
        {
            this.numero = numero;
        }

        public string GenerarTabla()
        {
            string tabla = $"Tabla del {numero}:\n";
            for (int i = 1; i <= 10; i++)
            {
                tabla += $"{numero} x {i} = {numero * i}\n";
            }
            return tabla;
        }
    }
}

