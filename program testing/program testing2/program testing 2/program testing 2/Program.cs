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


            string[] cars = new string[10];

            
            cars[1 + 2] = "A" + "A";
            cars[2 + 3] = "B";
            cars[3 + 4] = "C";

           
            cars.Append(cars[1 + 2] = "volvo");
            cars.Append(cars[1] = "volvo");
            Console.WriteLine(cars[1 + 2]);
            Console.WriteLine(cars[2 + 3]);
            Console.WriteLine(cars[3 + 4]);



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