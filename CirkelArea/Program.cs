//Jonathan Ludvigsson SUT22
using System;

namespace CirkelArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine(c.GetArea());

            Circle c2 = new Circle(6);
            Console.WriteLine(c2.GetArea());
        }
    }
    class Circle
    {
        private float _pi = 3.141f;
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public float GetArea()
        {
            return _radius * _radius * _pi;
        }
    }
}
