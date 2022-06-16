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
    public partial class Formmhs : Form
    {
        public Formmhs()
        { 
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-U8PCPKP7;Initial Catalog=Data_Mahasiwa;Persist Security Info=True;User ID=sa;Password=Samarinda2704 ");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nimmhs = int.Parse(textBox1.Text);
            string namamhs = textBox2.Text, angkatan = comboBox1.Text, telepon=textBox5.Text, jeniskelamin= "";
            if (radioButton1.Checked == true) { jeniskelamin = "Laki-Laki"; } else { jeniskelamin = "Perempuan"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec TambahMhs '"+ nimmhs + "', '" + namamhs + "', '" + angkatan + "', '" + jeniskelamin + "', '" + telepon + "'",con);
            c.ExecuteNonQuery();           
            MessageBox.Show("Berhasil Ditambahkan");
            GetlihatMhs();
        }

        void GetlihatMhs()
        {
            SqlCommand c = new SqlCommand("exec LihatMhs", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetlihatMhs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update
            int nimmhs = int.Parse(textBox1.Text);
            string namamhs = textBox2.Text, angkatan = comboBox1.Text, telepon = textBox5.Text, jeniskelamin = "";
            if (radioButton1.Checked == true) { jeniskelamin = "Laki-Laki"; } else { jeniskelamin = "Perempuan"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec EditMhs '" + nimmhs + "', '" + namamhs + "', '" + angkatan + "', '" + jeniskelamin + "', '" + telepon + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil DiUpdate");
            GetlihatMhs();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete
            int nimmhs = int.Parse(textBox1.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec HapusMhs '" + nimmhs + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Berhasil DiHapus");
            GetlihatMhs();
        }
    }
}
