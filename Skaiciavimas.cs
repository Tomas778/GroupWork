using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork
{
    public class Skaiciavimas
    {
        public double Kintamasis1()  //Inesa
        {
            double pi = 3.14;
            double r = 6371;
            double sum = pi * r;
            double result = Math.Pow(sum, 2);
            //Console.WriteLine("zemes rutulio plotas yra :" + result);
            return result;
        }

        public double Kintamasis2() //Nerijus
        {
            double pi = 3.1415926535f, r = 6371, V;
            V = 4f / 3f * pi * (r * r * r);
            return V;
        }

        public double Kintamasis3() //Tomas
        {
            double a = 10.0, b = 15.0, c;
            c= Math.Round(Math.Sqrt(a*a + b*b), 2);
            return c;
        }

        public void Paskutinis() //Tomas
        {
            double kintamasis1 = Kintamasis1();
            double kintamasis2 = Kintamasis2();
            double kintamasis3 = Kintamasis3();

            Console.WriteLine("Viso kintamuju: 3");
            Console.WriteLine("Kintamasis1: " + kintamasis1);
            Console.WriteLine("Kintamasis2: " + kintamasis2);
            Console.WriteLine("Kintamasis3: " + kintamasis3);

             double suma = kintamasis1 + kintamasis2 + kintamasis3;
             double vidurkis = kintamasis1 + kintamasis2 + kintamasis3 / 3;
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Vidurkis: " + vidurkis);

        }

    }
}
