using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З_к_уроку_3_Кирсанов_Николай_задание_1.б //Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
{
    class Complex
    {
        private double a, b;

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;

        }

        public override string ToString()
        {
            return (0 > b) ? $"{a} - {-b}i" : $"{a} + {b}i";          
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex(
                a: z1.a * z2.a,
                b: z1.b * z2.b
                );
        }
        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(
                a: z1.a - z2.a,
                b: z1.b - z2.b
                );
        }
    }



    class Program
    {

        static void Main()
        {
            Complex z1 = new Complex(a: 24, b: 354);



            Complex z2 = new Complex(a: 6, b: -87);


            Complex d = z1 - z2;
            Complex u = z1 * z2;

            Console.WriteLine($"({z1}) - ({z2}) = {d}");
            Console.WriteLine($"({z1}) * ({z2}) = {u}");
            Console.WriteLine(d);
            Console.WriteLine(u);
            Console.ReadLine();

        }

    }
}