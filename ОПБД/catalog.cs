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
    public partial class catalog : Form
    {
        public catalog()
        {
            InitializeComponent();
        }

        // Обработчик кнопки перехода к форме Transfer
        private void button3_Click(object sender, EventArgs e)
        {
            Transfer trForm = new Transfer();
            this.Hide();
            trForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transfer trForm = new Transfer();
            this.Hide();
            trForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transfer trForm = new Transfer();
            this.Hide();
            trForm.Show();
        }

   

        private void button5_Click(object sender, EventArgs e)
        {
            OpenMainPage();
        }

        private void btnAddCar_Click_1(object sender, EventArgs e)
        {
            OpenMainPage();
        }

        private void OpenMainPage()
        {
            MainPage MainForm = new MainPage();
            this.Hide();
            MainForm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFilterForm();
        }

        private void filter_Click(object sender, EventArgs e)
        {
            OpenFilterForm();
        }

        private void OpenFilterForm()
        {
            FilterForm filter = new FilterForm();
            this.Hide();
            filter.Show();
        }

        // Остальные обработчики событий (если они не используются, можно удалить):
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            addcar addForm = new addcar();
            this.Hide();
            addForm.Show();
        }
    }
}
