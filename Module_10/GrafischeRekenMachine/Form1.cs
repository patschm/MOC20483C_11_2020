using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            //TextBox t = new TextBox();
            //decimal.TryParse(t.Text, out decimal a);
            decimal a = nrA.Value;
            decimal b = nrB.Value;

            decimal res = await LongAddAsync(a, b); //.ConfigureAwait(false);
            UpdateAnswer(res);

            //decimal result = LongAdd(a, b);
            //UpdateAnswer(result);


            //SynchronizationContext ctx = SynchronizationContext.Current;
            //Task<decimal> t = Task.Run(() =>
            //{
            //    decimal res = LongAdd(a, b);
            //    return res;
            //});
            //t.ContinueWith(pt =>
            //{
            //    decimal res = pt.Result;
            //    ctx.Post(UpdateAnswer, res);
            //});



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
        private Task<decimal> LongAddAsync(decimal a, decimal b)
        {
            return Task.Run(() => LongAdd(a, b));
        }
    }
}
