using System;
using System.IO;

namespace slu_personal_project_proposal_no2
{
    class TestENG_CS
    {
        public static bool RunTest()
        {
            string result = Program.ENG_CS("HAPPY");
            string expected = "mfuud";

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but result was {result}.");
                return false;
            }

        
            return false;
        }

        // private static string Encrypt(string message)
        // {
        //     string newMessage = string.Empty;
        //     foreach (char c in message)
        //     {
        //         //TODO: The following copies the message character by character.
        //         //      Instead, you should to encrypt each character using the shift
        //         newMessage += (char)(c + this.shift);
        //     }

        //     return newMessage;
        // }


    }
}