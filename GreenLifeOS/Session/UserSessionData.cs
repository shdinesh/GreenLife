using System;

namespace GreenLifeOS.Session
{
    internal class UserSessionData
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }   // ADMIN / CUSTOMER
        public int? CustomerId { get; set; }
        public int? AdminId { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
