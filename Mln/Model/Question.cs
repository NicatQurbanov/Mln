using System;
using System.Collections.Generic;
using System.Text;

namespace Mln.Model
{
    public class Question
    {
        public string question;
        public string[,] answers;
        public int rightAnswer;
        public bool hasAsked = false;
        
       

       


        public Question(string question, string[,] answers, int rightAnswer)
        {
            this.question = question;
            this.answers = answers;
            this.rightAnswer = rightAnswer;
        }

    }
}
