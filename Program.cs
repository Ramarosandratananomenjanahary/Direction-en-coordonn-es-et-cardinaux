using System;
using System.ComponentModel;
namespace Revisiondirection
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Direction: ");
            string direction = Console.ReadLine().ToUpper();

            Point p1 = new Point(x, y);
            for (int i = 0; i < direction.Length; i++)
            {
                switch (direction[i])
                {
                    case 'N':
                        p1.Nord();
                        break;
                    case 'S':
                        p1.Sud();
                        break;
                    case 'E':
                        p1.Est();
                        break;
                    case 'O':
                        p1.Ouest();
                        break;
                    default:
                        Console.WriteLine("Verifier bien votre Direction");
                        break;
                }
            }
            p1.Afficher();
        }
    }
}