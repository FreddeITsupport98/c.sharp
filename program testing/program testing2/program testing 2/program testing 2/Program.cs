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


            string[] cars = {"","","",""};

            
            cars.Append(cars[0] = "1");
            cars.Append(cars[1] = "2");
            cars.Append(cars[2] = "3");
            cars.Append(cars[3] = "3");
           
            foreach (string car in cars) {
                Console.WriteLine(car);
            }



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