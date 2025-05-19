using System;
using System.Security.Cryptography;


namespace SimpleIterationExample
{
    class Program
    {
        public delegate double MyFunction(double x);

        class RootFinder
        {
            public MyFunction g;     
            public double epsilon;    
            public int maxSteps;      

            public RootFinder(MyFunction function, double eps, int max)
            {
                g = function;
                epsilon = eps;
                maxSteps = max;
            }
            public double FindRoot(double x0)
            {
                double xPrev = x0;
                double xNext = g(xPrev);
                int steps = 1;

                while (Math.Abs(xNext - xPrev) > epsilon && steps < maxSteps)
                {
                    xPrev = xNext;
                    xNext = g(xPrev);
                    steps++;
                }

                if (steps >= maxSteps)
                {
                    Console.WriteLine("Перевищено максимальну кiлькість iтерацiй.");
                }

                return xNext;
            }
        }

        static void Main(string[] args)
        {
            
            MyFunction g = delegate (double x)
            {
                return Math.Cos(x);
            };

            RootFinder finder = new RootFinder(g, 0.000001, 1000);

            double start = 0.5;

            double root = finder.FindRoot(start);

            Console.WriteLine("Знайдений корiнь: " + root);
        }
    }
}

