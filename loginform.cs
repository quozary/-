using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОПБД
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Войти_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            Main mainForm = new Main(); // ВЫДЕЛЯЕМ ПАМЯТЬ

            database db = new database(); // Создаем экземпляр класса database

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // Используем экземпляр db для вызова метода getConnection()
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `pass` = @up", connection: db.getConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Успешно");
            else
                MessageBox.Show("Ошибка");

            this.Hide();
            mainForm.Show();
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрывает форму
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
