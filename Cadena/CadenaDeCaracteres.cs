using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadena
{
    public partial class CadenaDeCaracteres : Form
    {
        //1-Hacer un programa que le pida al usuario una cadena y 
        //muestre cada una de las palabras de la cadena en una línea.

        public CadenaDeCaracteres()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IngresaCadena.Text))
            {
                MessageBox.Show("Primero Ingrese una Cadena");
                return;
            }

            char[] eliminarEspacio = { ' ' };
            
            string oracion = IngresaCadena.Text;
            string[] words = oracion.Split(eliminarEspacio);
            IngresaCadena.Clear();

            foreach (string x in words)
            {
                ListadoPalabras.Items.Add("" + x);
            }
        }
    }
}
