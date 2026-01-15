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

        public void AddUser(string nickname, int points)
        {
            users[users.Length - 1] = new User(nickname, points);
            Array.Resize(ref users, users.Length + 1);
        }

        public void AddUser(User user)
        {
            users[users.Length - 1] = user;
            Array.Resize(ref users, users.Length + 1);
        }

        public void Welcome()
        {
            Console.WriteLine(" 1. Start a game\n 2. Leaderboard\n 3. History");
        }

        public void ShowLeaderboard()
        {
            Array.Resize(ref users, users.Length - 1);
            Array.Sort(users,(user1, user2) => user1.points.CompareTo(user2.points));
            Array.Reverse(users);

            Console.Clear();
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == null) continue;
                Console.WriteLine($" \n ``````````{i + 1}`````````\n" +
                                  $" Nickname: \t{users[i].nickname}\n" +
                                  $" Points:\t{users[i].points}\n");
            }
        }

        
    }
}
