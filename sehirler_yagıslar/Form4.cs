using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sehirler_yagıslar
{
    public partial class Form4 : Form
    {
        static string conString = "data source=LAPTOP-2Q7JLS2C\\SQLEXPRESS;initial catalog=cityRain;integrated security=True;";

        public Form4()
        {
            InitializeComponent();
        }

        private void LoadDataToChart(string cityName1, string cityName2, string rainYear)
        {
            string query = "SELECT rainMonth, rainAmount FROM rainTable WHERE (cityName = @CityName1 OR cityName = @CityName2) AND rainYear = @rainYear";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CityName1", cityName1);
                command.Parameters.AddWithValue("@CityName2", cityName2);
                command.Parameters.AddWithValue("@rainYear", rainYear);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Temizleme
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();

                // Yeni ChartArea ekleme
                ChartArea chartArea = new ChartArea();
                chart1.ChartAreas.Add(chartArea);

                // Şehir 1 için yeni bir dizi Serisi oluşturma
                Series series1 = new Series(cityName1);
                series1.ChartType = SeriesChartType.Line;
                chart1.Series.Add(series1);

                // Şehir 2 için yeni bir dizi Serisi oluşturma
                Series series2 = new Series(cityName2);
                series2.ChartType = SeriesChartType.Line;
                chart1.Series.Add(series2);

                while (reader.Read())
                {
                    string month = reader["rainMonth"].ToString();
                    double amount = Convert.ToDouble(reader["rainAmount"]);

                    if (reader["cityName"].ToString() == cityName1)
                    {
                        series1.Points.AddXY(month, amount);
                    }
                    else if (reader["cityName"].ToString() == cityName2)
                    {
                        series2.Points.AddXY(month, amount);
                    }
                }

                reader.Close();
            }
        }

        private void comboCity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity1 = comboCity1.SelectedItem.ToString();
            string selectedCity2 = comboCity2.SelectedItem.ToString();
            string selectedYear = comboYear.SelectedItem.ToString();

            LoadDataToChart(selectedCity1, selectedCity2, selectedYear);
        }

        private void comboCity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity1 = comboCity1.SelectedItem.ToString();
            string selectedCity2 = comboCity2.SelectedItem.ToString();
            string selectedYear = comboYear.SelectedItem.ToString();

            LoadDataToChart(selectedCity1, selectedCity2, selectedYear);
        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity1 = comboCity1.SelectedItem.ToString();
            string selectedCity2 = comboCity2.SelectedItem.ToString();
            string selectedYear = comboYear.SelectedItem.ToString();

            LoadDataToChart(selectedCity1, selectedCity2, selectedYear);
        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void rainButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string selectedCity1 = comboCity1.SelectedItem.ToString();
            string selectedCity2 = comboCity2.SelectedItem.ToString();
            string selectedYear = comboYear.SelectedItem.ToString();

            LoadDataToChart(selectedCity1, selectedCity2, selectedYear);
        }
    }
}