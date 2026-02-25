using GreenLifeOS.Validation.Request;
using System;

namespace GreenLifeOS.Validation
{
    internal class UserRegistrationValidator
    {
        public ValidationResult Validate(CustomerRegistrationRequest r)
        {
            // Mandatory fields
            if (!Validator.IsRequired(r.Title))
                return ValidationResult.Fail("Title", "Title is required.");

            if (!Validator.IsRequired(r.FirstName))
                return ValidationResult.Fail("FirstName", "First name is required.");

            if (!Validator.IsRequired(r.Email))
                return ValidationResult.Fail("Email", "Email is required.");

            if (!Validator.IsRequired(r.PhoneNumber))
                return ValidationResult.Fail("PhoneNumber", "Phone number is required.");

            if (!Validator.IsRequired(r.Username))
                return ValidationResult.Fail("Username", "Username is required.");

            if (!Validator.IsRequired(r.Password))
                return ValidationResult.Fail("Password", "Password is required.");

            if (!Validator.IsRequired(r.ConfirmPassword))
                return ValidationResult.Fail("ConfirmPassword", "Confirm password is required.");

            // Max lengths
            if (!Validator.MaxLen(r.FirstName, 100))
                return ValidationResult.Fail("FirstName", "First name max length is 100.");

            if (!Validator.MaxLen(r.Address, 200))
                return ValidationResult.Fail("Address", "Address max length is 200.");

            if (!Validator.MaxLen(r.Email, 100))
                return ValidationResult.Fail("Email", "Email max length is 100.");

            // Email format
            if (!Validator.Email(r.Email))
                return ValidationResult.Fail("Email", "Invalid email format.");

            // Phone rules
            if (!Validator.Phone(r.PhoneNumber, 10, 16))
                return ValidationResult.Fail("PhoneNumber", "Phone must be digits only and length between 10-16.");

            // Username min length
            if (!Validator.MinLen(r.Username, 8))
                return ValidationResult.Fail("Username", "Username must be at least 8 characters.");

            // Password min length
            if (!Validator.MinLen(r.Password, 8))
                return ValidationResult.Fail("Password", "Password must be at least 8 characters.");

            // Password match
            if (!string.Equals(r.Password, r.ConfirmPassword, StringComparison.Ordinal))
                return ValidationResult.Fail("ConfirmPassword", "Password and Confirm Password must match.");

            return ValidationResult.Success();
        }

    }
}
