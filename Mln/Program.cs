using Mln.Controller;
using Mln.Model;

namespace Mln
{
    public class Program
    {
        public static void Main(string[] args)
        {

            User user = new("nicat","qwerty1");

         string question1Q = "Why are short-lived objects usually cheap in .NET?";
         string[] question1A = ["They are collected in Generation 0, which is fast",
                                "They are never allocated on the heap",
                               "They are automatically stack-allocated",
                               "They bypass the Garbage Collector"];
        int rightAnswer1 = 1;

        string question2Q = "What is the primary purpose of await in C#?";
        string[] question2A = ["To create a new thread",
                                "To block the current thread",
                                "To release the current thread while waiting",
                                "To speed up CPU-bound operations"];
        int rightAnswer2 = 3;

        string question3Q = "Why can IQueryable be dangerous if misused?";
        string[] question3A = ["It disables deferred execution",
                                "It forces all data into memory",
                                "It cannot be unit tested",
                                "It may execute unexpected database queries",];
        int rightAnswer3 = 4;

        string question4Q = "When is a struct more appropriate than a class?";
        string[] question4A = ["When the object has complex behavior",
                                "When inheritance is required",
                                "When representing small, immutable data",
                                "When reference sharing is important"];
        int rightAnswer4 = 3;

        string question5Q = "Why can changing a const value in a library cause bugs in dependent applications?";
        string[] question5A = ["const values are stored in the database",
                                "const values are inlined at compile time",
                                "readonly values are mutable",
                                "const values require reflection"];
        int rightAnswer5 = 2;

        string question6Q = "What primarily determines which CSS rule wins when multiple rules target the same element?";
        string[] question6A = [ "Selector specificity",
                                "The order of properties in the file",
                                "The number of selectors used",
                                "Browser vendor"];
        int rightAnswer6 = 1;

        string question7Q = "Which CSS layout system is best suited for two-dimensional layouts (rows and columns)?";
        string[] question7A = ["Float",
                                "Flexbox",
                                "Positioning",
                                "Grid"];
        int rightAnswer7 = 4;

        string question8Q = "What does the JavaScript event loop primarily manage?";
        string[] question8A = ["Execution order of asynchronous tasks",
                               "Memory allocation",
                               "Rendering performance",
                               "DOM parsing"];
        int rightAnswer8 = 1;

        string question9Q = "Why is JavaScript considered a dynamically typed language?";
        string[] question9A = ["Types are enforced at compile time",
                                "Variables can change type at runtime",
                                "It has no primitive types",
                                "It does not support type checking"];
        int rightAnswer9 = 2;

        string question10Q = "Why is semantic HTML important?";
        string[] question10A = ["It reduces CSS file size",
                                "It improves SEO and accessibility",
                                "It increases JavaScript performance",
                                "It removes the need for ARIA"];
        int rightAnswer10 = 2;

        string question11Q = "Which step happens first in the browser rendering process?";
        string[] question11A = ["Painting",
                                "Layout",
                                "DOM construction",
                                "Compositing"];
        int rightAnswer11 = 3;

        string question12Q = "Why is the PUT HTTP method considered idempotent?";
        string[] question12A = ["It always creates new resources",
                                "It cannot modify data",
                                "It is faster than POST",
                                "Repeating the request has the same result"];
        int rightAnswer12 = 4;

        string question13Q = "Why is excessive boxing considered a performance problem in C#?";
        string[] question13A = ["It allocates objects on the heap",
                                "It blocks the Garbage Collector",
                                "It causes stack overflow",
                                "It disables JIT optimization"];
        int rightAnswer13 = 3;

            Question question1 = new(question1Q, question1A, rightAnswer1);
            Question question2 = new(question2Q, question2A, rightAnswer2);
            Question question3 = new(question3Q, question3A, rightAnswer3);
            Question question4 = new(question4Q, question4A, rightAnswer4);
            Question question5 = new(question5Q, question5A, rightAnswer5);
            Question question6 = new(question6Q, question6A, rightAnswer6);
            Question question7 = new(question7Q, question7A, rightAnswer7);
            Question question8 = new(question8Q, question8A, rightAnswer8);
            Question question9 = new(question9Q, question9A, rightAnswer9);
            Question question10 = new(question10Q, question10A, rightAnswer10);
            Question question11 = new(question11Q, question11A, rightAnswer11);
            Question question12 = new(question12Q, question12A, rightAnswer12);
            Question question13 = new(question13Q, question13A, rightAnswer13);

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

            UserController userController = new UserController();
            userController.AddUser(user);
            Question currentQuestion;
            while (user.lives != 0)
            {
                currentQuestion = questionController.GetRandomQuestion();
                questionController.CheckAnswer(currentQuestion, Console.ReadLine());
            }
            
            
        }
    }
}
