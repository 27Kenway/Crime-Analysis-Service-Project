using UserApp;
using UserApp.Exceptions;
using UserApp.Model;
using UserApp.Repository;
using UserApp.Service;
#region old code with Repo
//IUserRepository userRepository=new UserRepository();

//  User user = new User() { Id = 3, Email = "user1@gmail.com", Password = "user3" };
//  try
//  {
//      bool addUserStatus = userRepository.RegisterUser(user);
//      if (addUserStatus)
//      {
//          Console.WriteLine("Registration success");
//      }
//  }
//  catch (UserAlreadyExistsException uaex)
//  {
//      Console.WriteLine(uaex.Message);
//  }


//else
//{
//    Console.WriteLine("user alreday exists");
//}
#endregion
IUserService userService = new UserService();
userService.RegisterUser();
userService.GetAllUsers();

