namespace AutodjaOmanikud.Controls
{
    partial class OwnerControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewOwners;
        private TextBox textBoxOwnerName;
        private TextBox textBoxOwnerPhone;
        private Button buttonAddOwner;
        private Button buttonDeleteOwner;
        private Button buttonEditOwner;
        private Label labelOwnerName;
        private Label labelOwnerPhone;

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
            this.dataGridViewOwners = new DataGridView();
            this.textBoxOwnerName = new TextBox();
            this.textBoxOwnerPhone = new TextBox();
            this.buttonAddOwner = new Button();
            this.buttonDeleteOwner = new Button();
            this.buttonEditOwner = new Button();
            this.labelOwnerName = new Label();
            this.labelOwnerPhone = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).BeginInit();
            this.SuspendLayout();
            
            // dataGridViewOwners
            this.dataGridViewOwners.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dataGridViewOwners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOwners.Location = new Point(12, 12);
            this.dataGridViewOwners.Name = "dataGridViewOwners";
            this.dataGridViewOwners.ReadOnly = true;
            this.dataGridViewOwners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOwners.Size = new Size(776, 300);
            this.dataGridViewOwners.TabIndex = 0;
            
            // labelOwnerName
            this.labelOwnerName.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelOwnerName.AutoSize = true;
            this.labelOwnerName.Location = new Point(12, 330);
            this.labelOwnerName.Name = "labelOwnerName";
            this.labelOwnerName.Size = new Size(34, 15);
            this.labelOwnerName.TabIndex = 1;
            this.labelOwnerName.Text = Localization.GetString("Name");
            
            // textBoxOwnerName
            this.textBoxOwnerName.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxOwnerName.Location = new Point(12, 348);
            this.textBoxOwnerName.Name = "textBoxOwnerName";
            this.textBoxOwnerName.Size = new Size(200, 23);
            this.textBoxOwnerName.TabIndex = 2;
            
            // labelOwnerPhone
            this.labelOwnerPhone.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.labelOwnerPhone.AutoSize = true;
            this.labelOwnerPhone.Location = new Point(230, 330);
            this.labelOwnerPhone.Name = "labelOwnerPhone";
            this.labelOwnerPhone.Size = new Size(58, 15);
            this.labelOwnerPhone.TabIndex = 3;
            this.labelOwnerPhone.Text = Localization.GetString("Phone");
            
            // textBoxOwnerPhone
            this.textBoxOwnerPhone.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxOwnerPhone.Location = new Point(230, 348);
            this.textBoxOwnerPhone.Name = "textBoxOwnerPhone";
            this.textBoxOwnerPhone.Size = new Size(200, 23);
            this.textBoxOwnerPhone.TabIndex = 4;
            
            // buttonAddOwner
            this.buttonAddOwner.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonAddOwner.BackColor = Color.FromArgb(46, 204, 113);
            this.buttonAddOwner.ForeColor = Color.White;
            this.buttonAddOwner.Location = new Point(450, 348);
            this.buttonAddOwner.Name = "buttonAddOwner";
            this.buttonAddOwner.Size = new Size(100, 23);
            this.buttonAddOwner.TabIndex = 5;
            this.buttonAddOwner.Text = Localization.GetString("Add");
            this.buttonAddOwner.UseVisualStyleBackColor = false;
            this.buttonAddOwner.Click += new EventHandler(this.buttonAddOwner_Click);
            
            // buttonEditOwner
            this.buttonEditOwner.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonEditOwner.BackColor = Color.FromArgb(52, 152, 219);
            this.buttonEditOwner.ForeColor = Color.White;
            this.buttonEditOwner.Location = new Point(570, 348);
            this.buttonEditOwner.Name = "buttonEditOwner";
            this.buttonEditOwner.Size = new Size(100, 23);
            this.buttonEditOwner.TabIndex = 7;
            this.buttonEditOwner.Text = Localization.GetString("Edit");
            this.buttonEditOwner.UseVisualStyleBackColor = false;
            this.buttonEditOwner.Click += new EventHandler(this.buttonEditOwner_Click);
            
            // buttonDeleteOwner
            this.buttonDeleteOwner.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.buttonDeleteOwner.BackColor = Color.FromArgb(231, 76, 60);
            this.buttonDeleteOwner.ForeColor = Color.White;
            this.buttonDeleteOwner.Location = new Point(690, 348);
            this.buttonDeleteOwner.Name = "buttonDeleteOwner";
            this.buttonDeleteOwner.Size = new Size(100, 23);
            this.buttonDeleteOwner.TabIndex = 8;
            this.buttonDeleteOwner.Text = Localization.GetString("Delete");
            this.buttonDeleteOwner.UseVisualStyleBackColor = false;
            this.buttonDeleteOwner.Click += new EventHandler(this.buttonDeleteOwner_Click);
            
            // OwnerControl
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditOwner);
            this.Controls.Add(this.buttonDeleteOwner);
            this.Controls.Add(this.buttonAddOwner);
            this.Controls.Add(this.textBoxOwnerPhone);
            this.Controls.Add(this.labelOwnerPhone);
            this.Controls.Add(this.textBoxOwnerName);
            this.Controls.Add(this.labelOwnerName);
            this.Controls.Add(this.dataGridViewOwners);
            this.Name = "OwnerControl";
            this.Size = new Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}