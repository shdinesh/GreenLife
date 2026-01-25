using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IUserService
    {
        User findUserByUsername(string username);

    }
}
