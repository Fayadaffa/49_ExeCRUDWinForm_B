using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49_ExeCRUDWinForm_B
{
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formmhs f1 = new Formmhs();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formdsn f2 = new Formdsn();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formkry f3 = new Formkry();
            f3.Show();
            this.Hide();
        }
    }
}
