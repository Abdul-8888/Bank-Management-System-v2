using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.BL
{
    public class Credential
    {
        protected string username;
        protected string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public Credential(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
