using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string opa = Console.ReadLine();
            while (opa == "+" || || opa == "-" || opa == "*" || opa == "/" || opa == "^"|| opa == "|")
            {
            if (opa == "+" || opa == "-" || opa == "*" || opa == "/") 
            { 
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                switch (opa)
                {
                    case "+":
                        (a+bi)+(c+di) = (a+c)+(b+d)i
                        break;
                    case "-":
                        (a + bi) - (c + di) = (a - c) + (b - d)i
                        break;
                    case "*":
                        (a + bi) * (c + di) = (ac + cd) + (ad + bc)i
                        break;
                    case "/":
                        (a + bi) / (c + di) = ((ac + bd) / (Math.Pow(c,2)) + (Math.Pow(d, 2)) + (ad + bc)i
                        break;
                }
            }
            else if (opa == "^")
            {
                int numtoexponent = int.Parse(Console.ReadLine());
            }
            else if (opa == "|")
            {

            }
            }
        }
    }
}
