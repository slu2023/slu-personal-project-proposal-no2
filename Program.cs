using System;
using System.Collections.Generic;

namespace slu_personal_project_proposal_no2
{
    class Program
    {
        public static object CipherTranslation;

        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
        }

        
        public static void TestAll()
        {
            bool testCipherTranslation = TestCipherTranslation.RunTest();
            Console.WriteLine($"Test LoadFile(filename):{testCipherTranslation}");

            bool testPronoun = TestPronoun.RunTest();
            Console.WriteLine($"Test Pronoun(options):{testCipherTranslation}");
            bool testChoice = TestChoice.RunTest();
            Console.WriteLine($"Test Choice(options):{testCipherTranslation}");
            bool testENG_CS = TestENG_CS.RunTest();
            Console.WriteLine($"Test ENG_CS(options):{testCipherTranslation}");
            bool testCS_ENG = TestCS_ENG.RunTest();
            Console.WriteLine($"Test CS_ENG(options):{testCipherTranslation}");
            bool testClosing = TestClosing.RunTest();
            Console.WriteLine($"Test Closing(options):{testCipherTranslation}");
        }

        // <summary>
        // Ask the user to type an input, store it for future use.
        // </summary>
        // <param name="prompt">The message to display to the user</param>
        // <returns>The positive number the user chose</returns>
        public static string Pronoun()
        {
            // 1. Display the question
            // 2. Take the user input
            
            return null;
        }

        public static int Choice(List<string> testChoice)
        {
            return -1;
        }

        // <summary>
        // Given a series of choices to the user
        // Looping until the user picked a valide choice.
        // </summary>
        // <param name="prompt">The message to display to the user</param>
        // // <returns>The positive number the user chose</returns>

        // public static string Choice(List<string> Choice)
        // {
        //     // 1. Display the question with the user input
        //     // 2. Take the user input
        //     // 3. Bring the user to one of the rooms
        //     // 4. Display invalided input if the userinput is out of range
        //     return null;
        // }

        // <summary>
        // Asking the user to type some valide input.
        // Looping until the user typed a valide code.
        // </summary>
        // <param name="prompt">The message to display to the user</param>
        // <returns>The positive number the user chose</returns>
        public static string ENG_CS(string text)
        {
            string userInput = Console.ReadLine();
                // 1. Display "What do you want to generate?"
                // 2. Waiting for the user to type something
                // 3. Run test
                // 4. Display result
            return null;

        }

        // <summary>
        // Asking the user to type some valide input.
        // Looping until the user typed a valide code.
        // </summary>
        // <param name="prompt">The message to display to the user</param>
        // <returns>The positive number the user chose</returns>
        public static string CS_ENG(string text)
        {
            string userInput = Console.ReadLine();
                // 1. Display "What do you want to generate?"
                // 2. Waiting for the user to type something
                // 3. Run test
                // 4. Display result
            return null;

        }

        // <summary>
        // Given a questions to the user, the user needs to answer it.  
        // Looping until the question has been answered.
        // </summary>
        // <param name="prompt">The message to display to the user</param>
        // <returns>The positive number the user chose</returns>
        public static int Closing(List<string> Decision)
        {
            // 1. Display "Do you want to generate another one?"
            // 2. If the user selected yes, loop back all the way to the beginning.
            // 3. If the user picked no, display goodbye and end of program.
            // 4. Else, invalided pick
            return -1;
        }

    }
}