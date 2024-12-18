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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            sign MainForm = new sign();
            this.Hide();
            MainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            this.Hide();
            MainForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign signForm = new sign();
            this.Hide();
            signForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            this.Hide();
            MainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sign signForm = new sign();
            this.Hide();
            signForm.Show();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            this.Hide();
            MainForm.Show();
        }
    }
}
