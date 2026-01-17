using AutodjaOmanikud.Data;
using AutodjaOmanikud.Models;
using Microsoft.EntityFrameworkCore;

namespace AutodjaOmanikud.Controls
{
    public partial class ServiceControl : UserControl
    {
        private AutoDbContext _context;
        public event Action DataChanged;

        public ServiceControl()
        {
            InitializeComponent();
            _context = new AutoDbContext();
            LoadData();
        }

        private void LoadData()
        {
            LoadServices();
            LoadCars();
            LoadServiceTypes();
        }

        private void LoadServices()
        {
            var services = _context.Services
                .Include(s => s.Car).ThenInclude(c => c.Owner)
                .Include(s => s.ServiceType)
                .OrderByDescending(s => s.Time)
                .ToList();

            dataGridViewServices.DataSource = services.Select(s => new
            {
                s.Id,
                Клиент = s.Car.Owner.FullName,
                Автомобиль = $"{s.Car.Brand} {s.Car.Model} ({s.Car.RegistrationNumber})",
                Услуга = s.ServiceType.Name,
                Цена = $"€{s.ServiceType.Price:F2}",
                Оплачено = s.IsPaid ? "✅ Да" : "❌ Нет",
                Дата = s.Time.ToString("dd.MM.yyyy HH:mm")
            }).ToList();
        }

        private void LoadCars()
        {
            var cars = _context.Cars.Include(c => c.Owner).ToList();
            comboBoxCar.DataSource = cars;
            comboBoxCar.DisplayMember = "RegistrationNumber";
            comboBoxCar.ValueMember = "Id";
            comboBoxCar.SelectedIndex = -1;
        }

        private void LoadServiceTypes()
        {
            var serviceTypes = _context.ServiceTypes.ToList();
            comboBoxServiceType.DataSource = serviceTypes;
            comboBoxServiceType.DisplayMember = "Name";
            comboBoxServiceType.ValueMember = "Id";
            comboBoxServiceType.SelectedIndex = -1;
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            if (comboBoxCar.SelectedValue == null || comboBoxServiceType.SelectedValue == null)
            {
                MessageBox.Show("Выберите автомобиль и услугу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var service = new Service
            {
                CarId = (int)comboBoxCar.SelectedValue,
                ServiceTypeId = (int)comboBoxServiceType.SelectedValue,
                Time = dateTimePickerService.Value,
                IsPaid = checkBoxPaid.Checked
            };

            _context.Services.Add(service);
            _context.SaveChanges();
            ClearFields();
            LoadServices();
            DataChanged?.Invoke();
            MessageBox.Show("Запись об обслуживании добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count == 0) return;

            var serviceId = (int)dataGridViewServices.SelectedRows[0].Cells["Id"].Value;
            if (MessageBox.Show("Удалить запись об обслуживании?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var service = _context.Services.Find(serviceId);
                if (service != null)
                {
                    _context.Services.Remove(service);
                    _context.SaveChanges();
                    LoadServices();
                    DataChanged?.Invoke();
                    MessageBox.Show("Запись удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonTogglePaid_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count == 0) return;

            var serviceId = (int)dataGridViewServices.SelectedRows[0].Cells["Id"].Value;
            var service = _context.Services.Find(serviceId);
            if (service != null)
            {
                service.IsPaid = !service.IsPaid;
                _context.SaveChanges();
                LoadServices();
                DataChanged?.Invoke();
                MessageBox.Show($"Статус оплаты изменён на: {(service.IsPaid ? "Оплачено" : "Не оплачено")}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields()
        {
            comboBoxCar.SelectedIndex = -1;
            comboBoxServiceType.SelectedIndex = -1;
            dateTimePickerService.Value = DateTime.Now;
            checkBoxPaid.Checked = false;
        }

        public void RefreshData() => LoadData();

        public void UpdateLocalization()
        {
            labelCar.Text = Localization.GetString("Car");
            labelServiceType.Text = Localization.GetString("Service");
            labelDate.Text = Localization.GetString("Date");
            checkBoxPaid.Text = Localization.GetString("Paid");
            buttonAddService.Text = Localization.GetString("Add");
            buttonDeleteService.Text = Localization.GetString("Delete");
            buttonTogglePaid.Text = Localization.GetString("TogglePaid");
        }
    }
}