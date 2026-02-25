namespace GreenLifeOS
{
    public class CustomerVo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}".Trim();

            }
            set {
                FirstName = value;
            }
        }


    }
}
