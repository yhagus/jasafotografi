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
    public partial class karyawan : Form
    {
        #region INIT
        public karyawan()
        {
            InitializeComponent();
        }
        public string selectedId;
        MySqlConnection host = new MySqlConnection("server=localhost;database=jasafotografi;uid=root;pwd=;");
        public MySqlCommand cmd;

        private void karyawan_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            selectedId = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textboxName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            textboxEmail.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            string jk = dataGridView1.Rows[row].Cells[3].Value.ToString();
            if (jk == "L")
            {
                radioButtonL.Checked = true;
            }
            else if (jk == "P")
            {
                radioButtonP.Checked = true;
            }
        }
        #endregion

        #region BUTTONS
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

        #region CRUD
        public void showData()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM klien", host);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        public void addData()
        {
            string jk = "";

            if (radioButtonL.Checked)
            {
                jk = radioButtonL.Text;
            }
            else if (radioButtonP.Checked)
            {
                jk = radioButtonP.Text;
            }

            host.Open();
            cmd = new MySqlCommand("INSERT INTO klien (nama_klien,email,jk) VALUES ('" + textboxName.Text + "','" + textboxEmail.Text + "','" + jk + "')", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil ditambahkan!");
        }
        public void updateData()
        {
            string jk = "";

            if (radioButtonL.Checked)
            {
                jk = radioButtonL.Text;
            }
            else if (radioButtonP.Checked)
            {
                jk = radioButtonP.Text;
            }

            host.Open();
            cmd = new MySqlCommand("UPDATE klien SET nama_klien='" + textboxName.Text + "',email='" + textboxEmail.Text + "',jk='" + jk + "' WHERE id_klien='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil diubah!");
        }
        public void deleteData()
        {
            host.Open();
            cmd = new MySqlCommand("DELETE FROM klien WHERE id_klien='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil dihapus!");
        }
        public void refresh()
        {
            host.Close();
            showData();
            textboxName.Clear();
            textboxEmail.Clear();
        }
        #endregion

        #region NAVBAR
        // PAKET
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan_paket kpaket = new karyawan_paket();
            kpaket.Show();
        }

        // PEMESANAN
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan_pemesanan pemesanan = new karyawan_pemesanan();
            pemesanan.Show();
        }
        // PEMBAYARAN
        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan_pembayaran pembayaran = new karyawan_pembayaran();
            pembayaran.Show();
        }
        // LOGOUT
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginform = new login();
            loginform.Show();
        }

        #endregion

        
    }
}
