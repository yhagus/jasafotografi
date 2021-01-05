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
    public partial class karyawan_pemesanan : Form
    {
        #region INIT
        public karyawan_pemesanan()
        {
            InitializeComponent();
        }
        public string selectedId;
        MySqlConnection host = new MySqlConnection("server=localhost;database=jasafotografi;uid=root;pwd=;");
        public MySqlCommand cmd;
        private void karyawan_pemesanan_Load(object sender, EventArgs e)
        {
            showData();
            host.Open();
            // COMBOBOX PAKET
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM paket", host);
            DataSet DS = new DataSet();
            DA.Fill(DS, "paket");
            comboBox1.DisplayMember = "nama_paket";
            comboBox1.ValueMember = "id_paket";
            comboBox1.DataSource = DS.Tables["paket"];
            comboBox1.ResetText();

            // COMBOBOX KLIEN
            MySqlDataAdapter DA2 = new MySqlDataAdapter("SELECT * FROM klien", host);
            DataSet DS2 = new DataSet();
            DA2.Fill(DS2, "klien");
            comboBox2.DisplayMember = "nama_klien";
            comboBox2.ValueMember = "id_klien";
            comboBox2.DataSource = DS2.Tables["klien"];
            comboBox2.ResetText();

            // COMBOBOX KARYAWAN
            MySqlDataAdapter DA3 = new MySqlDataAdapter("SELECT * FROM karyawan", host);
            DataSet DS3 = new DataSet();
            DA3.Fill(DS3, "karyawan");
            comboBox3.DisplayMember = "nama_karyawan";
            comboBox3.ValueMember = "id_karyawan";
            comboBox3.DataSource = DS3.Tables["karyawan"];
            comboBox3.ResetText();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            string nmpaket, nmklien, nmkaryawan;
            selectedId = dataGridView1.Rows[row].Cells[0].Value.ToString();
            idbox.Text = selectedId;
            dateTimePicker1.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM paket WHERE id_paket='"+selectedId+"'", host);

        }
        #endregion

        #region CRUD
        public void refresh()
        {
            showData();
            idbox.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }
        public void showData()
        {
            MySqlDataAdapter DA_pemesanan = new MySqlDataAdapter("SELECT id_pemesanan,nama_paket,nama_klien,nama_karyawan,tanggal FROM pemesanan JOIN paket ON pemesanan.id_paket = paket.id_paket JOIN klien ON pemesanan.id_klien = klien.id_klien JOIN karyawan ON pemesanan.id_karyawan = karyawan.id_karyawan", host);
            DataSet DS_pemesanan = new DataSet();
            DA_pemesanan.Fill(DS_pemesanan);
            dataGridView1.DataSource = DS_pemesanan.Tables[0];
        }
        public void addData()
        {
            cmd = new MySqlCommand("INSERT INTO pemesanan (id_paket, id_klien, id_karyawan, tanggal) VALUES('" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + comboBox3.SelectedValue + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil ditambahkan!");
        }
        public void updateData()
        {
            cmd = new MySqlCommand("UPDATE pemesanan SET id_paket='" + comboBox1.SelectedValue + "',id_klien='" + comboBox2.SelectedValue + "',id_karyawan='" + comboBox3.SelectedValue + "',tanggal='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' WHERE id_pemesanan='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil diubah!");
        }
        public void deleteData()
        {
            cmd = new MySqlCommand("DELETE FROM pemesanan WHERE id_pemesanan='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil dihapus!");
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

        #region NAVBAR
        // KLIEN
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan kklien = new karyawan();
            kklien.Show();
        }
        // PAKET
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan_paket kpaket = new karyawan_paket();
            kpaket.Show();
        }
        // PEMBAYARAN
        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan_pembayaran pembayaran = new karyawan_pembayaran();
            pembayaran.Show();
        }
        //LOGOUT
        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginform = new login();
            loginform.Show();
        }
        #endregion
    }
}
