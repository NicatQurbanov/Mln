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
        public string[] questionsHistory;
        
        public QuestionController(User user) 
        {
            questions = new Question[1];
            this.user = user;
        }

        public void ProcessInput(string input)
        {
            string[] processedInput = input.Split(",");
        }

        public void AddQuestion(string questionName, string[][] questionValue)
        {
            questions[questions.Length - 1] = new Question(questionName, questionValue);
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
          public void ProcessQuestionData(string? new_questionRead, string? new_answerRead, string? new_rightAnswerRead)
  {

      Console.WriteLine("Enter question:");
      new_questionRead = Console.ReadLine();
      
      Console.WriteLine("Enter answers separated by comma (,)");
      new_answerRead = Console.ReadLine();

      Console.WriteLine("Enter an index of the right answer:");
      new_rightAnswerRead = Console.ReadLine();

      if (new_questionRead != null && new_answerRead != null && new_rightAnswerRead != null)
      {
          if (Regex.IsMatch(new_questionRead, "^[A-Z][^?]*\\?$"))
          {

          }
          string[] allAnswers = new_answerRead.Split(",");
          string[][] new_answer = new string[[
              "",
              "",
              "",
              "",
              ],
              [""]];

          for(int i = 0; i < new_answer[0].Length; i++)
          {
              new_answer[0][i] = allAnswers[i];
          }

          int.TryParse(new_rightAnswerRead, out int rightIndex);
          new_answer[0][0] = new_answerRead[0][rightIndex];
      }
  }

        
        public Question GetRandomQuestion()
        {
            Random random = new();
            int indexQ = 0;
            int indexA = 0;
            int index = 0;
            string[] new_questions = new string[questions.Length];
            int[] previousNumbers = new int[questions.Length - 1];
            bool allAsked = true;
           
            
            do
            {
                indexQ = random.Next(questions.Length - 1);
            } while (questions[indexQ].hasAsked == true);

            questions[indexQ].hasAsked = true;

            for(int i = 0; i < questions.Length; i++)
            {
                if (!questions[i].hasAsked)
                {
                    allAsked = false;
                    break;
                }
            }
                

            if (allAsked == false)
            {
                Console.WriteLine($"{questions[indexQ].question}\t~~~~~Current user: {user.nickname}\n");

                for (int i = 0; i < previousNumbers.Length; i++)
                    previousNumbers[i] = -1;

                do
                {
                    do
                    {
                        indexA = random.Next(4);
                    } while (previousNumbers.Contains(indexA));

                    previousNumbers[index] = indexA;
                    index++;
                    Console.WriteLine($" {index}. {questions[indexQ].answers[0][indexA]}\n");
                } while (index != 4);

                return questions[indexQ];
            }
            else
            {
                Console.WriteLine("All questions have been asked.");
                return null;
            }
                
        }
        public bool CheckUserInput(int input)
        {
            return (input <= 4 && input > 0) ? true : false;
        }

        //public void CheckAnswer(Question question)
        //{
        //    int answer = 0;
        //    int index = 0;
        //    questionsHistory = new string[questions.Length];
        //    SetTimer();
        //    do {
        //    do
        //    {
        //        string userInput = Console.ReadLine();
        //        int.TryParse(userInput, out answer);

        //        if (CheckUserInput(answer))
        //        {
        //            if (question.answers[1][0] == answer)
        //            {
        //                user.points++;
        //                question.answeredCorrectly = true;
        //                Console.WriteLine($"Right!\n" +
        //                                  $"Current points: {user.points}");
        //            }
        //            else
        //            {
        //                user.lives--;
        //                Console.WriteLine("Wrong!");
        //                if (user.lives == 0)
        //                {
        //                    Console.WriteLine("You lose!");
        //                    Console.ReadLine();
        //                }
        //            }
        //            questionHistory[index] = question;
        //            index++;
        //        }
        //        else
        //            Console.WriteLine("Invalid input. Choose between 1 and 4.");
        //    } while (!CheckUserInput(answer));
        // } while (TimernotElapsed);   
        //}

        public void ShowHistory()
        {
            foreach(Question question in questionsHistory)
            {
              Console.WriteLine(question.queston);
                if (question.answeredCorrectly)
                    Console.WriteLine("right);
                else
                    Console.WriteLine("wrong");
            }
            
        }
    }
}
