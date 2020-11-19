using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafischeRekenMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TextBox t = new TextBox();
            //decimal.TryParse(t.Text, out decimal a);
            decimal a = nrA.Value;
            decimal b = nrB.Value;

            decimal result = LongAdd(a, b);
            UpdateAnswer(result);
        }

        private void UpdateAnswer(object result)
        {
            lblAnswer.Text = result.ToString();
        }

        private decimal LongAdd(decimal a, decimal b)
        {
            Task.Delay(10000).Wait();
            return a + b;
        }
    }
}
