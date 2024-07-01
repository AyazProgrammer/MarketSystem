using MarketManageSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem
{
    internal class User:BaseUser
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public string Email { get; set; }

        public int UserId { get; set; } = 0;
        public string UserName { get; set; }

        public string Password { get; set; }

        public string  Role { get; set; }
    }
}
