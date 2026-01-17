using AutodjaOmanikud.Controls;
using AutodjaOmanikud.Data;
using Microsoft.EntityFrameworkCore;

namespace AutodjaOmanikud
{
    public partial class Form1 : Form
    {
        private AutoDbContext _context;
        private OwnerControl ownerControl;
        private CarControl carControl;
        private ServiceControl serviceControl;
        private ServiceTypeControl serviceTypeControl;

        public Form1()
        {
            InitializeComponent();
            _context = new AutoDbContext();
            
            // Проверяем существует ли база данных
            try
            {
                if (_context.Database.CanConnect())
                {
                    _context.Database.Migrate();
                }
                else
                {
                    _context.Database.EnsureCreated();
                }
            }
            catch
            {
                // Если ошибка - пересоздаём базу
                _context.Database.EnsureDeleted();
                _context.Database.EnsureCreated();
            }
            
            InitializeControls();
            InitializeLanguageButton();
            UpdateStatistics();
        }

        private void InitializeControls()
        {
            // Создаём и настраиваем контролы
            ownerControl = new OwnerControl();
            carControl = new CarControl();
            serviceControl = new ServiceControl();
            serviceTypeControl = new ServiceTypeControl();
            
            // Подписываемся на события изменения данных
            ownerControl.DataChanged += OnDataChanged;
            carControl.DataChanged += OnDataChanged;
            serviceControl.DataChanged += OnDataChanged;
            serviceTypeControl.DataChanged += OnDataChanged;
            
            // Добавляем контролы на вкладки
            tabPageOwners.Controls.Add(ownerControl);
            ownerControl.Dock = DockStyle.Fill;
            
            tabPageCars.Controls.Add(carControl);
            carControl.Dock = DockStyle.Fill;
            
            tabPageServices.Controls.Add(serviceControl);
            serviceControl.Dock = DockStyle.Fill;
            
            tabPageServiceTypes.Controls.Add(serviceTypeControl);
            serviceTypeControl.Dock = DockStyle.Fill;
        }

        private void OnDataChanged()
        {
            // Обновляем все контролы при изменении данных
            ownerControl.RefreshData();
            carControl.RefreshData();
            serviceControl.RefreshData();
            serviceTypeControl.RefreshData();
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            var ownerCount = _context.Owners.Count();
            var carCount = _context.Cars.Count();
            var serviceCount = _context.Services.Count();
            var totalRevenue = _context.Services.Include(s => s.ServiceType).ToList().Sum(s => s.ServiceType.Price);
            
            this.Text = $"{Localization.GetString("AppTitle")} | {string.Format(Localization.GetString("Statistics"), ownerCount, carCount, serviceCount, totalRevenue)}";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }

        private void InitializeLanguageButton()
        {
            var languageButton = new Button
            {
                Text = "RU/ET",
                Size = new Size(60, 25),
                Location = new Point(this.Width - 80, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            
            languageButton.Click += (s, e) =>
            {
                Localization.CurrentLanguage = Localization.CurrentLanguage == "ru" ? "et" : "ru";
                UpdateLocalization();
            };
            
            this.Controls.Add(languageButton);
            languageButton.BringToFront();
        }

        private void UpdateLocalization()
        {
            tabPageOwners.Text = Localization.GetString("Owners");
            tabPageCars.Text = Localization.GetString("Cars");
            tabPageServices.Text = Localization.GetString("Services");
            tabPageServiceTypes.Text = Localization.GetString("ServiceTypes");
            
            // Обновляем локализацию во всех контролах
            ownerControl.UpdateLocalization();
            carControl.UpdateLocalization();
            serviceControl.UpdateLocalization();
            serviceTypeControl.UpdateLocalization();
            
            UpdateStatistics();
        }
    }
}