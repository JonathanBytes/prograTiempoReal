using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace parte2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
        int j;
        int[] vocales= {0,0,0,0,0};
        int c;
        int vocales1 = 0;

        Console.Write("Introduzca una cadena: ");
        cadena=Console.ReadLine();


        for (int i =1; i< cadena.Length;i++)
        {
            c=cadena[i];
            
            if ( c == 'a')
                {
                    vocales[0]+=1;
                    vocales1++;
                }
            if (c=='e')
                {
                    vocales[1]+=1;
                    vocales1++;
                }
            if (c=='i')
                {
                    vocales[2]+=1;
                    vocales1++;
                }
            if (c=='o')
                {
                    vocales[3]+=1;
                    vocales1++;
                }
            if (c=='u')
                {
                    vocales[4]+=1;
                    vocales1++;
                }

        }

            Console.WriteLine("El numero de vocales es: " + vocales1);
            Console.WriteLine("Existen {0} vocales A", vocales[0]);
            Console.WriteLine("Existen {0} vocales E", vocales[1]);
            Console.WriteLine("Existen {0} vocales I", vocales[2]);
            Console.WriteLine("Existen {0} vocales O", vocales[3]);
            Console.WriteLine("Existen {0} vocales U", vocales[4]);
            Console.ReadKey();

        }
    }
}
