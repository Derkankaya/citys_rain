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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sehirler_yagıslar
{
    public partial class Form2 : Form
    {
        static string conString = "data source=LAPTOP-2Q7JLS2C\\SQLEXPRESS;initial catalog=cityRain;integrated security=True;";
        public Form2()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void rainButton_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Hide();
        }

        private void FillComboBoxes()
        {

            string query = "SELECT cityName FROM city";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand commandIl = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader readerIl = commandIl.ExecuteReader();
                while (readerIl.Read())
                {
                    ComboCity.Items.Add(readerIl["cityName"].ToString());
                }
                readerIl.Close();
            }


            for (int year = 2020; year <= 2025; year++)
            {
                ComboYear.Items.Add(year.ToString());
            }


            string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            foreach (string ay in months)
            {
                ComboMounth.Items.Add(ay);
            }
        }
        private void list()
        {
            using (SqlConnection connect = new SqlConnection(conString))
            {
                connect.Open();
                string getir = "SELECT * FROM rainTable";

                SqlCommand komut = new SqlCommand(getir, connect);
                SqlDataAdapter ad = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void saveRainAmountButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRainAmont.Text, out int rainAmount))
            {
                MessageBox.Show("Yağış değeri geçerli bir sayı olmalıdır.");
                return;
            }

            string query = "INSERT INTO rainTable (city, rainYear, rainMonth, rainAmount) VALUES (@city, @rainYear, @rainMonth, @rainAmount)";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@city", ComboCity.SelectedItem.ToString());
                command.Parameters.AddWithValue("@rainYear", ComboYear.SelectedItem.ToString());
                command.Parameters.AddWithValue("@rainMonth", ComboMounth.SelectedItem.ToString());
                command.Parameters.AddWithValue("@rainAmount", rainAmount);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kayıtlandı!");
                list();
                connection.Close();
            }
        }

        private void refleshButton_Click(object sender, EventArgs e)
        {
            list();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            list();
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}