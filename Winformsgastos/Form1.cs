using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformsgastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double energia = double.Parse(tbEnergia.Text);
            double agua = double.Parse(tbAgua.Text);
            double tv = double.Parse(tbTv.Text);
            double alimentos = double.Parse(tbComida.Text);
            double outros = double.Parse(tbOutros.Text);

            double renda = double.Parse(tbRenda.Text);

             double gastos = energia + agua + tv + alimentos +outros ;
            double saldo = renda - gastos;

            lblTotal.Text = gastos.ToString("C");
            lblSaldo.Text = saldo.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEnergia.Clear();
            tbAgua.Clear();
            tbTv.Clear();
            tbComida.Clear();
            tbOutros.Clear();
            tbRenda.Clear();
            lblSaldo.Text = "R$ 0,00";
            lblTotal.Text = "R$ 0,00";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
