namespace AutodjaOmanikud.Controls
{
    partial class ServiceTypeControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewServiceTypes;
        private TextBox textBoxServiceName;
        private TextBox textBoxServicePrice;
        private Button buttonAddServiceType;
        private Button buttonDeleteServiceType;
        private Button buttonEditServiceType;
        private Label labelServiceName;
        private Label labelServicePrice;

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
            this.dataGridViewServiceTypes = new DataGridView();
            this.textBoxServiceName = new TextBox();
            this.textBoxServicePrice = new TextBox();
            this.buttonAddServiceType = new Button();
            this.buttonDeleteServiceType = new Button();
            this.buttonEditServiceType = new Button();
            this.labelServiceName = new Label();
            this.labelServicePrice = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceTypes)).BeginInit();
            this.SuspendLayout();
            
            // dataGridViewServiceTypes
            this.dataGridViewServiceTypes.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dataGridViewServiceTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServiceTypes.Location = new Point(12, 12);
            this.dataGridViewServiceTypes.Name = "dataGridViewServiceTypes";
            this.dataGridViewServiceTypes.ReadOnly = true;
            this.dataGridViewServiceTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceTypes.Size = new Size(776, 300);
            this.dataGridViewServiceTypes.TabIndex = 0;
            
            // labelServiceName
            this.labelServiceName.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.Location = new Point(12, 330);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new Size(62, 15);
            this.labelServiceName.TabIndex = 1;
            this.labelServiceName.Text = "Название:";
            
            // textBoxServiceName
            this.textBoxServiceName.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxServiceName.Location = new Point(12, 348);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new Size(200, 23);
            this.textBoxServiceName.TabIndex = 2;
            
            // labelServicePrice
            this.labelServicePrice.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelServicePrice.AutoSize = true;
            this.labelServicePrice.Location = new Point(230, 330);
            this.labelServicePrice.Name = "labelServicePrice";
            this.labelServicePrice.Size = new Size(38, 15);
            this.labelServicePrice.TabIndex = 3;
            this.labelServicePrice.Text = "Цена:";
            
            // textBoxServicePrice
            this.textBoxServicePrice.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxServicePrice.Location = new Point(230, 348);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new Size(100, 23);
            this.textBoxServicePrice.TabIndex = 4;
            
            // buttonAddServiceType
            this.buttonAddServiceType.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonAddServiceType.BackColor = Color.FromArgb(46, 204, 113);
            this.buttonAddServiceType.ForeColor = Color.White;
            this.buttonAddServiceType.Location = new Point(350, 348);
            this.buttonAddServiceType.Name = "buttonAddServiceType";
            this.buttonAddServiceType.Size = new Size(100, 23);
            this.buttonAddServiceType.TabIndex = 5;
            this.buttonAddServiceType.Text = "Добавить";
            this.buttonAddServiceType.UseVisualStyleBackColor = false;
            this.buttonAddServiceType.Click += new EventHandler(this.buttonAddServiceType_Click);
            
            // buttonEditServiceType
            this.buttonEditServiceType.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonEditServiceType.BackColor = Color.FromArgb(52, 152, 219);
            this.buttonEditServiceType.ForeColor = Color.White;
            this.buttonEditServiceType.Location = new Point(470, 348);
            this.buttonEditServiceType.Name = "buttonEditServiceType";
            this.buttonEditServiceType.Size = new Size(100, 23);
            this.buttonEditServiceType.TabIndex = 6;
            this.buttonEditServiceType.Text = "Изменить";
            this.buttonEditServiceType.UseVisualStyleBackColor = false;
            this.buttonEditServiceType.Click += new EventHandler(this.buttonEditServiceType_Click);
            
            // buttonDeleteServiceType
            this.buttonDeleteServiceType.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonDeleteServiceType.BackColor = Color.FromArgb(231, 76, 60);
            this.buttonDeleteServiceType.ForeColor = Color.White;
            this.buttonDeleteServiceType.Location = new Point(590, 348);
            this.buttonDeleteServiceType.Name = "buttonDeleteServiceType";
            this.buttonDeleteServiceType.Size = new Size(100, 23);
            this.buttonDeleteServiceType.TabIndex = 7;
            this.buttonDeleteServiceType.Text = "Удалить";
            this.buttonDeleteServiceType.UseVisualStyleBackColor = false;
            this.buttonDeleteServiceType.Click += new EventHandler(this.buttonDeleteServiceType_Click);
            
            // ServiceTypeControl
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteServiceType);
            this.Controls.Add(this.buttonEditServiceType);
            this.Controls.Add(this.buttonAddServiceType);
            this.Controls.Add(this.textBoxServicePrice);
            this.Controls.Add(this.labelServicePrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.labelServiceName);
            this.Controls.Add(this.dataGridViewServiceTypes);
            this.Name = "ServiceTypeControl";
            this.Size = new Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}