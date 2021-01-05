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
    public partial class karyawan_paket : Form
    {
        #region INITIALIZATION
        public karyawan_paket()
        {
            InitializeComponent();
        }
        public string selectedId;
        MySqlConnection host = new MySqlConnection("server=localhost;database=jasafotografi;uid=root;pwd=;");
        public MySqlCommand cmd;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            selectedId = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textboxNama.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            timeDurasi.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            numericUpDown2.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            numericUpDown3.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
        }
        private void karyawan_paket_Load(object sender, EventArgs e)
        {
            showData();

            timeDurasi.Value = DateTime.Now.Date;
            numericUpDown1.Maximum = 100000000;     //harga
            numericUpDown2.Maximum = 512; //roll
            numericUpDown3.Maximum = 24; //crew
        }
        #endregion

        #region CRUD
        public void showData()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM paket", host);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        public void addData()
        {
            host.Open();
            cmd = new MySqlCommand("INSERT INTO paket (nama_paket,durasi,harga,roll,crew) VALUES ('" + textboxNama.Text + "','" + timeDurasi.Text + "','" + numericUpDown1.Value + "','" + numericUpDown2.Value + "','" + numericUpDown3.Value + "')", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil ditambahkan!");
        }
        public void updateData()
        {
            host.Open();
            cmd = new MySqlCommand("UPDATE paket SET nama_paket='" + textboxNama.Text + "',durasi='" + timeDurasi.Text + "',harga='" + numericUpDown1.Value + "',roll='" + numericUpDown2.Value + "',crew='" + numericUpDown3.Value + "' WHERE id_paket='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil diubah!");
        }
        public void deleteData()
        {
            host.Open();
            cmd = new MySqlCommand("DELETE FROM paket WHERE id_paket='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil dihapus!");
        }
        public void refresh()
        {
            host.Close();
            showData();
            textboxNama.Clear();
            timeDurasi.Value = DateTime.Now.Date;
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
            numericUpDown3.ResetText();
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

        private void button3_Click(object sender, EventArgs e)
        {
            updateData();
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteData();
            refresh();
        }

        #endregion

        #region NAVBAR
        // KLIEN
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan kklien = new karyawan();
            kklien.Show();
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
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginform = new login();
            loginform.Show();
        }
        #endregion
    }
}
