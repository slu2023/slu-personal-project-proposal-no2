using System;
using System.IO;

namespace ExampleProject
{
    class TestClosing
    {
        public static bool RunTest()
        {
            Closing ClosingQuestion = new Closing();
            ClosingQuestion.Closing = "Do you want to translate another one?";
            ClosingQuestion.answers.Add("Why not!");
            ClosingQuestion.answers.Add("No Im good");
            return false;

            Console.WriteLine("Expected: one of the choice");
            Console.WriteLine("Type 1 for example, this should be a valide input");
            Console.WriteLine("Type 2 for example, this should be a valide input");
            

            int result = Program.Choice(ClosingQuestion);
            int expected = 1;

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but result was {result}.");
            }
            return false;

            if (result = null)
            {
                Console.Error.WriteLine($"Failure: result can't be null.");
            }
            return false;
            public class Closing
        {

            return false;
        }

    }
}