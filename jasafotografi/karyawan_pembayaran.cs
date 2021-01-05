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
    public partial class karyawan_pembayaran : Form
    {
        public karyawan_pembayaran()
        {
            InitializeComponent();
        }
        public string selectedId;
        MySqlConnection host = new MySqlConnection("server=localhost;database=jasafotografi;uid=root;pwd=;");
        public MySqlCommand cmd;
        
        private void karyawan_pembayaran_Load(object sender, EventArgs e)
        {
            showData();
            host.Open();

            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM pemesanan", host);
            DataSet DS = new DataSet();
            DA.Fill(DS, "pemesanan");
            comboBox1.DisplayMember = "id_pemesanan";
            comboBox1.ValueMember = "id_pemesanan";
            comboBox1.DataSource = DS.Tables["pemesanan"];
            comboBox1.ResetText();

            radioButtonP.Checked = false;
            radioButtonL.Checked = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bukti = "";
            int row = dataGridView1.CurrentCell.RowIndex;
            selectedId = dataGridView1.Rows[row].Cells[0].Value.ToString();

            idbox.Text = selectedId;
            comboBox1.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            bukti = dataGridView1.Rows[row].Cells[2].Value.ToString();
            if (bukti == "Lunas")
            {
                radioButtonL.Checked = true;
            }
            else
            {
                radioButtonP.Checked = true;
            }
        }

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
        // PEMESANAN
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            karyawan_pemesanan pemesanan = new karyawan_pemesanan();
            pemesanan.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginform = new login();
            loginform.Show();
        }
        #endregion

        #region CRUD
        public void showData()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM pembayaran", host);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        public void refresh()
        {
            showData();
            idbox.Clear();
            comboBox1.ResetText();
            radioButtonL.Checked = false;
            radioButtonP.Checked = false;
        }
        public void addData()
        {
            string bukti = "";

            if (radioButtonL.Checked)
            {
                bukti = radioButtonL.Text;
            }
            else if (radioButtonP.Checked)
            {
                bukti = radioButtonP.Text;
            }
            cmd = new MySqlCommand("INSERT INTO pembayaran (id_pemesanan, bukti) VALUES ('" + comboBox1.SelectedValue + "','" + bukti + "')", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil ditambahkan!");
        }
        public void updateData()
        {
            string bukti = "";

            if (radioButtonL.Checked)
            {
                bukti = radioButtonL.Text;
            }
            else if (radioButtonP.Checked)
            {
                bukti = radioButtonP.Text;
            }
            cmd = new MySqlCommand("UPDATE pembayaran SET id_pemesanan='" + comboBox1.SelectedValue + "',bukti='" + bukti + "' WHERE id_pembayaran='" + selectedId + "'", host);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil diubah!");
        }
        public void deleteData()
        {
            cmd = new MySqlCommand("DELETE FROM pembayaran WHERE id_pembayaran='" + selectedId + "'", host);
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
        private void button2_Click(object sender, EventArgs e)
        {
            deleteData();
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
        #endregion

        #region UNUSED
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        
    }
}
