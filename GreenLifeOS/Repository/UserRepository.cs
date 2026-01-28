using System;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        // Dependency injection-friendly constructor
        public UserRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        // Parameterless constructor for backward compatibility
        public UserRepository() : this(new GreenLifeDBContext())
        {
        }

        public User findUserByUsername(string username)
        {
            return this.dbContext.Users
                .FirstOrDefault(s => s.UserName == username);
        }

        public bool DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user == null)
                throw new ArgumentException($"User with ID {id} not found.", nameof(id));

            this.dbContext.Users.Remove(user);
            this.dbContext.SaveChanges();
            return true;
        }

        public User GetUserById(int id)
        {
            return this.dbContext.Users
                .FirstOrDefault(s => s.Id == id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                this.dbContext?.Dispose();
            }
            disposed = true;
        }
    }


}
