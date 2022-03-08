using System;
using System.Collections.Generic;
using System.IO;

namespace slu_personal_project_proposal_no2
{
    class TestChoice
    {
        public static bool RunTest()
        {
        List<string> testChoice = new List<string>();
            testChoice.Add("What do you want to do today?");
            testChoice.Add("English to Computer language.");
            testChoice.Add("Computer language to English.");

            Console.WriteLine("Expected: one of the choice");
            Console.WriteLine("Type 1 for example, this should be a valide input");
            Console.WriteLine("Type 2 for example, this should be a valide input");

            int result = Program.Choice(testChoice);
            int expected1 = 1;

            if (result != expected1)
            {
                Console.Error.WriteLine($"Failure: Expected {expected1} but result was {result}.");
                return false;
            }
            return true;
            
    }
}
}