using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum filtyper
    {
        csv,
        pdf,
        txt
    }

    class Program
    {        enum filtyper
        {
            csv,
            pdf,
            txt
        };

        struct Person
        {
            public int Id;
            public string Navn;
        };

        static void Main(string[] args)
        {               
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            filtyper ft = filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine(Convert.ToInt32(ft));

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Tryk på en tast...");
                Console.ReadKey();
            }





        }

    }
}
