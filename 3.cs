using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float filmBackWidth = Console.ReadLine();
            while (filmBackWidth <= 0)
            {
                filmBackWidth = float.Parse(Console.ReadLine());
                if (filmBackWidth <= 0)
                {
                    Console.WriteLine("Invalid filmBackWidth. Please input again.");
                }
            }
            float fLength = 0, fov = 0;
            if (filmBackWidth >  0)
            {
                if(mode == "fLength")
                {
                    fLength = float.Parse(Console.ReadLine());
                    while (fLength <= 0)
                    {
                        Console.WriteLine("Invalid fLegnth. Please input again.");
                        fLength = float.Parse(Console.ReadLine());
                    }
                    fov = 2*Math.Atan((filmBackWidth/2)*fLength);
                }
                else if (mode == "fov")
                {
                    fov = float.Parse(Console.ReadLine());
                    while (fov <= 0.1 || fov >= 6.28)
                    {
                        Console.WriteLine("Invalid fov. Please input again.");
                        fov = float.Parse(Console.ReadLine());
                    }
                    fLength = filmBackWidth / 2 * Math.Tan(fov / 2);
                }
            }
            Console.WriteLine("fLength = {0} , fov = {1}", fLength,fov);
        }
    }
}
