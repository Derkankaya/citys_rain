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
using System.Xml.Linq;

namespace sehirler_yagıslar
{
    public partial class Form1 : Form
    {
        static string conString = "data source=LAPTOP-2Q7JLS2C\\SQLEXPRESS;initial catalog=cityRain;integrated security=True;";
        SqlConnection connect = new SqlConnection(conString);
        public Form1()
        {
            InitializeComponent();
            list();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void list()
        {
            using (SqlConnection connect = new SqlConnection(conString))
            {
                connect.Open();
                string getir = "SELECT * FROM city";

                SqlCommand komut = new SqlCommand(getir, connect);
                SqlDataAdapter ad = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }



        private void SaveCityButton_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connect = new SqlConnection(conString))
                {
                    connect.Open();

                    string save = "INSERT INTO city (cityNo, cityName) VALUES (@cityNo, @cityName)";
                    using (SqlCommand komut = new SqlCommand(save, connect))
                    {
                        komut.Parameters.AddWithValue("@cityNo", txtCityNo.Text );
                        komut.Parameters.AddWithValue("@cityName", txtCityName.Text);
                        komut.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("Kayıtlandı!");
                list();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BİR HATA OLUŞTU!" + ex.Message);
            }
        }

        private void refleshButton_Click(object sender, EventArgs e)
        {
            list();
        }

        private void SehirlerButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            list();
        }

        private void YagisButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  
            this.Hide();
        }

        private void GrafikButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

    }   
}
