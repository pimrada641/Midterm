using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            String character = Console.ReadLine();
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i <= amount; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for(int k = 0; k < width*i; k++)
                    {
                        Console.Write(character);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
