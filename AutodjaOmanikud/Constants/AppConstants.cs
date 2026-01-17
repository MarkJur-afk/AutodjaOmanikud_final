namespace AutodjaOmanikud.Constants
{
    public static class AppConstants
    {
        public const string AppTitle = "🚗 Система управления автомобилями";
        public const string DatabaseName = "AutoDatabase.db";
        
        public static class Messages
        {
            public const string SuccessAdd = "✅ Успешно добавлено!";
            public const string SuccessUpdate = "✅ Успешно обновлено!";
            public const string SuccessDelete = "✅ Успешно удалено!";
            public const string ErrorGeneral = "❌ Произошла ошибка!";
            public const string ErrorValidation = "⚠️ Проверьте введённые данные!";
            public const string ConfirmDelete = "❓ Вы уверены, что хотите удалить?";
        }

        public static class Validation
        {
            public const int MaxStringLength = 100;
            public const int MaxPhoneLength = 20;
            public const int MaxRegNumberLength = 15;
            public const decimal MinPrice = 0.01m;
            public const decimal MaxPrice = 999999.99m;
        }

        public static class UI
        {
            public const int GridRowHeight = 25;
            public const int FormPadding = 20;
            public const int ControlSpacing = 10;
        }
    }
}