using System;

namespace GreenLifeOS.Session
{
    internal class AppSession
    {
        public static UserSessionData CurrentUser { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static void Start(UserSessionData user)
        {
            CurrentUser = user ?? throw new ArgumentNullException(nameof(user));
        }

        public static void End()
        {
            CurrentUser = null;
        }
    }
}
