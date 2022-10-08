using System;

namespace csharpPractice
{
    class point {
        int xPos;
        int yPos;
        public void getPoint (int x, int y ) {
            xPos = x;
            yPos = y;
        }

        public void printPoint() {
            Console.WriteLine("The x is {0}", xPos);
            Console.WriteLine("The y is {0}", yPos);
        }
    }

    class execute 
    {
        static void Main () {
            point ppp = new point();
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            ppp.getPoint(a, b);
            ppp.printPoint();
        }
    }
}