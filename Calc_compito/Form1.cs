using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_compito
{
    public partial class Calcolatrice : Form
    {
        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void lb_el2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single el1, el2;
            Single ris = 0;
            string op;

            el1 = Convert.ToSingle(nud_el1.Value);
            el2 = Convert.ToSingle(nud_el2.Value);

            op = cb_op.Text;


            if (op == "somma")
            {
                ris = el1 + el2;
            }
            else if (op == "differenza")
            {
                ris = el1 - el2;
            }
            else if (op == "moltiplicazione")
            {
                ris = el1 * el2;
            }
            else if (op == "divisione")
            {
                ris = el1 / el2;
            }
            else
            {
                lb__ris.Text = "Operatore non valido";


            }

            lb__ris.Text = ris.ToString();
        }
    }
}