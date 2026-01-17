namespace AutodjaOmanikud.Controls
{
    partial class CarControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewCars;
        private TextBox textBoxCarBrand;
        private TextBox textBoxCarModel;
        private TextBox textBoxCarRegistration;
        private ComboBox comboBoxCarOwner;
        private Button buttonAddCar;
        private Button buttonDeleteCar;
        private Label labelCarBrand;
        private Label labelCarModel;
        private Label labelCarRegistration;
        private Label labelCarOwner;

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
            this.dataGridViewCars = new DataGridView();
            this.textBoxCarBrand = new TextBox();
            this.textBoxCarModel = new TextBox();
            this.textBoxCarRegistration = new TextBox();
            this.comboBoxCarOwner = new ComboBox();
            this.buttonAddCar = new Button();
            this.buttonDeleteCar = new Button();
            this.labelCarBrand = new Label();
            this.labelCarModel = new Label();
            this.labelCarRegistration = new Label();
            this.labelCarOwner = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            
            // dataGridViewCars
            this.dataGridViewCars.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dataGridViewCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.Location = new Point(12, 12);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCars.Size = new Size(776, 250);
            this.dataGridViewCars.TabIndex = 0;
            
            // labelCarBrand
            this.labelCarBrand.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelCarBrand.AutoSize = true;
            this.labelCarBrand.Location = new Point(12, 280);
            this.labelCarBrand.Name = "labelCarBrand";
            this.labelCarBrand.Size = new Size(43, 15);
            this.labelCarBrand.TabIndex = 1;
            this.labelCarBrand.Text = "Марка:";
            
            // textBoxCarBrand
            this.textBoxCarBrand.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxCarBrand.Location = new Point(12, 298);
            this.textBoxCarBrand.Name = "textBoxCarBrand";
            this.textBoxCarBrand.Size = new Size(150, 23);
            this.textBoxCarBrand.TabIndex = 2;
            
            // labelCarModel
            this.labelCarModel.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Location = new Point(180, 280);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new Size(50, 15);
            this.labelCarModel.TabIndex = 3;
            this.labelCarModel.Text = "Модель:";
            
            // textBoxCarModel
            this.textBoxCarModel.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxCarModel.Location = new Point(180, 298);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new Size(150, 23);
            this.textBoxCarModel.TabIndex = 4;
            
            // labelCarRegistration
            this.labelCarRegistration.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelCarRegistration.AutoSize = true;
            this.labelCarRegistration.Location = new Point(12, 330);
            this.labelCarRegistration.Name = "labelCarRegistration";
            this.labelCarRegistration.Size = new Size(44, 15);
            this.labelCarRegistration.TabIndex = 5;
            this.labelCarRegistration.Text = "Номер:";
            
            // textBoxCarRegistration
            this.textBoxCarRegistration.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxCarRegistration.Location = new Point(12, 348);
            this.textBoxCarRegistration.Name = "textBoxCarRegistration";
            this.textBoxCarRegistration.Size = new Size(150, 23);
            this.textBoxCarRegistration.TabIndex = 6;
            
            // labelCarOwner
            this.labelCarOwner.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelCarOwner.AutoSize = true;
            this.labelCarOwner.Location = new Point(180, 330);
            this.labelCarOwner.Name = "labelCarOwner";
            this.labelCarOwner.Size = new Size(63, 15);
            this.labelCarOwner.TabIndex = 7;
            this.labelCarOwner.Text = "Владелец:";
            
            // comboBoxCarOwner
            this.comboBoxCarOwner.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.comboBoxCarOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCarOwner.Location = new Point(180, 348);
            this.comboBoxCarOwner.Name = "comboBoxCarOwner";
            this.comboBoxCarOwner.Size = new Size(200, 23);
            this.comboBoxCarOwner.TabIndex = 8;
            
            // buttonAddCar
            this.buttonAddCar.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonAddCar.BackColor = Color.FromArgb(46, 204, 113);
            this.buttonAddCar.ForeColor = Color.White;
            this.buttonAddCar.Location = new Point(400, 348);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new Size(100, 23);
            this.buttonAddCar.TabIndex = 9;
            this.buttonAddCar.Text = "Добавить";
            this.buttonAddCar.UseVisualStyleBackColor = false;
            this.buttonAddCar.Click += new EventHandler(this.buttonAddCar_Click);
            
            // buttonDeleteCar
            this.buttonDeleteCar.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonDeleteCar.BackColor = Color.FromArgb(231, 76, 60);
            this.buttonDeleteCar.ForeColor = Color.White;
            this.buttonDeleteCar.Location = new Point(520, 348);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new Size(100, 23);
            this.buttonDeleteCar.TabIndex = 10;
            this.buttonDeleteCar.Text = "Удалить";
            this.buttonDeleteCar.UseVisualStyleBackColor = false;
            this.buttonDeleteCar.Click += new EventHandler(this.buttonDeleteCar_Click);
            
            // CarControl
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.comboBoxCarOwner);
            this.Controls.Add(this.labelCarOwner);
            this.Controls.Add(this.textBoxCarRegistration);
            this.Controls.Add(this.labelCarRegistration);
            this.Controls.Add(this.textBoxCarModel);
            this.Controls.Add(this.labelCarModel);
            this.Controls.Add(this.textBoxCarBrand);
            this.Controls.Add(this.labelCarBrand);
            this.Controls.Add(this.dataGridViewCars);
            this.Name = "CarControl";
            this.Size = new Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}