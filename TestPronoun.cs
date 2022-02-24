using System;
using System.IO;

namespace ExampleProject
{
    class TestPronoun
    {
        public static bool RunTest()
        {
            Pronoun pronounQuestion = new Pronoun();
            pronounQuestion.pronoun = "How can I address you?";
            pronounQuestion.answer.Add(Console.ReadLine);

            Console.WriteLine("Expected: the output is anything.");
            Console.WriteLine("Type LUCIA! for example, this should be a valide input");

            int result = Program.Pronoun(pronounQuestion);
            int expected = 1;

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but result was {result}.");
                return false;
            }

            return false;
        }

        public class Pronoun
        {
            public string pronoun;
        }

    }
}