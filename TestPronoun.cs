using System;
using System.IO;

namespace slu_personal_project_proposal_no2
{
    class TestPronoun
    {
        public static bool RunTest()
        {
            // Pronoun pronounQuestion = new Pronoun();
            // pronounQuestion.pronoun = "How can I address you?";
            // pronounQuestion.answers.Add(Console.ReadLine);

            Console.WriteLine("Expected: the input could be anything.");
            Console.WriteLine("Type LUCIA! for example, this should be a valide input");

            string result = Program.Pronoun();
            string expected = "LUCIA!";

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but result was {result}.");
                return false;
            }

            return true;
        }

        public class Pronoun
        {
            public string pronoun;
        }

    }
}