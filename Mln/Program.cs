using Mln.Controller;
using Mln.Model;

namespace Mln
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserController userController = new UserController();

            User user = new("nicat", 50);
            User user_1 = new("ali", 500);
            User user_2 = new("yusif", 150);

            userController.AddUser(user);
            userController.AddUser(user_1);
            userController.AddUser(user_2);







            string question1Q = "Why are short-lived objects usually cheap in .NET?";
            string[][] question1A =
            [
                ["They are collected in Generation 0, which is fast",
                                "They are never allocated on the heap",
                               "They are automatically stack-allocated",
                               "They bypass the Garbage Collector" ], 
                ["They are collected in Generation 0, which is fast"]
            ];


            string question2Q = "What is the primary purpose of await in C#?";
            string[][] question2A = [["To create a new thread",
                                "To block the current thread",
                                "To release the current thread while waiting",
                                "To speed up CPU-bound operations"],["To release the current thread while waiting"]];


            string question3Q = "Why can IQueryable be dangerous if misused?";
            string[][] question3A = [["It disables deferred execution",
                                "It forces all data into memory",
                                "It cannot be unit tested",
                                "It may execute unexpected database queries"],["It may execute unexpected database queries"]];


            string question4Q = "When is a struct more appropriate than a class?";
            string[][] question4A = [["When the object has complex behavior",
                                "When inheritance is required",
                                "When representing small, immutable data",
                                "When reference sharing is important"],["When representing small, immutable data"]];


            string question5Q = "Why can changing a const value in a library cause bugs in dependent applications?";
            string[][] question5A = [["const values are stored in the database",
                                "const values are inlined at compile time",
                                "readonly values are mutable",
                                "const values require reflection"],["const values are inlined at compile time"]];


            string question6Q = "What primarily determines which CSS rule wins when multiple rules target the same element?";
            string[][] question6A = [["Selector specificity",
                                "The order of properties in the file",
                                "The number of selectors used",
                                "Browser vendor"],["Selector specificity"]];


            string question7Q = "Which CSS layout system is best suited for two-dimensional layouts (rows and columns)?";
            string[][] question7A = [["Float",
                                "Flexbox",
                                "Positioning",
                                "Grid"],["Grid"]];


            string question8Q = "What does the JavaScript event loop primarily manage?";
            string[][] question8A = [["Execution order of asynchronous tasks",
                               "Memory allocation",
                               "Rendering performance",
                               "DOM parsing"],["Execution order of asynchronous tasks"]];


            string question9Q = "Why is JavaScript considered a dynamically typed language?";
            string[][] question9A = [["Types are enforced at compile time",
                                "Variables can change type at runtime",
                                "It has no primitive types",
                                "It does not support type checking"],["Variables can change type at runtime"]];


            string question10Q = "Why is semantic HTML important?";
            string[][] question10A = [["It reduces CSS file size",
                                "It improves SEO and accessibility",
                                "It increases JavaScript performance",
                                "It removes the need for ARIA"],["It improves SEO and accessibility"]];


            string question11Q = "Which step happens first in the browser rendering process?";
            string[][] question11A = [["Painting",
                                "Layout",
                                "DOM construction",
                                "Compositing"],["DOM construction"]];


            string question12Q = "Why is the PUT HTTP method considered idempotent?";
            string[][] question12A = [["It always creates new resources",
                                "It cannot modify data",
                                "It is faster than POST",
                                "Repeating the request has the same result"],["Repeating the request has the same result"]];


            string question13Q = "Why is excessive boxing considered a performance problem in C#?";
            string[][] question13A = [["It allocates objects on the heap",
                                "It blocks the Garbage Collector",
                                "It causes stack overflow",
                                "It disables JIT optimization"],["It causes stack overflow"]];


            Question question1 = new(question1Q, question1A);
            Question question2 = new(question2Q, question2A);
            Question question3 = new(question3Q, question3A);
            Question question4 = new(question4Q, question4A);
            Question question5 = new(question5Q, question5A);
            Question question6 = new(question6Q, question6A);
            Question question7 = new(question7Q, question7A);
            Question question8 = new(question8Q, question8A);
            Question question9 = new(question9Q, question9A);
            Question question10 = new(question10Q, question10A);
            Question question11 = new(question11Q, question11A);
            Question question12 = new(question12Q, question12A);
            Question question13 = new(question13Q, question13A);

            QuestionController questionController = new(user);
            questionController.AddQuestion(question1);
            questionController.AddQuestion(question2);
            questionController.AddQuestion(question3);
            questionController.AddQuestion(question4);
            questionController.AddQuestion(question5);
            questionController.AddQuestion(question6);
            questionController.AddQuestion(question7);
            questionController.AddQuestion(question8);
            questionController.AddQuestion(question9);
            questionController.AddQuestion(question10);
            questionController.AddQuestion(question11);
            questionController.AddQuestion(question12);
            questionController.AddQuestion(question13);



            string? readResult = "";
            string menuSelection = "";



            do
            {
                userController.Welcome();
                readResult = Console.ReadLine();

                if (readResult != null)
                    menuSelection = readResult;

                switch (menuSelection)
                {
                    case "1":
                        Console.Clear();
                        Question currentQuestion;
                        currentQuestion = questionController.GetRandomQuestion();
                        //while (user.lives != 0)
                        //{
                        //    
                           
                        //    //questionController.CheckAnswer(currentQuestion);
                           
                        //}

                        break;
                    case "2":

                        userController.ShowLeaderboard();

                        break;
                    case "3":

                        questionController.ShowHistory();

                        break;
                }


            } while (menuSelection != "exit");
        }
    }
}
