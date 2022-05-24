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
            //string userInput;
            //Console.WriteLine("Are you a male?: ");
            //userInput= Console.ReadLine();
            //bool userInputBoolean = Convert.ToBoolean(userInput);
            //Console.WriteLine(" Your answr " + userInputBoolean);
            //bool isValid = true;
            //bool isInvalid = false;

           int health = 100;
           int damage = 10;

           Console.WriteLine("Are you ready to defeat monster?");
           Console.Write("Yes or No : ");
           string answerone = Console.ReadLine();

            Console.WriteLine(answerone);
            if (answerone == "yes")
            {
                Console.WriteLine(health + " maximum HP");
                Console.Write("attack?" + " yes or no ");
                string answertwo = Console.ReadLine();
                    if (answertwo == "yes")
                {
                    Console.WriteLine(health - damage);
                    Console.WriteLine("You took som damge" + health);
                } 
                else if (answertwo == "no")
                {

                }
            }
            else if (answerone == "no")
            {
                Console.WriteLine("Goodbye no worries to defeat monster sleep tight...");
            }
            else 
            {
                 
            }
             
        }
    }
}