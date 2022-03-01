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
            testChoice.Add("Do you want to translate another one?");
            testChoice.Add("1. Yes!");
            testChoice.Add("2. No.");

            Console.WriteLine("Expected: one of the choice");
            Console.WriteLine("Type 1 for example, this should be a valide input");
            Console.WriteLine("Type 2 for example, this should be a valide input");

            int result = Program.Choice(testChoice);
            int expected1 = -1;

            if (result != expected1)
            {
                Console.Error.WriteLine($"Failure: Expected {expected1} but result was {result}.");
                return false;
            }
            return true;
            
    }
}
}