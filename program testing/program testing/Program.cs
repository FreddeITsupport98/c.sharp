using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class program2
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Are you a male?: ");
            userInput= Console.ReadLine();
            bool userInputBoolean = Convert.ToBoolean(userInput);
            Console.WriteLine(" Your answr " + userInputBoolean);
            bool isValid = true;
            bool isInvalid = false;
        }
    }
}