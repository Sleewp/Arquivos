using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class frmvendas : Form
    {
        public frmvendas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblimposto_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtimposto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcusto.Clear();
            txtimposto.Clear();
            txtdistribuidor.Clear();
            txtfinal.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double custo, imposto, total, lucro, soma;

            custo = Convert.ToDouble(txtcusto.Text);

            imposto = custo * 45 / 100;
            soma = custo + imposto;
            lucro = soma * 12 / 100;
            total = (custo + imposto) + lucro;

            txtcusto.Text = custo.ToString();
            txtimposto.Text = imposto.ToString();
         
            txtsoma.Text = soma.ToString();
            txtfinal.Text = total.ToString();

        }
    }
}
