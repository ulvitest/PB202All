using MiniApp.Interfaces;
using MiniApp.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Models
{
    internal class User : IEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        static int _id;
        public int Id { get; set; }
       
        public User(string userName, string email, Role role)
        {
            _id++;
            Id = _id;
            UserName = userName;
            Email = email;
            Role = role;
        }
    }
}
