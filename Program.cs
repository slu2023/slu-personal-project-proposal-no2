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

            string name = Pronoun();
            Console.WriteLine($"What a wonderful name, {name}!");

        }

        
        public static void TestAll()
        {
            // bool testCipherTranslation = TestCipherTranslation.RunTest();
            // Console.WriteLine($"Test LoadFile(filename):{testCipherTranslation}");

            // bool testOpening = TestOpening.RunTest();
            // Console.WriteLine($"Test Pronoun(options):{testCipherTranslation}");
            // bool testPronoun = TestPronoun.RunTest();
            // Console.WriteLine($"Test Pronoun(options):{testPronoun}");
            bool testChoice = TestChoice.RunTest();
            Console.WriteLine($"Test Choice(options):{testChoice}");
            // bool testENG_CS = TestENG_CS.RunTest();
            // Console.WriteLine($"Test ENG_CS(options):{testCipherTranslation}");
            // bool testCS_ENG = TestCS_ENG.RunTest();
            // Console.WriteLine($"Test CS_ENG(options):{testCipherTranslation}");
            // bool testClosing = TestClosing.RunTest();
            // Console.WriteLine($"Test Closing(options):{testCipherTranslation}");
        }

        // <summary>
        // Ask the user to type an input, store it for future use.
        // </summary>
        // <param name="prompt">The message to display to the user</param>
        // <returns>The positive number the user chose</returns>
        
        // OPENING HERE:
        public static string Opening()
        {
            Console.WriteLine("This Cipher assignment will help you write your secret messages in a cipher code.  No else person will be able to read what you mean unless they can communicate with a computer!");
            return null;
        }
        
        
        // PRONOUN HERE:
        public static string Pronoun()
        {
            Console.WriteLine("Hello,");
            Console.Write("How can I address you?");
            string inInput = Console.ReadLine();
            return inInput;
        }

        // CHOICE HERE:
        public static int Choice(List<string> choices)
        {
            if (choices == null) throw new ArgumentNullException("List of options may not be null.");
            if (choices.Count == 0) throw new ArgumentException("The List of options must contain at least 1 option.");
            
            int ix = 1;
            foreach (string option in choices)
            {
                Console.WriteLine($"{ix}.{option}");
                ix = ix +1;
            }

            // get input here
            int choice;
            do
            {
                string userInput;
                userInput = Console.ReadLine();
                // Parse translates the user input into an int value
                 choice = int.Parse(userInput);


                // List<string> options = new List<string>();
                // options.Add("Yes!");
                // options.Add("No.");
                // Choice(options);
                if (choice >= 2)
                {
                    Console.Error.WriteLine("Number must be less than or equal to 2.");
                }
                if (choice < 1)
                {
                    Console.Error.WriteLine("Number has to be bigger than or equal to 1");
                }
            }
            while (choice >= 2 || choice < 1);

            return choice;
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
            Console.WriteLine();
            Console.WriteLine( "What do you want to generate?");
            string input = Console.ReadLine();
            Console.WriteLine("result");
                // 1. Display: what do you want to generate?
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
            Console.WriteLine();
            Console.Write( "What do you want to generate?");
            string input = Console.ReadLine();
            Console.WriteLine("result");
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
        
        
        // CLOSING HERE:
        public static int Closing(List<string> decision)
        {
            // 1. Display "Do you want to generate another one?"
            // 2. If the user selected yes, loop back all the way to the beginning.
            // 3. If the user picked no, display goodbye and end of program.
            // 4. Else, invalided pick
        
            if (decision == null) throw new ArgumentNullException("List of options may not be null.");
            if (decision.Count == 0) throw new ArgumentException("The List of options must contain at least 1 option.");
            
            int ix = 1;
            foreach (string option in decision)
            {
                Console.WriteLine($"{ix}.{option}");
                ix = ix +1;
            }

            List<string> options = new List<string>();
            options.Add("Yes!");
            options.Add("No.");
            Closing(options);
            return -1;
        }

    }
}