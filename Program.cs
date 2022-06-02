using System;

namespace Ejercicios_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Hacer un programa para mostrar los números del 1 al 10.No se debe realizar ningún pedido de datos
            Console.WriteLine("Hacer un programa para mostrar los números del 1 al 10.No se debe realizar ningún pedido de datos");

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }

            //2.Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
            //Solo se debe emitir UN valor por pantalla
            Console.WriteLine("2.Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla");
            Console.WriteLine("Solo se debe emitir UN valor por pantalla");

            int num, mayor = 0;

            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("Ingresar un numero");
                num = int.Parse(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }
            }

            Console.WriteLine("El numero mayor es : " + mayor);

            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años
            Console.WriteLine("3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años");

            int edades, acum = 0;
            float promedio, con = 0;


         
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("ingresar edad");
                    edades = int.Parse(Console.ReadLine());

                    if (edades > 18)
                    {
                        acum += edades;
                        con++;
                }

                }

            promedio = acum / con;
            Console.WriteLine("El promedio de edades es : " + promedio);


            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo 
            Console.WriteLine("4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo ");

            int n, contador;

                Console.WriteLine("Ingresar un numero (corta con -1)");
                n = int.Parse(Console.ReadLine());

            while (n!=-1)
            {
                contador = 0;

                for (int x = 1; x <= n; x++)
                {
                        if (n%x == 0)
                        {
                             contador++;
                        }                             
                }

                if (contador == 2)
                {
                    Console.WriteLine("Este numero es primo");
                }

                Console.WriteLine("Ingresar otro numero (corta con -1) ");
                n = int.Parse(Console.ReadLine());
            }


            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares
            Console.WriteLine("5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares");
 
            
            int nu, max = 0, min = 0;
            bool notengoMaximo = true, notengoMinimo = true;

            for (int z = 0; z < 20; z++)
            {

                Console.WriteLine("Ingresar un numero");
                nu = int.Parse(Console.ReadLine());

            if (nu % 2 == 0)
            {
               
                if (notengoMaximo)
                {
                    max = nu;
                    notengoMaximo = false;
                } 
                
                    else if ( nu > max)
                    {
                              max = nu;
                    }
            }
            else
            {          
                    if (notengoMinimo)
                    {
                        min = nu;
                        notengoMinimo = false; 

                    } else if ( nu < min)
                        {
                               min = nu;
                        }
             }
          }
                 Console.WriteLine("El numero mayor par es : " + max);
                 Console.WriteLine("El numero menor impar es : " + min);
                 Console.WriteLine("Fin del programa");
       }
    }
}
