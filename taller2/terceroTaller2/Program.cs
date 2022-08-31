int orden, equis;
bool continuar = true;

System.Console.Clear();

System.Console.Write("\nIngrese el orden del polinomio: ");
orden = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

double[] poly = new double[orden + 1];

for (int i = 0; i <= orden; i++)
{
    System.Console.Write("Ingrese la constante que acompaña x^{0}: ", orden - i);
    poly[orden - i] = Convert.ToDouble(Console.ReadLine());
}

foreach (double j in poly)
{
    System.Console.WriteLine(j);
}

System.Console.WriteLine("First position {0}", poly[0]);
System.Console.WriteLine("Third position {0}", poly[3]);

System.Console.WriteLine("\nIngrese el valor de x: ");
equis = Convert.ToInt32(Console.ReadLine());

System.Console.ReadKey();
System.Console.Clear();

do
{


    // Imprimir guía de coeficientes de equis
    for (int i = 0; i <= orden; i++)
    {
        System.Console.Write("x^{0}  ", orden - i);
    }
    // Imprimir coeficientes
    System.Console.WriteLine("\n");
    for (int i = 0; i <= orden; i++)
    {
        System.Console.Write("{0}    ", poly[i]);
    }
    System.Console.WriteLine("\n----------------------------");

    for (int i = 0; i < orden; i++)
    {
        System.Console.Write("{0}    ", poly[i] * equis + poly[i + 1]);
    }


    System.Console.ReadKey();
    System.Console.Clear();
} while (continuar == true);
