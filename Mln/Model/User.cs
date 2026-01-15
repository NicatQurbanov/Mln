using System;
using System.Collections.Generic;
using System.Text;

namespace Mln.Model
{
    public class User
    {
        public string nickname;
        public bool isAdmin = false;
        public int points = 0;
        public int lives = 2;

        public User(string nickname, int points)
        {
          this.nickname = nickname;
          this.points = points;
        }
    }
}
