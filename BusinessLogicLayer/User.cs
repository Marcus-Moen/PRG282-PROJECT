using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BusinessLogicLayer
{
    internal class User
    {
        string Username;
        string Password;
        public User(string user,string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
        public string Users
        {
            get { return this.Username; }
            set { this.Username = value; }
        }
        public string Pass
        {
            get { return this.Password; }
            set { this.Password = value; }
        }
    }
}
