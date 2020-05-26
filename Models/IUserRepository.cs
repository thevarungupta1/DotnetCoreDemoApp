using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreDemoApp.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);        
    }
}
