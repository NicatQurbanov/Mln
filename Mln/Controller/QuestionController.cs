using Mln.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace Mln.Controller
{
    public class QuestionController
    {
        public Question[] questions;
        public User user;

        public QuestionController(User user) 
        {
            questions = new Question[1];
            this.user = user;
        }

        public void ProcessInput(string input)
        {
            string[] processedInput = input.Split(",");
        }

        public void AddQuestion(string questionName, string[] questionValue, int rightAnswer)
        {
            questions[questions.Length - 1] = new Question(questionName, questionValue, rightAnswer);
            Array.Resize(ref questions, questions.Length + 1);
        }

        public void AddQuestion(Question question)
        {
            questions[questions.Length - 1] = question;
            Array.Resize(ref questions, questions.Length + 1);
        }

        //public void AddQuestion(string input)
        //{
        //    questions[questions.Length - 1] = question;
        //    Array.Resize(ref questions, questions.Length + 1);
        //}

        public Question GetRandomQuestion()
        {
            Random random = new();
            int index = random.Next(questions.Length - 1);
            Console.WriteLine($"{questions[index].question}\t~~~~~Current user: {user.nickname}\n" +
                              $" 1. {questions[index].answers[0]}\n"+
                              $" 2. {questions[index].answers[1]}\n"+
                              $" 3. {questions[index].answers[2]}\n"+
                              $" 4. {questions[index].answers[3]}\n");

            return questions[index];
        }

        public void CheckAnswer(Question question, string input)
        {
            
            int.TryParse(input, out int answer);
            if (question.rightAnswer == answer)
            {
                user.points++;
                Console.Clear();
                Console.WriteLine($"Right!\n" +
                                  $"Current points: {user.points}");
            }
            else
            {
                user.lives--;
                Console.Clear();
                Console.WriteLine("Wrong!");
                if (user.lives == 0 )
                {
                    Console.Clear();
                    Console.WriteLine("You lose!");
                }
            }
               
        }
    }
}
