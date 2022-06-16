using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49_ExeCRUDWinForm_B
{
    public partial class Formkry : Form
    {
        public Formkry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-U8PCPKP7;Initial Catalog=Data_Mahasiwa;Persist Security Info=True;User ID=sa;Password=Samarinda2704 ");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nikkry = int.Parse(textBox1.Text);
            string namakry = textBox2.Text, telepon = textBox3.Text, jeniskelamin = "";
            if (radioButton1.Checked == true) { jeniskelamin = "Laki-Laki"; } else { jeniskelamin = "Perempuan"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec TambahKry '" + nikkry + "', '" + namakry + "', '" + jeniskelamin + "', '" + telepon + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil DiTambah");
            GetlihatKry();
        }

        void GetlihatKry()
        {
            SqlCommand c = new SqlCommand("exec LihatKry", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nikkry = int.Parse(textBox1.Text);
            string namakry = textBox2.Text, telepon = textBox3.Text, jeniskelamin = "";
            if (radioButton1.Checked == true) { jeniskelamin = "Laki-Laki"; } else { jeniskelamin = "Perempuan"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec EditKry '" + nikkry + "', '" + namakry + "', '" + jeniskelamin + "', '" + telepon + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil DiUpdate");
            GetlihatKry();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nikkry = textBox1.Text;
            con.Open();
            SqlCommand c = new SqlCommand("exec HapusKry '" + nikkry + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil DiHapus");
            GetlihatKry();
        }
    }
}
