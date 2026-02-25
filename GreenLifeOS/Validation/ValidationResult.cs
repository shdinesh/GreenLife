using System.Text.RegularExpressions;

namespace GreenLifeOS.Validation
{
    internal class ValidationResult
    {
        public bool IsValid { get; private set; }
        public string FieldKey { get; private set; }   // e.g., "Email", "Phone"
        public string Message { get; private set; }

        private ValidationResult(bool isValid, string fieldKey, string message)
        {
            IsValid = isValid;
            FieldKey = fieldKey;
            Message = message;
        }

        public static ValidationResult Success()
        {
            return new ValidationResult(true, null, null);
        }

        public static ValidationResult Fail(string fieldKey, string message)
        {
            return new ValidationResult(false, fieldKey, message);
        }
    }


}
