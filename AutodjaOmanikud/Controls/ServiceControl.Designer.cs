namespace AutodjaOmanikud.Controls
{
    partial class ServiceControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewServices;
        private ComboBox comboBoxCar;
        private ComboBox comboBoxServiceType;
        private DateTimePicker dateTimePickerService;
        private CheckBox checkBoxPaid;
        private Button buttonAddService;
        private Button buttonDeleteService;
        private Button buttonTogglePaid;
        private Label labelCar;
        private Label labelServiceType;
        private Label labelDate;

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
            this.dataGridViewServices = new DataGridView();
            this.comboBoxCar = new ComboBox();
            this.comboBoxServiceType = new ComboBox();
            this.dateTimePickerService = new DateTimePicker();
            this.checkBoxPaid = new CheckBox();
            this.buttonAddService = new Button();
            this.buttonDeleteService = new Button();
            this.buttonTogglePaid = new Button();
            this.labelCar = new Label();
            this.labelServiceType = new Label();
            this.labelDate = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            
            // dataGridViewServices
            this.dataGridViewServices.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServices.Location = new Point(12, 12);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            this.dataGridViewServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new Size(776, 250);
            this.dataGridViewServices.TabIndex = 0;
            
            // labelCar
            this.labelCar.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new Point(12, 280);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new Size(73, 15);
            this.labelCar.TabIndex = 1;
            this.labelCar.Text = "Автомобиль:";
            
            // comboBoxCar
            this.comboBoxCar.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.comboBoxCar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCar.Location = new Point(12, 298);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new Size(200, 23);
            this.comboBoxCar.TabIndex = 2;
            
            // labelServiceType
            this.labelServiceType.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelServiceType.AutoSize = true;
            this.labelServiceType.Location = new Point(230, 280);
            this.labelServiceType.Name = "labelServiceType";
            this.labelServiceType.Size = new Size(46, 15);
            this.labelServiceType.TabIndex = 3;
            this.labelServiceType.Text = "Услуга:";
            
            // comboBoxServiceType
            this.comboBoxServiceType.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.comboBoxServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxServiceType.Location = new Point(230, 298);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new Size(200, 23);
            this.comboBoxServiceType.TabIndex = 4;
            
            // labelDate
            this.labelDate.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new Point(12, 330);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new Size(35, 15);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата:";
            
            // dateTimePickerService
            this.dateTimePickerService.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.dateTimePickerService.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerService.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerService.Location = new Point(12, 348);
            this.dateTimePickerService.Name = "dateTimePickerService";
            this.dateTimePickerService.Size = new Size(150, 23);
            this.dateTimePickerService.TabIndex = 6;
            
            // checkBoxPaid
            this.checkBoxPaid.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new Point(180, 350);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new Size(82, 19);
            this.checkBoxPaid.TabIndex = 7;
            this.checkBoxPaid.Text = "Оплачено";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            
            // buttonAddService
            this.buttonAddService.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonAddService.BackColor = Color.FromArgb(46, 204, 113);
            this.buttonAddService.ForeColor = Color.White;
            this.buttonAddService.Location = new Point(450, 298);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new Size(100, 23);
            this.buttonAddService.TabIndex = 8;
            this.buttonAddService.Text = "Добавить";
            this.buttonAddService.UseVisualStyleBackColor = false;
            this.buttonAddService.Click += new EventHandler(this.buttonAddService_Click);
            
            // buttonDeleteService
            this.buttonDeleteService.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonDeleteService.BackColor = Color.FromArgb(231, 76, 60);
            this.buttonDeleteService.ForeColor = Color.White;
            this.buttonDeleteService.Location = new Point(570, 298);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new Size(100, 23);
            this.buttonDeleteService.TabIndex = 9;
            this.buttonDeleteService.Text = "Удалить";
            this.buttonDeleteService.UseVisualStyleBackColor = false;
            this.buttonDeleteService.Click += new EventHandler(this.buttonDeleteService_Click);
            
            // buttonTogglePaid
            this.buttonTogglePaid.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonTogglePaid.BackColor = Color.FromArgb(52, 152, 219);
            this.buttonTogglePaid.ForeColor = Color.White;
            this.buttonTogglePaid.Location = new Point(450, 348);
            this.buttonTogglePaid.Name = "buttonTogglePaid";
            this.buttonTogglePaid.Size = new Size(220, 23);
            this.buttonTogglePaid.TabIndex = 10;
            this.buttonTogglePaid.Text = "Изменить статус оплаты";
            this.buttonTogglePaid.UseVisualStyleBackColor = false;
            this.buttonTogglePaid.Click += new EventHandler(this.buttonTogglePaid_Click);
            
            // ServiceControl
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.buttonTogglePaid);
            this.Controls.Add(this.buttonDeleteService);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.checkBoxPaid);
            this.Controls.Add(this.dateTimePickerService);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxServiceType);
            this.Controls.Add(this.labelServiceType);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.dataGridViewServices);
            this.Name = "ServiceControl";
            this.Size = new Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}