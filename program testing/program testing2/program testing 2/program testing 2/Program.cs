using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program_testing2
{
    class Program_testing2
    {
        static void Main(string[] args)
        {


            string[] cars =  {"", "", ""};

            cars[0] = "";
            cars[1] = "";
            cars[2] = "lol";
            cars.Append(cars[1] = "Hejdå");
            cars.Append(cars[2] = "");


            bool exit = false;
            
            while  (exit != true)
            {
                Console.Write("menu 1 eller menu 2 eller menu3: ");
                string menu = Console.ReadLine();
                if (menu == "1")
                {
                    Console.WriteLine(cars[1]) ; 
                   
                    Console.WriteLine(cars);
                }
                else if (menu == "2")
                {
                    Console.WriteLine("menu2");
                }
                else if (menu == "3")
                {
                    Console.WriteLine("menu3");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("wrong keyboard");
                }
            }

            Console.ReadLine();
        }
    }
}