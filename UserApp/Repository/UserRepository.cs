using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Exceptions;
using UserApp.Model;
using UserApp.Utility;

namespace UserApp.Repository
{
    internal class UserRepository : IUserRepository
    {
        public string connectionString;
        //sql connection class
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public UserRepository()
        {
            //sqlconnection = new SqlConnection("Server=DESKTOP-0TE71RT;Database=UserDb;Trusted_Connection=True");
            //sqlconnection = new SqlConnection(DbConnUtil.GetConnectionString());
            connectionString=DbConnUtil.GetConnectionString();
            cmd = new SqlCommand();
        }

        #region Code with List
        //List<User> users = new List<User>() {new User { Id=1,Email="user1@gmail.com",Password="user1"},
        //                                     new User { Id=2,Email="user2@gmail.com",Password="user2"} };
        //public bool RegisterUser(User user)
        //{
        //    //check whether user exists in the list
        //    User userExists = GetUserByEmail(user.Email);
        //    if(userExists == null)
        //    {
        //        users.Add(user);
        //        return true;
        //    }
        //    else
        //    {
        //        throw new UserAlreadyExistsException($"{user.Email} Already Exists");
        //    } 

        //}

        //private User GetUserByEmail(string email)
        //{
        //   return users.Find(u => u.Email == email);
        //}
        #endregion
        public List<User> GetAllUsers()
        {
            #region Code without usingBlock
            //List<User>userList=new List<User>();
            //cmd.CommandText = "select * from Users";
            //cmd.Connection = sqlconnection;
            //sqlconnection.Open();
            //SqlDataReader reader = cmd.ExecuteReader();  
            //while (reader.Read())
            //{
            //    User user= new User();
            //    user.Id = (int)reader["Id"];
            //    user.Email = (string)reader["Email"];
            //    user.Password = (string)reader["Password"];
            //    userList.Add(user);
            //}
            //sqlconnection.Close();
            //return userList;
            #endregion
            List<User> userList = new List<User>();
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select * from Users";
                    cmd.Connection = sqlconnection;
                    sqlconnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = (int)reader["Id"];
                        user.Email = (string)reader["Email"];
                        user.Password = (string)reader["Password"];
                        userList.Add(user);
                    }
                   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userList;
        }
        public int RegisterUser(User user)
        {
            cmd.CommandText = "insert into Users values(@Id,@Email,@Password)";
            cmd.Parameters.AddWithValue("@Id",user.Id);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Connection = sqlconnection;
            sqlconnection.Open();
            int addUserStatus=cmd.ExecuteNonQuery();
            sqlconnection.Close();
            return addUserStatus;


        }
    }
}
