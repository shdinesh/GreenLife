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
