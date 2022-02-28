using System;
using System.Collections.Generic;
using System.IO;

namespace slu_personal_project_proposal_no2
{
    class TestClosing
    {
        public static bool RunTest()
        {
            // Closing ClosingQuestion = new Closing();
            // ClosingQuestion.Closing = "Do you want to translate another one?";
            // ClosingQuestion.answers.Add("Why not!");
            // ClosingQuestion.answers.Add("No Im good");
            // return false;

            Console.WriteLine("Expected: one of the choice");
            Console.WriteLine("Type 1 for example, this should be a valide input");
            Console.WriteLine("Type 2 for example, this should be a valide input");


            List<string>testDecisions = new List<string>();
            testDecisions.Add("Do you want to translate another one?");
            testDecisions.Add("1. Yes!");
            testDecisions.Add("2. No.");
            int result = Program.Closing(testDecisions);
            int expected = 1;

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but result was {result}.");
            }
            return false;

        }

    }
}