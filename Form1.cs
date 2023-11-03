using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cộng_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tb_a.Text);
            double b = double.Parse(tb_b.Text);
            double kq = a + b;
            tb_KQ.Text = kq.ToString();
        }
    }
}
