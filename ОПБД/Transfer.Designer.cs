using System;
using System.Windows.Forms;

namespace ОПБД
{
    partial class Transfer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAddCustomer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 41);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 20);
            this.txtModel.TabIndex = 1;
            this.txtModel.Text = "Модель";
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            this.txtModel.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtModel.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(12, 70);
            this.numYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(150, 20);
            this.numYear.TabIndex = 2;
            this.numYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(12, 99);
            this.numPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 20);
            this.numPrice.TabIndex = 3;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(12, 128);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(150, 23);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Добавить автомобиль";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(180, 12);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(300, 134);
            this.listBoxCars.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 170);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(150, 20);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.Text = "ФИО покупателя";
            this.txtFullName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 199);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Text = "Номер телефона";
            this.txtPhone.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 228);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(150, 23);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Добавить покупателя";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toyota",
            "Ford",
            "Volkswagen",
            "Honda",
            "BMW",
            "Mercedes-Benz",
            "Audi",
            "Nissan",
            "Hyundai",
            "Chevrolet"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Марка";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(388, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transfer
            // 
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.txtModel);
            this.Name = "Transfer";
            this.Text = "Auto.ru Cars & Buyers";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Text)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.Text;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private ComboBox comboBox1;
        private Button button1;
    }
}
