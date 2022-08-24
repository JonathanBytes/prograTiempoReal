int orden;
System.Console.Write("Ingrese el orden del polinomio: ");
orden = Convert.ToInt32(Console.ReadLine());

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
