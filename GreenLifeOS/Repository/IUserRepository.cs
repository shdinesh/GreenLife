namespace GreenLifeOS.Repository
{
    internal interface IUserRepository
    {
        User findUserByUsername(string username);
    }
}
