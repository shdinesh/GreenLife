namespace GreenLifeOS.Repository
{
    internal interface IUserRepository
    {
        User findUserByUsername(string username);
        User GetUserById(int id);
        bool DeleteUser(int id);

    }
}
