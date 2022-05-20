using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("hejdå");

            Console.WriteLine("|__/");
            Console.WriteLine("|_/");
            Console.WriteLine("|/");

            string name = "Jhon";
            int age; //två olika sätt att spara i variabel.
            age = 20;

            Console.WriteLine("here is once man named " + name);
            Console.WriteLine("he was " + age + " years old");
            Console.WriteLine("he really liked name " + name);
            Console.WriteLine("But didnt like being " + age);

            string text = "giraff" + "det är cool"; //konkatanering värden tillsammans
            char grade = 'A'; // Endast en karaktär ryms 
            int age2 = 30;
            double poäng = 3.5;
            bool IsMale = true; //ENDAST TRUE OR FALSE STATment
            Console.WriteLine(text);
            Console.Write(text.Length); // .Length visar hur måånga ord det finns i strängen.
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Contains("giraff")); //.Contains slutar med true or false statment
            Console.WriteLine(text.Contains("lol")); //.Contains report as false statment
            Console.WriteLine(text[1]); //  0-9 first letter goes trough binary as it print second letter of first index output is = (I).
            Console.WriteLine(text.IndexOf("giraff")); // tells where index of letter begin at.
            Console.WriteLine(text.IndexOf("det är cool")); // same but other position of index
            Console.WriteLine(text.Substring(2,4)); // lägger till substring som tar texten delvist som statartar fiörsta sen sista 

            Console.WriteLine( (4 + 2) * 2 + 8 ); // whole number calculated here
            Console.WriteLine( 8.2 + 7.5 ); // decimal point calculated here
            Console.WriteLine(5.0 / 2.0);
            int siffra = 6;
            Console.WriteLine(siffra + siffra);
            Console.WriteLine(Math.Abs(10 + 50) + " Math.Abs"); //absulute math call return value of x - x or x + x = x
            Console.WriteLine(Math.Pow(3, 2) + " Math.Pow");
            Console.WriteLine(Math.Sqrt(100) + " Math.Sqrt"); // squere root 
            Console.WriteLine(Math.Max(10, 90) +" Max");
            Console.WriteLine(Math.Min(10, 90) + " Min");
            // user input
            
             Console.Write("Enter your name: ");
             string namn = Console.ReadLine(); // Console.ReadLine pause so user may enter the name
             Console.Write("Enter age: ");
             string age3 = Console.ReadLine();
             Console.WriteLine(" Hello " + namn + " your age is  " + age3);
            
            // BUILDING CALCULATOR

            int siffra2 = Convert.ToInt32("100");
            Console.WriteLine((siffra2 + siffra2) + " convert strings into int ");
            
            Console.Write("Enter number 1; ");
            int number1 = Convert.ToInt32((Console.ReadLine()));
            Console.Write(" enter sekund number :");
            int number2 = Convert.ToInt32((Console.ReadLine()));
            int number3 = number1 + number2;
            Console.WriteLine(" your number is " + number3);
            Console.WriteLine(number1 + number2 + "Variant 2 "); // varaint of adition

          

            Console.ReadLine();


        }
    }
}

        
          
             