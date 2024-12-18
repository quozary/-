namespace ОПБД
{
    partial class addcar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;

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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAddCar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCar.ForeColor = System.Drawing.Color.Black;
            this.btnAddCar.Location = new System.Drawing.Point(12, 150);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(100, 40);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Добавить";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.Font = new System.Drawing.Font("Arial", 9F);
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 15;
            this.listBoxCars.Location = new System.Drawing.Point(12, 200);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(400, 139);
            this.listBoxCars.TabIndex = 1;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMake.Location = new System.Drawing.Point(80, 12);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(150, 23);
            this.txtMake.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Arial", 10F);
            this.txtModel.Location = new System.Drawing.Point(80, 38);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 23);
            this.txtModel.TabIndex = 3;
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Arial", 10F);
            this.numYear.Location = new System.Drawing.Point(80, 64);
            this.numYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(100, 23);
            this.numYear.TabIndex = 4;
            this.numYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Arial", 10F);
            this.numPrice.Location = new System.Drawing.Point(80, 90);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 23);
            this.numPrice.TabIndex = 5;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMake.Location = new System.Drawing.Point(12, 15);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(52, 16);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "Марка:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblModel.Location = new System.Drawing.Point(12, 41);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(62, 16);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Модель:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Arial", 10F);
            this.lblYear.Location = new System.Drawing.Point(12, 66);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(34, 16);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Год:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPrice.Location = new System.Drawing.Point(12, 92);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 16);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Цена:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(300, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addcar
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(424, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.btnAddCar);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "addcar";
            this.Text = "Auto.ru Cars Search";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
    }
}
