using System;
using System.Collections.Generic;
using System.Text;

namespace Mln.Model
{
    public class User
    {
        public string nickname, password;
        public bool isAdmin = false;
        public int points = 0;
        public int lives = 2;

        public User(string nickname, string password)
        {
          this.nickname = nickname;
          this.password = password;
        }
    }
}
