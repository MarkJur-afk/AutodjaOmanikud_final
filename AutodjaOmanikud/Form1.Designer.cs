namespace AutodjaOmanikud
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabPageOwners;
        private TabPage tabPageCars;
        private TabPage tabPageServices;
        private TabPage tabPageServiceTypes;

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
            this.tabControl1 = new TabControl();
            this.tabPageOwners = new TabPage();
            this.tabPageCars = new TabPage();
            this.tabPageServices = new TabPage();
            this.tabPageServiceTypes = new TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            
            // tabControl1
            this.tabControl1.Controls.Add(this.tabPageOwners);
            this.tabControl1.Controls.Add(this.tabPageCars);
            this.tabControl1.Controls.Add(this.tabPageServices);
            this.tabControl1.Controls.Add(this.tabPageServiceTypes);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(1200, 700);
            this.tabControl1.TabIndex = 0;
            
            // tabPageOwners
            this.tabPageOwners.Location = new Point(4, 24);
            this.tabPageOwners.Name = "tabPageOwners";
            this.tabPageOwners.Padding = new Padding(3);
            this.tabPageOwners.Size = new Size(1192, 672);
            this.tabPageOwners.TabIndex = 0;
            this.tabPageOwners.Text = "👥 Владельцы";
            this.tabPageOwners.UseVisualStyleBackColor = true;
            
            // tabPageCars
            this.tabPageCars.Location = new Point(4, 24);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new Padding(3);
            this.tabPageCars.Size = new Size(1192, 672);
            this.tabPageCars.TabIndex = 1;
            this.tabPageCars.Text = "🚗 Автомобили";
            this.tabPageCars.UseVisualStyleBackColor = true;
            
            // tabPageServices
            this.tabPageServices.Location = new Point(4, 24);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new Padding(3);
            this.tabPageServices.Size = new Size(1192, 672);
            this.tabPageServices.TabIndex = 2;
            this.tabPageServices.Text = "🔧 Обслуживание";
            this.tabPageServices.UseVisualStyleBackColor = true;
            
            // tabPageServiceTypes
            this.tabPageServiceTypes.Location = new Point(4, 24);
            this.tabPageServiceTypes.Name = "tabPageServiceTypes";
            this.tabPageServiceTypes.Padding = new Padding(3);
            this.tabPageServiceTypes.Size = new Size(1192, 672);
            this.tabPageServiceTypes.TabIndex = 3;
            this.tabPageServiceTypes.Text = "⚙️ Услуги";
            this.tabPageServiceTypes.UseVisualStyleBackColor = true;
            
            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "🚗 АВТОСЕРВИС PRO";
            this.WindowState = FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}