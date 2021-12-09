using Kursach_3_Sem.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Controller
{
    public class UserController
    {
        public User user { get; private set; }

        public UserController() { }

        public UserController(string login,string password)
        {
            user = new User(login, password);
        }

        public string GetUserName()
        {
            return user.data.login;
        }

        public bool IsUserExists(string login)
        {
            foreach (var user in Data.users)
            {
                if (user.data.login == login)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsRightUser(string login, string password)
        {
            foreach (var user in Data.users)
            {
                if (user.data.login == login && user.data.password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddUser(string login, string password)
        {
            Data.users.Add(new User(login, password));
        }
    }
}
