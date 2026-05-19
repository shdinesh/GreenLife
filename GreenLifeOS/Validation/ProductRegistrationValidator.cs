using GreenLifeOS.Validation.Request;

namespace GreenLifeOS.Validation
{
    internal class ProductRegistrationValidator
    {
        public ValidationResult Validate(ProductRegistrationRequest r)
        {
            if (!Validator.IsRequired(r.Name))
                return ValidationResult.Fail("Product Name", "Product Name is required.");
           
            if (!Validator.MaxLen(r.Name, 200))
                return ValidationResult.Fail("Product Name", "Product Name cannot exceed 200 charactors.");
           
            if (!Validator.MinLen(r.Name, 8))
                return ValidationResult.Fail("Product Name", "Product Name must be atleast 8 characters.");

            if (!Validator.IsRequired(r.Code))
                return ValidationResult.Fail("Product Code", "Product Code is required.");
           
            if (!Validator.MaxLen(r.Code, 20))
                return ValidationResult.Fail("Product Code", "Product Code cannot exceed 20 charactors.");
            
            if (!Validator.MinLen(r.Code, 8))
                return ValidationResult.Fail("Product Code", "Product Code must be atleast 8 characters.");

            if (!Validator.IsRequired(r.CategoryId.ToString()))
                return ValidationResult.Fail("Product Category", "Product Category is required.");

            if (!Validator.IsRequired(r.SellingPrice.ToString()))
                return ValidationResult.Fail("Selling Price", "Selling Price is required.");
           
            if (!Validator.IsValidNumber(r.SellingPrice.ToString()))
                return ValidationResult.Fail("Selling Price", "Selling Price must be a valid number.");

            if (!Validator.IsValidNumber(r.Discount.ToString()))
                return ValidationResult.Fail("Dicount", "Dicount amount must be a valid number.");

            if (!Validator.IsValidImage(r.Photo.ToString()))
                return ValidationResult.Fail("Product Photo", "Product Photo is in invalid format.");

            return ValidationResult.Success();
        }

    }
}
