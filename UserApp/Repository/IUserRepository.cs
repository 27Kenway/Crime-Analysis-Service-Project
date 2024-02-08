using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Model;

namespace UserApp.Repository
{
    internal interface IUserRepository
    {
        List<User> GetAllUsers();
        int RegisterUser(User user);
    }
}
