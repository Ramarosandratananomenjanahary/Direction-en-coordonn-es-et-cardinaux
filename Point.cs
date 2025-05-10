using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisiondirection
{
    public class Point
    {
        private int x { get; set; }
        private int y { get; set; }

        public Point (int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public void Nord()
        {
            this.y--;
        }
        public void Sud()
        {
            this.y++;
        }
        public void Est()
        {
            this.x++;
        }
        public void Ouest()
        {
            this.x--;
        }

        public void Afficher()
        {
            Console.WriteLine($" X = {this.x} et Y = {this.y}");
        }
    }

}
