namespace GreenLifeOS.Validation.Request
{
    internal class CustomerRegistrationRequest
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }     // optional
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }      // optional
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

}
