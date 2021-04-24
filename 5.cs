using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int breakfast = 5,weekend = 2,coffee = 3;
            string menu = "";
            while(menu != "End")
            {
                menu = Console.ReadLine();
                if (menu == "Breakfast Set")
                {
                    if (breakfast == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else if(time > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else
                    {
                        breakfast -= 1;
                    }
                }
                else if (menu == "Weekend Set")
                {
                    if (weekend == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else if (days != 6 && days != 7)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else
                    {
                        weekend -= 1;
                    }
                }
                else if (menu == "Coffee")
                {
                    if (coffee == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        coffee -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }
            }
        }
    }
}
