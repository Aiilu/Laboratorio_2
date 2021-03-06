﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central 
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas 
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita. 
            // La centralita mostrará por pantalla todas las llamadas una vez ordenadas. 

            try
            {
                c = c + l1;

                l1.Guardar();

                c = c + l2;

                l2.Guardar();

                c = c + l3;

                l3.Guardar();

                c = c + l4;

                l4.Guardar();
            }
            catch(CentralitaException ex)
            {
                Console.WriteLine(ex.Message + " Ya se encuentra cargada");
                Console.WriteLine();
            }

            c.OrdenarLlamadas();

            Console.WriteLine(c.Leer());

            Console.WriteLine("-------------------------");

            Console.WriteLine(l1.Leer());
            Console.WriteLine(l2.Leer());
            Console.WriteLine(l3.Leer());
            Console.WriteLine(l4.Leer());

            Console.ReadKey();
        }
    }
}
