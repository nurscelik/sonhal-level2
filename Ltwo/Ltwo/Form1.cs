using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ltwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        string kaynak = "Data Source=LAPTOP-F894CB6L;Initial Catalog=kişiler;Integrated Security=True";
        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            string sorgu = "SELECT* FROM kişibilgisi where username='" + uname.Text + "'AND userpassword='" + upassword.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, bağlantı);
            komut.Connection.Open();
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read())
            {
                veri f2 = new veri();
                f2.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
            }
            read.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void şifreleme_CheckedChanged(object sender, EventArgs e)
        {
            if (şifreleme.CheckState == CheckState.Checked)
            {
                upassword.UseSystemPasswordChar = true;
            }
            else if (şifreleme.CheckState == CheckState.Unchecked)
            {
                upassword.UseSystemPasswordChar = false;
            }
        }
    }
}
