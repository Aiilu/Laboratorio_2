﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtString
    {
        public static void CantidadDeSignos(this string var, out int cant)
        {
            cant = 0;
            foreach(char car in var)
            {
                if(car == '.' || car == ',' || car == ';')
                {
                    cant++;
                }
            }
        }

        public static int CdS(this string var)
        {
            return var.Count(signos);
        }

        private static bool signos(char a)
        {
            return (a == '.' || a == ',' || a == ';');
        }
    }
}
