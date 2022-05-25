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
           int monster = 100;
           int a = health - damage;
           int b = monster - damage;
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
                    Console.WriteLine(b);
                    Console.WriteLine(" monster took some damge " + b);


                } 
                else if (answertwo == "no")
                {
                    Console.WriteLine(a);
                    Console.WriteLine(" You took some damge " + a);
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