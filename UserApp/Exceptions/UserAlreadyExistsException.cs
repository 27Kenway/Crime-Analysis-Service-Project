using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Exceptions
{
    internal class UserAlreadyExistsException:ApplicationException
    {
        //create constructors
        public UserAlreadyExistsException()
        {
            
        }
        public UserAlreadyExistsException(string msg):base(msg) 
        {
            
        }
    }
}
