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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public string selectedId;
        MySqlConnection host = new MySqlConnection("server=localhost;database=jasafotografi;uid=root;pwd=;");
        public MySqlCommand cmd;
        private void login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = Loginbutt;
        }

        //CLEAR
        private void ResetButt_Click(object sender, EventArgs e)
        {
            host.Open();
            IDBox.Clear();
        }
        //LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_admin FROM admin WHERE id_admin='" + IDBox.Text + "'", host);
            adapter.Fill(dt);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT id_karyawan FROM karyawan WHERE id_karyawan='" + IDBox.Text + "'", host);
            adapter2.Fill(dt2);
            if (!(dt.Rows.Count <= 0))
            {
                this.Hide();
                admin adminform = new admin();
                adminform.Show();
                host.Close();
            } else if(!(dt2.Rows.Count <= 0))
            {
                this.Hide();
                karyawan karyawanform = new karyawan();
                karyawanform.Show();
                host.Close();
            }
            else
            {
                MessageBox.Show("Login gagal!");
                host.Close();
            }
        }
        #region UNUSED LABELS
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        #endregion

        
    }
}
