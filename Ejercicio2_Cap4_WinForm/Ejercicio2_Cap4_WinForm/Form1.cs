using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Ejercicio2_Cap4_WinForm
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

            while (!int.TryParse(textBox1.Text, out X))
            {
                MessageBox.Show("El número dado por el usuario ha sido Incorrecto.");
                MessageBox.Show("¿Digame otro número?");
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int baseNumero;
            if (!int.TryParse(textBox1.Text, out baseNumero))
            {
                MessageBox.Show("El número dado por el usuario es incorrecto.");
                return;
            }

            int exponente;
            if (!int.TryParse(textBox2.Text, out exponente))
            {
                MessageBox.Show("El exponente dado por el usuario es incorrecto.");
                return;
            }

            CalculadoraPotencia calculadora = new CalculadoraPotencia();
            double resultado = calculadora.CalcularPotencia(baseNumero, exponente);
            label2.Text = ($"El resultado de {baseNumero} elevado a la potencia {exponente} es: {resultado}");
        }

        public class CalculadoraPotencia
        {
            public double CalcularPotencia(int baseNumero, int exponente)
            {
                return Math.Pow(baseNumero, exponente);
            }
        }
    }
}
