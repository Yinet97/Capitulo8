using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo8
{
    public partial class Fecha : Form
    {
        DateTime Tiempo = DateTime.Now;
        public Fecha()
        {
            InitializeComponent();
        }

        private void VerResultado_Click(object sender, EventArgs e)
        {
            ImprimoHora.Text = Tiempo.ToString("h : mm tt");
            ImprimoFecha.Text = Tiempo.ToString("dd / MMM / yyyy");
        }
    }
}
