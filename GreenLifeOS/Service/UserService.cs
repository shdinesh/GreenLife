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

        public bool DeleteUser(int id)
        {
            try
            {
                var existingUser = GetUserById(id);
                if (existingUser == null)
                    throw new ArgumentException($"User with ID {id} not found.", nameof(id));

                var result = userRepository.DeleteUser(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the user. Please try again.", ex);
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                var user = userRepository.GetUserById(id);

                if (user == null)
                    throw new ArgumentException($"Customer with ID {id} not found.", nameof(id));

                return user;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the Customer. Please try again.", ex);
            }
        }

        private ValidationResult ValidateSupplier(Supplier supplier)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }




}
