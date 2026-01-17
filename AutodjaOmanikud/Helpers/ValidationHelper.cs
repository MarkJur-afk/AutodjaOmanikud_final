using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AutodjaOmanikud.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            
            try
            {
                var emailAttribute = new EmailAddressAttribute();
                return emailAttribute.IsValid(email);
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            
            var phoneRegex = new Regex(@"^[\+]?[0-9\s\-\(\)]{7,20}$");
            return phoneRegex.IsMatch(phone);
        }

        public static bool IsValidRegistrationNumber(string regNumber)
        {
            if (string.IsNullOrWhiteSpace(regNumber)) return false;
            
            var regNumberRegex = new Regex(@"^[A-Z0-9\-\s]{3,15}$", RegexOptions.IgnoreCase);
            return regNumberRegex.IsMatch(regNumber);
        }

        public static string FormatCurrency(decimal amount)
        {
            return $"€{amount:F2}";
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("dd.MM.yyyy HH:mm");
        }

        public static List<ValidationResult> ValidateObject(object obj)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(obj);
            Validator.TryValidateObject(obj, context, results, true);
            return results;
        }
    }
}