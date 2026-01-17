using System.Globalization;

namespace AutodjaOmanikud
{
    public static class Localization
    {
        private static string _currentLanguage = "ru";

        public static string CurrentLanguage
        {
            get => _currentLanguage;
            set => _currentLanguage = value;
        }

        public static string GetString(string key)
        {
            return _currentLanguage switch
            {
                "et" => GetEstonian(key),
                "ru" => GetRussian(key),
                _ => GetRussian(key)
            };
        }

        private static string GetRussian(string key)
        {
            return key switch
            {
                "AppTitle" => "🚗 АВТОСЕРВИС PRO",
                "Owners" => "👥 Владельцы",
                "Cars" => "🚗 Автомобили", 
                "Services" => "🔧 Обслуживание",
                "ServiceTypes" => "⚙️ Услуги",
                "Statistics" => "Клиенты: {0} | Авто: {1} | Услуги: {2} | Доход: €{3:F2}",
                "Name" => "Имя:",
                "Phone" => "Телефон:",
                "Brand" => "Марка:",
                "Model" => "Модель:",
                "RegNumber" => "Номер:",
                "Owner" => "Владелец:",
                "ServiceName" => "Название:",
                "Price" => "Цена:",
                "Car" => "Автомобиль:",
                "Service" => "Услуга:",
                "Date" => "Дата:",
                "Paid" => "Оплачено",
                "Add" => "Добавить",
                "Edit" => "Изменить",
                "Delete" => "Удалить",
                "Update" => "Обновить",
                "TogglePaid" => "Изменить статус оплаты",
                "Success" => "Успех",
                "Error" => "Ошибка",
                "Confirmation" => "Подтверждение",
                _ => key
            };
        }

        private static string GetEstonian(string key)
        {
            return key switch
            {
                "AppTitle" => "🚗 AUTOHOOLDUS PRO",
                "Owners" => "👥 Omanikud",
                "Cars" => "🚗 Autod",
                "Services" => "🔧 Hooldus",
                "ServiceTypes" => "⚙️ Teenused",
                "Statistics" => "Omanikud: {0} | Autod: {1} | Teenused: {2} | Tulu: €{3:F2}",
                "Name" => "Nimi:",
                "Phone" => "Telefon:",
                "Brand" => "Mark:",
                "Model" => "Mudel:",
                "RegNumber" => "Number:",
                "Owner" => "Omanik:",
                "ServiceName" => "Teenuse nimi:",
                "Price" => "Hind:",
                "Car" => "Auto:",
                "Service" => "Teenus:",
                "Date" => "Kuupäev:",
                "Paid" => "Makstud",
                "Add" => "Lisa",
                "Edit" => "Muuda",
                "Delete" => "Kustuta",
                "Update" => "Uuenda",
                "TogglePaid" => "Muuda maksestaatust",
                "Success" => "Õnnestus",
                "Error" => "Viga",
                "Confirmation" => "Kinnitus",
                _ => key
            };
        }
    }
}