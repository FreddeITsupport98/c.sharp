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

            Console.ReadLine();


        }
    }
}

        
          
             