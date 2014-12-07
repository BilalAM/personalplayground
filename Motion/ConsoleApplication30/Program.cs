using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            double vf, vi, a, t, s;            //declaring integers

            Console.WriteLine("\n\t CALCULATING FINAL SPEED AMD DISTANCE USING THE EQUATIONS OF MOTION");
            Console.WriteLine("\t----------------------------------------------------------------------");


            Console.WriteLine("\n\nUSING 1st EQUATION\n===================");
            Console.Write("\n\nInitial Velocity(Vi)\t=> ");
            vi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Time(t)\t\t\t=> ");
            t = Convert.ToDouble(Console.ReadLine());
            Console.Write("Acceleration(a)\t\t=> ");
            a = Convert.ToDouble(Console.ReadLine());

            vf = vi + (a * t);                                          //FORMULA
            Console.WriteLine("\nFINAL VELOCITY(Vf) =>\t{0}" , vf);


            Console.WriteLine("\n\nUSING 2nd EQUATION\n====================");
            Console.Write("\n\nInitial Velocity(Vi)\t=> ");
            vi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Time(t)\t\t\t=> ");
            t = Convert.ToDouble(Console.ReadLine());
            Console.Write("Acceleration(a)\t\t=> ");
            a = Convert.ToDouble(Console.ReadLine());

            s = (vi * t) + 1 / 2 * (a * (t * t));                       //FORMULA
            Console.WriteLine("\nDISTANCE(S) =>\t{0}", s);

            Console.WriteLine("\n\nUSING 3rd EQUATION\n=====================");
            Console.Write("\n\nFinal Velocity(Vf)\t=> ");
            vf = Convert.ToDouble(Console.ReadLine());
            Console.Write("Initial Velocity(Vi)\t=> ");
            vi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Time(t)\t\t\t=> ");
            t = Convert.ToDouble(Console.ReadLine());
            Console.Write("Acceleration(a)\t\t=> ");
            a = Convert.ToDouble(Console.ReadLine());

            s = (vf * vf) - (vi * vi) / 2 * a;                          //FORMULA
            Console.WriteLine("\nDISTANCE(S) =>\t{0}" ,s);


            Console.ReadKey();
        }
    }
}
