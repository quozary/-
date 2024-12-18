using Microsoft.Data.Sqlite;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ОПБД
{
    public partial class addcar : Form
    {
        private string connectionString = "Data Source=cars.db;Version=3;";

        public addcar()
        {
            InitializeComponent();
            InitializeDatabase();
        }


        // Инициализация базы данных (создание таблицы, если ее нет)
        private void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Cars (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Make TEXT NOT NULL,
                        Model TEXT NOT NULL,
                        Year INTEGER NOT NULL,
                        Price REAL NOT NULL
                    );";
                SQLiteCommand command = new SQLiteCommand(createTableQuery, conn);
                command.ExecuteNonQuery();
            }
        }

        // Добавление автомобиля в БД
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = (int)numYear.Value;
            decimal price = numPrice.Value;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Cars (Make, Model, Year, Price) VALUES (@Make, @Model, @Year, @Price)";
                SQLiteCommand command = new SQLiteCommand(insertQuery, conn);
                command.Parameters.AddWithValue("@Make", make);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Price", price);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Автомобиль добавлен в базу данных.");
            UpdateCarList();
        }

        // Загрузка автомобилей из БД
        private void UpdateCarList()
        {
            listBoxCars.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string selectQuery = "SELECT Make, Model, Year, Price FROM Cars";
                SQLiteCommand command = new SQLiteCommand(selectQuery, conn);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string make = reader["Make"].ToString();
                        string model = reader["Model"].ToString();
                        int year = Convert.ToInt32(reader["Year"]);
                        decimal price = Convert.ToDecimal(reader["Price"]);

                        listBoxCars.Items.Add($"{make} {model} ({year}) - {price:C}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            this.Hide();
            MainForm.Show();
        }
    }
}
