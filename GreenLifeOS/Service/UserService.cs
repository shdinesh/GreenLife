using GreenLifeOS.Repository;
using System;

namespace GreenLifeOS.Service
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public UserService() : this(new UserRepository())
        {
        }




        public User findUserByUsername(string username)
        {
            try
            {
                var user = userRepository.findUserByUsername(username);
                return user;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the supplier. Please try again.", ex);
            }
        }

        


        private ValidationResult ValidateSupplier(Supplier supplier)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }

    


}
