using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace jasafotografi
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        #region INITIALIZATION
        public string selectedId;
        MySqlConnection host = new MySqlConnection("server=localhost;database=jasafotografi;uid=root;pwd=;");
        public MySqlCommand cmd;
        private void admin_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            selectedId = dataGridView1.Rows[row].Cells[0].Value.ToString();
            IDBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            string jk = dataGridView1.Rows[row].Cells[3].Value.ToString();
            if (jk == "L")
            {
                radioButton1.Checked = true;
            }
            else if (jk == "P")
            {
                radioButton2.Checked = true;
            }
            textBox3.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
        }
        
        #endregion

        #region CRUD Functions
        public void showData()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM karyawan", host);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        public void addData()
        {
            string jk = "";

            if (radioButton1.Checked)
            {
                jk = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                jk = radioButton2.Text;
            }
            host.Open();
            cmd = new MySqlCommand("INSERT INTO karyawan (nama_karyawan,status,jk,alamat,email,gaji) VALUES ('" + IDBox.Text + "','" + textBox1.Text + "','" + jk + "','" + textBox3.Text + "','" + textBox4.Text + "','" + numericUpDown1.Value + "')", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil ditambahkan!");
        }
        public void updateData()
        {
            string jk = "";

            if (radioButton1.Checked)
            {
                jk = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                jk = radioButton2.Text;
            }
            host.Open();
            cmd = new MySqlCommand("UPDATE karyawan SET nama_karyawan='" + IDBox.Text + "',status='" + textBox1.Text + "',jk='" + jk + "',alamat='" + textBox3.Text + "',email='" + textBox4.Text + "',gaji='" + numericUpDown1.Value + "' WHERE id_karyawan='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil diubah!");
        }
        public void deleteData()
        {
            host.Open();
            cmd = new MySqlCommand("DELETE FROM karyawan WHERE id_karyawan='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil dihapus!");
        }
        public void refresh()
        {
            host.Close();
            showData();
            IDBox.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            numericUpDown1.ResetText();
        }

        #endregion

        /*
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        */
        #region USELESS LABELS
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //LOGOUT
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginform = new login();
            loginform.Show();
        }
        //KLIEN
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_klien klien = new admin_klien();
            klien.Show();
        }
        //PAKET
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_paket paket = new admin_paket();
            paket.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region BUTTON FUNCTION
        private void Loginbutt_Click(object sender, EventArgs e)
        {
            addData();
            refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            deleteData();
            refresh();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            updateData();
            refresh();
        }



        #endregion

        
    }
}
