using System;

namespace IFTSN18Scianca
{
    public class Program
    {
        public static void Main()
        {
            int numero;
            Console.WriteLine("Por favor, ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("El número es positivo");
        }
    }
}
