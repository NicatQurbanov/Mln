using Mln.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mln.Controller
{
   public class UserController
    {
        public User[] users;
        public UserController()
        {
            users = new User[1];
        }

        public void AddUser(string nickname, string password)
        {
            users[users.Length - 1] = new User(nickname, password);
            Array.Resize(ref users, users.Length + 1);
        }

        public void AddUser(User user)
        {
            users[users.Length - 1] = user;
            Array.Resize(ref users, users.Length + 1);
        }
    }
}
