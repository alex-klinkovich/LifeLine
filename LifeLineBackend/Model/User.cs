using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : Base
    {
        private string username;
        private string password;
        
        public string Username { get => username; set => username = value; }
        
        public string Password { get => password; set => password = value; }
        
    }
}
