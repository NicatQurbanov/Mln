using System;
using System.Collections.Generic;
using System.Text;

namespace Mln.Model
{
    public class Question
    {
        public string question;
        public string[][] answers;
        public bool hasAsked = false;
        public bool answeredCorrectly;
       

       


        public Question(string question, string[][] answers)
        {
            this.question = question;
            this.answers = answers;
        }

    }
}
