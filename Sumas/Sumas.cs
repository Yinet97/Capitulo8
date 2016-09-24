using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumas
{
    public partial class Sumas : Form
    {
        //4 Hacer un programa que calcule sumas y muestre los resultados negativos entre paréntesis.
        public Sumas()
        {
            InitializeComponent();
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            float Suma = 0f;
            float num1 = Convert.ToSingle(IngresoNum1.Text);
            float num2 = Convert.ToSingle(IngresoNum2.Text);
            IngresoNum1.Clear();
            IngresoNum2.Clear();

            Suma = num1 + num2;

            if(Suma > 0)
                Resultado.Text = Convert.ToString("" + Suma);
            else
                Resultado.Text = Convert.ToString("(" + Suma +")");
        }
    }
}
