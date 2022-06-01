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


           

           int health = 3;
           int monster = 5;
           int potion = 3;
           bool win = false;
         
           while (health > 0 && !win && monster > 0)

            {
                Console.WriteLine(" Monster appears, want to attack?: ");
                string choice = (Console.ReadLine());

                if (choice == "yes")
                {
                    Console.Write(" Want to use potion? Yes nor no ");
                    string choice3 = Console.ReadLine();    
                    if (choice3 == "yes" && potion > 0 && health > 3) 
                    {
                        Console.WriteLine(" potion used");
                        health++;
                        potion--;
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(potion + " left to use ");

                    }
                    else if (choice3 == "no") 
                    { 
                        Console.WriteLine("Potion not used");
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(potion + " left to use ");
                    }
                    else
                    {
                        Console.WriteLine("invalid option or you used upp potion or you are att full health");
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(potion + " left to use ");
                    }
                    Console.Write("Monster appears and you attack it: yes or no;");
                    string choice2 = Console.ReadLine();

                    Random lol = new Random();
                    int lol_num = lol.Next(1, 4);
                    Console.WriteLine(lol_num);

                    if (lol_num == 4 && choice2 == "yes")
                    {
                        Console.WriteLine("You choose to attak monster and it was succeful");
                        monster--;
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(monster + " Monster amount of health ");
                    }


                    else if (lol_num == 3 && choice2 == "yes")
                    {
                        Console.WriteLine("You blocked monster attack, none damge taken.");
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(monster + " Monster amount of health ");
                    }

                    else if (lol_num == 2 && choice2 == "yes")
                    {
                        Console.WriteLine("Monster made some damage, you lose health point");
                        health--;
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(monster + " Monster amount of health ");
                    }

                    else if (lol_num == 1 && choice2 == "yes")
                    {
                        Console.WriteLine("monster missed you and you got chance to heal.");
                        health++;
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(monster + " Monster amount of health ");
                    }

                    else if (choice2 == "no")
                    {
                        Console.WriteLine("You choosed not to attack");
                        health--;
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(monster + " Monster amount of health ");
                    }

                    else
                    {
                        Console.WriteLine("You mistepped and lett monster attack you!");
                        health--;
                        Console.WriteLine(health + " Amount of health ");
                        Console.WriteLine(monster + " Monster amount of health ");
                    }


                } 
                else if (choice == "no")
                {
                    Console.WriteLine("You gott attacked");
                    health--;
                    Console.WriteLine(health + " Amount of health ");
                }
                else
                {
                    Console.WriteLine("invalid choice monster attack you");
                    health--;
                    Console.WriteLine(health + " Amount of health ");
                }
            }

            if (win == true && monster == 0)
            {
                Console.WriteLine("You win!");
            }
            else if (health == 0 && !win)
            {
                Console.WriteLine("You loose!!");
            } 
             
        }
    }
}