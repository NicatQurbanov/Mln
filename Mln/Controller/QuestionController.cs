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
            int indexQ = 0;
            int indexA = 0;
            string[] new_questions = new string[questions.Length];
            int[] previousNumbers = new int[questions.Length - 1];
            
            for (int i = 0; i < questions.Length; i++)
            {
                do
                {
                    indexA = random.Next(questions.Length - 1);
                    new_questions[i] = questions[indexA];
                } while (previousNumbers.IndexOf(indexA) != -1);

                previousNumbers[i] = indexA;
            }
            do
            {
                indexQ = random.Next(questions.Length - 1);
            } while (questions[indexQ].hasAsked == true);

            Console.WriteLine($"{questions[indexQ].question}\t~~~~~Current user: {user.nickname}\n" +
                             $" 1. {questions[indexQ].answers[0]}\n" +
                             $" 2. {questions[indexQ].answers[1]}\n" +
                             $" 3. {questions[indexQ].answers[2]}\n" +
                             $" 4. {questions[indexQ].answers[3]}\n");

            questions[index].hasAsked = true;
            return questions[index];
        }

        public bool CheckUserInput(int input)
        {
            return (input <= 4 && input > 0) ? true : false;
        }

        public void CheckAnswer(Question question)
        {
            int answer = 0;
            do
            {
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out answer);

                if (CheckUserInput(answer))
                {
                    if (question.rightAnswer == answer)
                    {
                        user.points++;
                        Console.WriteLine($"Right!\n" +
                                          $"Current points: {user.points}");
                    }
                    else
                    {
                        user.lives--;
                        Console.WriteLine("Wrong!");
                        if (user.lives == 0)
                        {
                            Console.WriteLine("You lose!");
                            Console.ReadLine();
                        }
                    }
                }
                else
                    Console.WriteLine("Invalid input. Choose between 1 and 4.");
            } while (!CheckUserInput(answer));
            
        }

        public void ShowHistory()
        {
            Console.WriteLine(this.user.points);
        }
    }
}
