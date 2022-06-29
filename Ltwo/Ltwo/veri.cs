using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Ltwo
{
    public partial class veri : Form
    {
        public veri()
        {
            InitializeComponent();
        }
        string kaynak = "Data Source=LAPTOP-F894CB6L;Initial Catalog=kişiler;Integrated Security=True";
        private void view_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlDataAdapter adapter = new SqlDataAdapter("select* from employee", bağlantı);
            DataSet data = new DataSet();
            bağlantı.Open();

            adapter.Fill(data, "employee");
            info.DataSource = data.Tables["employee"];
            bağlantı.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlCommand komut = new SqlCommand(kaynak, bağlantı);
            komut.Connection.Open();
            komut.CommandText = "insert into employee (ID,lastname,firstname,hiredate) values(" + pıd.Text +
                ",'" + lname.Text + "','" + fname.Text + "','" + hdate.Text + "')";
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlCommand komut = new SqlCommand(kaynak, bağlantı);
            komut.Connection.Open();
            komut.CommandText = "update employee set lastname='" + lname.Text + "',firstname='"
                + fname.Text + "',hiredate='" + hdate.Text + "' where ID=" + pıd.Text + "";
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlCommand komut = new SqlCommand(kaynak, bağlantı);
            komut.Connection.Open();
            komut.CommandText = "delete from employee where ID=" + pıd.Text + "";
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }

        private void veri_Load(object sender, EventArgs e)
        {
            dosya.Title = "Bir Dosya Seç";
            dosya.FileName = "Dosya Seç";
            dosya.InitialDirectory = @"C:\Users\nurse\OneDrive\Masaüstü";
            dosya.Filter = "XML Dosyaları (*.xml)|*.xml";
           
        }
     
        private void import_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            DataSet ds = new DataSet();
            ds.ReadXml(filepath.Text);
            info.DataSource = ds.Tables[0];
            info.AllowUserToAddRows = false;
            string sorgu;
            SqlCommand cmd;
            bağlantı.Open(); ;
            SqlCommand cmd1;
            string cmdtext;
           
            
         
                for ( int i=0; i<info.Rows.Count;i++) {
                sorgu= "select count (*)  from employee where ID=" + info.Rows[i].Cells[2].Value.ToString()+"";
                cmd =new SqlCommand(sorgu,bağlantı);
                    if((int)cmd.ExecuteScalar()==1) 
                    {
                        cmdtext= "update employee set lastname='" + info.Rows[i].Cells[0].Value.ToString() 
                        + "',firstname='"+ info.Rows[i].Cells[1].Value.ToString()
                        + "',hiredate='" + info.Rows[i].Cells[2].Value.ToString()
                        + "' where ID=" + info.Rows[i].Cells[3].Value.ToString() + "";
                         cmd1 = new SqlCommand(cmdtext, bağlantı);
                          cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmdtext= "insert into employee (ID,lastname,firstname,hiredate) values(" 
                        + info.Rows[i].Cells[2].Value.ToString()
                        + ",'" + info.Rows[i].Cells[0].Value.ToString()
                        + "','" + info.Rows[i].Cells[1].Value.ToString()
                        + "','" + info.Rows[i].Cells[3].Value.ToString() + "')";
                      cmd = new SqlCommand(cmdtext, bağlantı);
                    cmd.ExecuteNonQuery();


                }

                }
                bağlantı.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("select* from employee", bağlantı);
            DataSet data = new DataSet();
            bağlantı.Open();

            adapter.Fill(data, "employee");
            info.DataSource = data.Tables["employee"];
            bağlantı.Close();

        }



        

        private void button1_Click(object sender, EventArgs e)
        {
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                filepath.Text = dosya.FileName;

            }
        }

        private void export_Click(object sender, EventArgs e)
        {   
            info.AllowUserToAddRows=false;
            import_Click(sender, e);
            List<employee> emp = new List<employee>();
            for (int i = 0; i < info.Rows.Count; i++)
            {
                employee employee = new employee
                {
                    ID = Int32.Parse (info.Rows[i].Cells[0].Value.ToString()),
                    LastName= info.Rows[i].Cells[1].Value.ToString(), 
                    FirstName= ((info.Rows[i].Cells[2].Value.ToString())),
                    HireDate = info.Rows[i].Cells[3].Value.ToString(),

                };
                emp.Add(employee);
            }
            var xs = new XmlSerializer(typeof(List<employee>));
            using (var writer = new StreamWriter("sonhal.xml")) 
            {
                xs.Serialize(writer, emp);
            }
        }
    }
}
