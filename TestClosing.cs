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

            // TODO(jcollard 2022-03-03): What about an invalid input?
            Console.WriteLine("Type 1 for example, this should be a valide input");
            Console.WriteLine("Type 2 for example, this should be a valide input");


            List<string>testDecisions = new List<string>();
            testDecisions.Add("Do you want to translate another one?");
            testDecisions.Add("Yes!");
            testDecisions.Add("No.");
            int result = Program.Closing(testDecisions);
            int expected = 1;

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but result was {result}.");
                //TODO(jcollard 2022-03-03): Don't forget to return false here
            }

            //TODO(jcollard 2022-03-03): Great start! You should consider adding a few more test cases here.

            // TODO(jcollard 2022-03-03): At the end of your test, you should return true (because it succeeded)
            return true;

        }

    }
}