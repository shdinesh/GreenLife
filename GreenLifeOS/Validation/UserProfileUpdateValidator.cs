using GreenLifeOS.Validation.Request;

namespace GreenLifeOS.Validation
{
    internal class UserProfileUpdateValidator
    {
        public ValidationResult Validate(UserProfileUpdateRequest r)
        {
            // Mandatory fields
            if (!Validator.IsRequired(r.Title))
                return ValidationResult.Fail("Title", "Title is required.");

            if (!Validator.IsRequired(r.FirstName))
                return ValidationResult.Fail("First Name", "First Name is required.");

            // Max lengths
            if (!Validator.MaxLen(r.FirstName, 100))
                return ValidationResult.Fail("First Name", "First Name cannot exceed 100 charactors.");

            if (!Validator.IsRequired(r.Email))
                return ValidationResult.Fail("Email", "Email is required.");

            if (!Validator.MaxLen(r.Email, 100))
                return ValidationResult.Fail("Email", "Email cannot exceed 100 charactors.");

            // Email format
            if (!Validator.Email(r.Email))
                return ValidationResult.Fail("Email", "Invalid email format.");

            if (!Validator.IsRequired(r.PhoneNumber))
                return ValidationResult.Fail("Phone Number", "Phone number is required.");


            // Phone rules
            if (!Validator.Phone(r.PhoneNumber, 10, 16))
                return ValidationResult.Fail("Phone Number", "Phone must be digits only and length between 10-16.");


            if (!Validator.MaxLen(r.Address, 200))
                return ValidationResult.Fail("Address", "Address cannot exceed 200 charactors");


            return ValidationResult.Success();
        }

    }
}
