using System;
using System.Collections.Generic;
using System.IO;

namespace ExampleProject
{
    class TestChoice
    {
        public static bool RunTest()
        {
        List<int>testChoice = new List<int>();
            testChoice.Add("Do you want to translate another one?");
            testChoice.Add("1. Yes!");
            testChoice.Add("2. No.");
            int result = Program.Choice(testChoice);
            int expected1 = 1;

            if (result != expected1)
            {
                Console.Error.WriteLine($"Failure: Expected {expected1} but result was {result}.");
            }
            
    }
}
}