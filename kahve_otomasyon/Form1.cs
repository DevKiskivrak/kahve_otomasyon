using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kahve_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantim baglanti = new SqlBaglantim();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select UserName, UserPassword from STBUsers where UserName = @p1 and UserPassword = @p2", baglanti.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtUserName.Text);
                cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("GİRİŞ BAŞARILI!");
                }
                else
                {
                    MessageBox.Show("Başarısız!");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }

        }

     
    } 
}
