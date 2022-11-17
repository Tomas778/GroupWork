using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("*******************\n\n");
            Skaiciavimas Musurez = new Skaiciavimas();
            //Musurez.Kintamasis1(); //call Inesa
            //Musurez.Kintamasis2(); //call Nerijus
            //Musurez.Kintamasis3(); //call Tomas

            Musurez.Paskutinis();// ?????

            Console.Write("*******************\n\n");
            Console.ReadKey();


        }
    }
}
