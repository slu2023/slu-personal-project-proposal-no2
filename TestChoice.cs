using System;
using System.IO;

namespace ExampleProject
{
    class TestChoice
    {
        public static bool RunTest()
        {
            Choice ChoiceQuestion = new Choice();
            ChoiceQuestion.choice = "{UserInput}, what do you want to do today?";
            ChoiceQuestion.answers.Add("ENG_CS");
            ChoiceQuestion.answers.Add("CS_ENG");
            return false;

            Console.WriteLine("Expected: ENG_CS");
            Console.WriteLine("Type 1 for example, this should be a valide input");
            Console.WriteLine("Type 2 for example, this should be a valide input");
            

            int result = Program.Choice(choiceQuestion);
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
            public class Choice
        {
            public string choice;
        }
    }
}
}