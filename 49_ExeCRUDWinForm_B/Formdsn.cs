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
    public partial class Formdsn : Form
    {
        public Formdsn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-U8PCPKP7;Initial Catalog=Data_Mahasiwa;Persist Security Info=True;User ID=sa;Password=Samarinda2704 ");

        private void Form2_Load(object sender, EventArgs e)
        {
            GetlihatDsn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string niddsn = textBox1.Text;
            string namadsn = textBox2.Text, telepon = textBox2.Text, jeniskelamin = "";
            if (radioButton1.Checked == true) { jeniskelamin = "Laki-Laki"; } else { jeniskelamin = "Perempuan"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec TambahDsn '" + niddsn + "', '" + namadsn + "', '" + jeniskelamin + "', '" + telepon + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil Ditambahkan");
            GetlihatDsn();
        }

        void GetlihatDsn()
        {
            SqlCommand c = new SqlCommand("exec LihatDsn", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string niddsn = textBox1.Text;
            string namadsn = textBox2.Text, telepon = textBox2.Text, jeniskelamin = "";
            if (radioButton1.Checked == true) { jeniskelamin = "Laki-Laki"; } else { jeniskelamin = "Perempuan"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec EditDsn '" + niddsn + "', '" + namadsn + "', '" + jeniskelamin + "', '" + telepon + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil DiUpdate");
            GetlihatDsn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string niddsn = textBox1.Text;
            con.Open();
            SqlCommand c = new SqlCommand("exec HapusDsn '" + niddsn + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil DiHapus");
            GetlihatDsn();
        }
    }
}
