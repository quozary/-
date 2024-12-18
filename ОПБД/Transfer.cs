using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ОПБД
{
    public partial class Transfer : Form
    {
        private string connectionString = "Data Source=cars_customers.db;Version=3;";

        public Transfer()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadCars();
        }

        // Инициализация базы данных
        private void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Создание таблицы автомобилей
                string createCarsTable = @"
                    CREATE TABLE IF NOT EXISTS Cars (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Make TEXT NOT NULL,
                        Model TEXT NOT NULL,
                        Year INTEGER NOT NULL,
                        Price REAL NOT NULL
                    );";
                new SQLiteCommand(createCarsTable, conn).ExecuteNonQuery();

                // Создание таблицы покупателей
                string createCustomersTable = @"
                    CREATE TABLE IF NOT EXISTS Customers (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL,
                        Phone TEXT NOT NULL,
                        CarId INTEGER NOT NULL,
                        FOREIGN KEY (CarId) REFERENCES Cars(Id)
                    );";
                new SQLiteCommand(createCustomersTable, conn).ExecuteNonQuery();
            }
        }

        // Загрузка автомобилей в ListBox
        private void LoadCars()
        {
            listBoxCars.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string selectQuery = "SELECT Id, Make, Model, Year, Price FROM Cars";
                SQLiteCommand command = new SQLiteCommand(selectQuery, conn);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string make = reader["Make"].ToString();
                        string model = reader["Model"].ToString();
                        int year = Convert.ToInt32(reader["Year"]);
                        decimal price = Convert.ToDecimal(reader["Price"]);

                        listBoxCars.Items.Add($"{id}. {make} {model} ({year}) - {price:C}");
                    }
                }
            }
        }

        // Добавление автомобиля
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string make = comboBox1.Text;
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

            MessageBox.Show("Автомобиль добавлен.");
            LoadCars();
        }

        // Добавление покупателя и привязка к автомобилю
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string phone = txtPhone.Text;

            if (listBoxCars.SelectedItem == null)
            {
                MessageBox.Show("Выберите автомобиль для покупки.");
                return;
            }

            // Получаем ID выбранного автомобиля
            int carId = int.Parse(listBoxCars.SelectedItem.ToString().Split('.')[0]);

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Customers (FullName, Phone, CarId) VALUES (@FullName, @Phone, @CarId)";
                SQLiteCommand command = new SQLiteCommand(insertQuery, conn);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@CarId", carId);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Покупатель добавлен.");
        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            this.Hide();
            MainForm.Show();
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
