using AutodjaOmanikud.Data;
using AutodjaOmanikud.Models;

namespace AutodjaOmanikud.Controls
{
    public partial class ServiceTypeControl : UserControl
    {
        private AutoDbContext _context;
        public event Action DataChanged;

        public ServiceTypeControl()
        {
            InitializeComponent();
            _context = new AutoDbContext();
            LoadServiceTypes();
        }

        private void LoadServiceTypes()
        {
            var serviceTypes = _context.ServiceTypes.ToList();
            dataGridViewServiceTypes.DataSource = serviceTypes.Select(st => new
            {
                st.Id,
                Название = st.Name,
                Цена = $"€{st.Price:F2}"
            }).ToList();
        }

        private void buttonAddServiceType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxServiceName.Text) ||
                !decimal.TryParse(textBoxServicePrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректное название и цену!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var serviceType = new ServiceType
            {
                Name = textBoxServiceName.Text.Trim(),
                Price = price
            };

            _context.ServiceTypes.Add(serviceType);
            _context.SaveChanges();
            ClearFields();
            LoadServiceTypes();
            DataChanged?.Invoke();
            MessageBox.Show($"Услуга '{serviceType.Name}' добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeleteServiceType_Click(object sender, EventArgs e)
        {
            if (dataGridViewServiceTypes.SelectedRows.Count == 0) return;

            var serviceName = dataGridViewServiceTypes.SelectedRows[0].Cells["Название"].Value.ToString();
            if (MessageBox.Show($"Удалить услугу '{serviceName}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var serviceId = (int)dataGridViewServiceTypes.SelectedRows[0].Cells["Id"].Value;
                var service = _context.ServiceTypes.Find(serviceId);
                if (service != null)
                {
                    try
                    {
                        _context.ServiceTypes.Remove(service);
                        _context.SaveChanges();
                        LoadServiceTypes();
                        DataChanged?.Invoke();
                        MessageBox.Show("Услуга удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Нельзя удалить услугу, которая используется в записях обслуживания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonEditServiceType_Click(object sender, EventArgs e)
        {
            if (dataGridViewServiceTypes.SelectedRows.Count == 0) return;

            var serviceId = (int)dataGridViewServiceTypes.SelectedRows[0].Cells["Id"].Value;
            var service = _context.ServiceTypes.Find(serviceId);
            if (service != null)
            {
                textBoxServiceName.Text = service.Name;
                textBoxServicePrice.Text = service.Price.ToString();
                buttonAddServiceType.Text = "Обновить";
                buttonAddServiceType.Tag = serviceId;
            }
        }

        private void buttonUpdateServiceType_Click(object sender, EventArgs e)
        {
            if (buttonAddServiceType.Tag == null) return;

            var serviceId = (int)buttonAddServiceType.Tag;
            var service = _context.ServiceTypes.Find(serviceId);
            if (service != null && !string.IsNullOrWhiteSpace(textBoxServiceName.Text) &&
                decimal.TryParse(textBoxServicePrice.Text, out decimal price) && price > 0)
            {
                service.Name = textBoxServiceName.Text.Trim();
                service.Price = price;
                _context.SaveChanges();
                ClearFields();
                LoadServiceTypes();
                DataChanged?.Invoke();
                MessageBox.Show("Услуга обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields()
        {
            textBoxServiceName.Clear();
            textBoxServicePrice.Clear();
            buttonAddServiceType.Text = "Добавить";
            buttonAddServiceType.Tag = null;
        }

        public void RefreshData() => LoadServiceTypes();

        public void UpdateLocalization()
        {
            labelServiceName.Text = Localization.GetString("ServiceName");
            labelServicePrice.Text = Localization.GetString("Price");
            buttonAddServiceType.Text = buttonAddServiceType.Tag == null ? Localization.GetString("Add") : Localization.GetString("Update");
            buttonEditServiceType.Text = Localization.GetString("Edit");
            buttonDeleteServiceType.Text = Localization.GetString("Delete");
        }
    }
}