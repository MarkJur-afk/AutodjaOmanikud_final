using AutodjaOmanikud.Constants;

namespace AutodjaOmanikud.Helpers
{
    public static class ExceptionHandler
    {
        public static void HandleException(Exception ex, string context = "")
        {
            var message = GetUserFriendlyMessage(ex);
            var fullMessage = string.IsNullOrEmpty(context) 
                ? message 
                : $"{context}: {message}";

            MessageBox.Show(fullMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            // Логирование (можно добавить файловое логирование)
            System.Diagnostics.Debug.WriteLine($"[ERROR] {DateTime.Now}: {ex}");
        }

        private static string GetUserFriendlyMessage(Exception ex)
        {
            return ex switch
            {
                ArgumentException => "Неверные данные",
                InvalidOperationException => ex.Message,
                UnauthorizedAccessException => "Нет доступа к операции",
                TimeoutException => "Превышено время ожидания",
                System.Data.Common.DbException => "Ошибка базы данных",
                _ => AppConstants.Messages.ErrorGeneral
            };
        }

        public static async Task<T?> SafeExecuteAsync<T>(Func<Task<T>> operation, string context = "")
        {
            try
            {
                return await operation();
            }
            catch (Exception ex)
            {
                HandleException(ex, context);
                return default;
            }
        }

        public static async Task SafeExecuteAsync(Func<Task> operation, string context = "")
        {
            try
            {
                await operation();
            }
            catch (Exception ex)
            {
                HandleException(ex, context);
            }
        }
    }
}