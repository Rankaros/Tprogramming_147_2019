using System;

namespace CourseApp
{
    public class Functions
    {
        public static double MyFunction(double a, double b, double x)
        {
            var c = (a + Math.Pow(Math.Tan(b * x), 2)) / (b + (1 / Math.Pow(Math.Tan(a * x), 2)));
            return c;
        }

        public static double[] TaskA (
                                     double a,
                                     double b,
                                     double xn,
                                     double xk,
                                     double dx)
        {
            var steps = (int)Math.Floor((xk - xn) / dx);
            var y = new double[steps];
            var i = 0;
            for (var x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB (
                                 double a,
                                 double b,
                                 double[] x)
        {
            var y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Func(string[] args)
        {
            var taskA = TaskA(0.1, 0.5, 0.15, 1.37, 0.25);
            Console.WriteLine(taskA);

            for (var i = 0; i < taskA.Length; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            var xB = new double[] { 0.2, 0.3, 0.44, 0.6, 0.56 };
            var taskB = TaskB(0.1, 0.5, xB);
            for (var i = 0; i < xB.Length; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }

            var item = new Platypus();
            Console.WriteLine(item.View());

            Console.ReadLine();
        }
    }
}
