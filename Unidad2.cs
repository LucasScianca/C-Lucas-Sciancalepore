using System;
public class Ejemplo_2_1
{
    public static void Main()
    {
/*      int numero;
      Console.WriteLine("Ingrese un número");
      numero = Convert.ToInt32(Console.ReadLine());
    if (numero>0)
        {
          Console.WriteLine("El número es mayor a cero");
          Console.WriteLine("También podés usar números negativos");
        }
        else Console.WriteLine("El número no es mayor a cero");
      {  
      if (numero !=2)
        Console.WriteLine("El número no es 2");
      }
      {        
      if (numero > 0)
        Console.WriteLine("El número es mayor a 0");
      else
       Console.WriteLine("El número no es mayor a 0");
        if (numero > 0)
          Console.WriteLine("El número es mayor a 0");
        if (numero == 0)
          Console.WriteLine("El número no es mayor a 0");
      {  
      if (numero <= 10)
            Console.WriteLine("El número es menor o igual a 10");
          else
            if (numero < 5)
              Console.WriteLine("El número es menor a 5");
            else
              Console.WriteLine("Ya me perdí qué número soy");
      }
*/    int numero1, numero2;
      Console.WriteLine("Ingrese un primer número");
      numero1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese otro número");
      numero2 = Convert.ToInt32(Console.ReadLine());

      if ((numero1 > 0) && (numero2 > 0))
        Console.WriteLine("Los dos números son positivos");
      else
        Console.WriteLine("No sabemos cual es positivo y cual no");     
            
    }
}