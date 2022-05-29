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

            // mad libs game

            String color, plrualNoun, Celebrity;

            Console.Write("enter a color :");
                color = Console.ReadLine();
            Console.Write("enter a plrualNoun :");
                plrualNoun = Console.ReadLine();
            Console.Write("enter a Celebrity :");
                Celebrity = Console.ReadLine();

            Console.WriteLine("Monster i do " + color);
            Console.WriteLine(" They try to kill " + plrualNoun + " my liver ");
            Console.WriteLine("But i survive this " + Celebrity);

            //arrays

            int[] luckyNumber = { 4, 8, 12, 16, 20 }; // elements in array
            //                    0, 1, 2,  3,  4, Index number          
            //      luckyNumber[1] = 100
            //      Output: 100
            string[] friends = new string[3];
            friends[0] = "jim";
            friends[1] = "robert";
            friends[2] = "fredrik";

            Console.WriteLine( luckyNumber[0] + " Array number index " ); //specify elements as index 0 of array
            
            foreach (string i in friends)
                Console.WriteLine( i );

         //method

            SayHi("ferdrik is bra", 50); //call method with int and string

            //return statement vaulue

            Console.WriteLine(cube(10) + " return value ");


            // if statements

            bool ärMan = true;
            bool isTall = false;

            if (ärMan || isTall) // && is and operator id must be true and || is or operator means  either bpoth has not need to be truth
            {
                Console.WriteLine("your are tall male");
            } 
            else if (ärMan && !isTall) // ! this is negete operator makes it false
            {
                Console.WriteLine("your are short male");
            } 
            else if (!ärMan && isTall)
            {
                Console.WriteLine("your are not male but tall");
            }
            else 
            {
                Console.WriteLine("You are not tall or male!");
            }

            // more if statments

            // building better calculator

            Console.WriteLine("Enter a number: ");
            double siffraett = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a operator (+ - / *) : ");
            string op = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            double siffraetvå = Convert.ToDouble(Console.ReadLine());
            
            if (op == "+")
            {
                Console.WriteLine ("Din tal: " + (siffraett + siffraetvå));
            } else if (op == "-")
            {
                Console.WriteLine("Din tal: " + ( siffraett - siffraetvå ));
            } else if (op == "*")
            {
                Console.WriteLine("Din tal: " + ( siffraett * siffraetvå ));    
            } else if (op == "/")
            {
                Console.WriteLine("Din tal: " + ( siffraett / siffraetvå));
            } else
            {
                Console.WriteLine("enter a operator");
            }

            // switch statment

            Console.WriteLine(GetDay(5));


            // whiloe loops

            int index = 1;

            while (index <= 5) // loop kan också vara oändligt om programen ser ingen false värde.
            {
               Console.WriteLine(index);
                index++; // increament loop till it stops at 5
            }


            // building guessing game

            string secretWord = "Mamma";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOffGuesses = false;

            while (guess != secretWord && !outOffGuesses)
            {   
                if (guessCount < guessLimit)
                {
                    Console.Write("keeop guessing: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } 
                else 
                {
                    outOffGuesses |= true;
                }
               
            }
            
            if (outOffGuesses)
            {
                Console.Write("You lose");
            }
            else
            {
                Console.Write("You win!");
            }

            

           Console.ReadLine();
        
                
                
        }

        static string GetDay(int dayNum)
        {

     

            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "måndag";
                    break;
                case 1:
                    dayName = "tisdag";
                    break;
                case 2:
                    dayName = "onsdag";
                    break;
                case 3:
                    dayName = "torsdag";
                    break;
                case 4:
                    dayName = "fredag";
                    break;
                case 5:
                    dayName = "lördag";
                    break;
                case 6:
                    dayName = "söndag";
                    break;
                default:
                    dayName = "inte giltig nummer";
                    break;
            }

            return dayName;

        }

        static int GetMax(int yum1, int yum2)
        {
            int resultat;
            if (yum1 > yum2 ) {
                resultat = yum1;
            } else
            {
                resultat = yum2;
            }

            return resultat;
        }

        static int cube(int nummer) //setts name for method
        {
            int resultat = nummer * nummer * nummer; // use integer as defined number
            return resultat; // return value set to resultat
        }
        static void SayHi(string name, int age4) // static, void clears and parameter means code passes information to caller
        {
            Console.WriteLine("Hello" + name + age4);
            
        }
    }
}

        
          
             