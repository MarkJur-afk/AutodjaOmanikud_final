using AutodjaOmanikud.Data;
using AutodjaOmanikud.Models;
using Microsoft.EntityFrameworkCore;

namespace AutodjaOmanikud.Controls
{
    public partial class OwnerControl : UserControl
    {
        private AutoDbContext _context;
        public event Action DataChanged;

        public OwnerControl()
        {
            InitializeComponent();
            _context = new AutoDbContext();
            LoadOwners();
        }

        private void LoadOwners()
        {
            var owners = _context.Owners.Include(o => o.Cars).ToList();
            dataGridViewOwners.DataSource = owners.Select(o => new
            {
                o.Id,
                Имя = o.FullName,
                Телефон = o.Phone,
                Автомобили = string.Join(", ", o.Cars.Select(c => $"{c.Brand} {c.Model}")),
                КоличествоАвто = o.Cars.Count
            }).ToList();
        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            if (buttonAddOwner.Tag != null) // Режим обновления
            {
                var ownerId = (int)buttonAddOwner.Tag;
                var owner = _context.Owners.Find(ownerId);
                if (owner != null && !string.IsNullOrWhiteSpace(textBoxOwnerName.Text))
                {
                    owner.FullName = textBoxOwnerName.Text.Trim();
                    owner.Phone = textBoxOwnerPhone.Text.Trim();
                    _context.SaveChanges();
                    ClearFields();
                    LoadOwners();
                    DataChanged?.Invoke();
                    MessageBox.Show("Владелец обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxOwnerName.Text)) return;

            var newOwner = new Owner
            {
                FullName = textBoxOwnerName.Text.Trim(),
                Phone = textBoxOwnerPhone.Text.Trim()
            };

            _context.Owners.Add(newOwner);
            _context.SaveChanges();
            ClearFields();
            LoadOwners();
            DataChanged?.Invoke();
            MessageBox.Show($"Владелец '{newOwner.FullName}' добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeleteOwner_Click(object sender, EventArgs e)
        {
            if (dataGridViewOwners.SelectedRows.Count == 0) return;

            var ownerName = dataGridViewOwners.SelectedRows[0].Cells["Имя"].Value.ToString();
            if (MessageBox.Show($"Удалить владельца '{ownerName}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var ownerId = (int)dataGridViewOwners.SelectedRows[0].Cells["Id"].Value;
                var owner = _context.Owners.Include(o => o.Cars).First(o => o.Id == ownerId);
                
                _context.Cars.RemoveRange(owner.Cars);
                _context.Owners.Remove(owner);
                _context.SaveChanges();
                LoadOwners();
                DataChanged?.Invoke();
                MessageBox.Show("Владелец удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields()
        {
            textBoxOwnerName.Clear();
            textBoxOwnerPhone.Clear();
            buttonAddOwner.Text = "Добавить";
            buttonAddOwner.Tag = null;
        }

        private void buttonEditOwner_Click(object sender, EventArgs e)
        {
            if (dataGridViewOwners.SelectedRows.Count == 0) return;

            var ownerId = (int)dataGridViewOwners.SelectedRows[0].Cells["Id"].Value;
            var owner = _context.Owners.Find(ownerId);
            if (owner != null)
            {
                textBoxOwnerName.Text = owner.FullName;
                textBoxOwnerPhone.Text = owner.Phone;
                buttonAddOwner.Text = "Обновить";
                buttonAddOwner.Tag = ownerId;
            }
        }

        public void RefreshData() => LoadOwners();

        public void UpdateLocalization()
        {
            labelOwnerName.Text = Localization.GetString("Name");
            labelOwnerPhone.Text = Localization.GetString("Phone");
            buttonAddOwner.Text = buttonAddOwner.Tag == null ? Localization.GetString("Add") : Localization.GetString("Update");
            buttonEditOwner.Text = Localization.GetString("Edit");
            buttonDeleteOwner.Text = Localization.GetString("Delete");
        }
    }
}