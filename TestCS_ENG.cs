using System;
using System.IO;

namespace slu_personal_project_proposal_no2
{
    class TestCS_ENG
    {
        public static bool RunTest()
        {

            string result = Program.CS_ENG("mfuud");
            string expected = "HAPPY";

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but result was {result}.");
                return false;
            }

            return true;
        }

        // private static string Decrypt(string message)
        // {
        //     string newMessage = string.Empty;
        //     foreach (char c in message)
        //     {
        //         newMessage += (char)(c - this.shift);
        //     }
        //     return newMessage;
        // }


    }
}