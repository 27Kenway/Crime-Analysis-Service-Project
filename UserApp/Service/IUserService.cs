using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Service
{
    internal interface IUserService
    {
        void RegisterUser();
        void GetAllUsers();
    }
}
