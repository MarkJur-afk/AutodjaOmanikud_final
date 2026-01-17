using AutodjaOmanikud.Data;
using AutodjaOmanikud.Models;
using Microsoft.EntityFrameworkCore;

namespace AutodjaOmanikud.Controls
{
    public partial class CarControl : UserControl
    {
        private AutoDbContext _context;
        public event Action DataChanged;

        public CarControl()
        {
            InitializeComponent();
            _context = new AutoDbContext();
            LoadData();
        }

        private void LoadData()
        {
            LoadCars();
            LoadOwners();
        }

        private void LoadCars()
        {
            var cars = _context.Cars.Include(c => c.Owner).ToList();
            dataGridViewCars.DataSource = cars.Select(c => new
            {
                c.Id,
                Марка = c.Brand,
                Модель = c.Model,
                Номер = c.RegistrationNumber,
                Владелец = c.Owner.FullName
            }).ToList();
        }

        private void LoadOwners()
        {
            var owners = _context.Owners.ToList();
            comboBoxCarOwner.DataSource = owners;
            comboBoxCarOwner.DisplayMember = "FullName";
            comboBoxCarOwner.ValueMember = "Id";
            comboBoxCarOwner.SelectedIndex = -1;
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            if (comboBoxCarOwner.SelectedValue == null ||
                string.IsNullOrWhiteSpace(textBoxCarBrand.Text) ||
                string.IsNullOrWhiteSpace(textBoxCarModel.Text) ||
                string.IsNullOrWhiteSpace(textBoxCarRegistration.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var car = new Car
            {
                Brand = textBoxCarBrand.Text.Trim(),
                Model = textBoxCarModel.Text.Trim(),
                RegistrationNumber = textBoxCarRegistration.Text.Trim(),
                OwnerId = (int)comboBoxCarOwner.SelectedValue
            };

            _context.Cars.Add(car);
            _context.SaveChanges();
            ClearFields();
            LoadCars();
            DataChanged?.Invoke();
            MessageBox.Show($"Автомобиль '{car.Brand} {car.Model}' добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count == 0) return;

            var carReg = dataGridViewCars.SelectedRows[0].Cells["Номер"].Value.ToString();
            if (MessageBox.Show($"Удалить автомобиль '{carReg}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var carId = (int)dataGridViewCars.SelectedRows[0].Cells["Id"].Value;
                var car = _context.Cars.Find(carId);
                if (car != null)
                {
                    _context.Cars.Remove(car);
                    _context.SaveChanges();
                    LoadCars();
                    DataChanged?.Invoke();
                    MessageBox.Show("Автомобиль удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearFields()
        {
            textBoxCarBrand.Clear();
            textBoxCarModel.Clear();
            textBoxCarRegistration.Clear();
            comboBoxCarOwner.SelectedIndex = -1;
        }

        public void RefreshData() => LoadData();

        public void UpdateLocalization()
        {
            labelCarBrand.Text = Localization.GetString("Brand");
            labelCarModel.Text = Localization.GetString("Model");
            labelCarRegistration.Text = Localization.GetString("RegNumber");
            labelCarOwner.Text = Localization.GetString("Owner");
            buttonAddCar.Text = Localization.GetString("Add");
            buttonDeleteCar.Text = Localization.GetString("Delete");
        }
    }
}