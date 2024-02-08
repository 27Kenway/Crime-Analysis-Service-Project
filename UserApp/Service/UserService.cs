using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Exceptions;
using UserApp.Model;
using UserApp.Repository;

namespace UserApp.Service
{
    internal class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        //constructor
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void GetAllUsers()
        {
          List<User> allUsers = _userRepository.GetAllUsers();
            foreach (User user in allUsers)
            {
                Console.WriteLine(user);
            }
        }

        public void RegisterUser()
        {
            //User user = new User() { Id = 3, Email = "user1@gmail.com", Password = "user3" };
            User user = new User();
            Console.WriteLine("Enter UserId::");
            user.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter UserEmail::");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter Userpwd::");
            user.Password = Console.ReadLine();
            try
            {
                int addUserStatus = _userRepository.RegisterUser(user);
                if (addUserStatus>0)
                {
                    Console.WriteLine("Registration success");
                }
            }
            catch (UserAlreadyExistsException uaex)
            {
                Console.WriteLine(uaex.Message);
            }
        }
    }
}
