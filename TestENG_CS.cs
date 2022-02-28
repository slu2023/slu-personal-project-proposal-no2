using System;
using System.IO;

namespace ExampleProject
{
    class TestENG_CS
    {
        public static bool RunTest()
        {
            public string Encrypt(string message)
            {
                string newMessage = string.Empty;
                foreach (char c in message)
                {
                    //TODO: The following copies the message character by character.
                    //      Instead, you should to encrypt each character using the shift
                    newMessage += (char)(c + this.shift);
                }

                return newMessage;
            }

            return false;
        }


    }
}