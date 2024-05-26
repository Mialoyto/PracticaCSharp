using System;

namespace _02_input
{
    internal class Program
    {
        static void Main(string[] args)

            // ejemplo basico
        {
            Console.Write("Ingrese su usuario :");

            string userName =Console.ReadLine();

            Console.WriteLine("Username is :" + userName);
            Console.WriteLine("------------------------------------------------------------------------------------");
            // ejemplo oque daria error

            Console.Write("Ingrese su Edad :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su edad es :" +age);


            Console.WriteLine("----------------------------------------OPERADORES MATEMATICOS---------------------------------------");
            // LOS OPERADORES BASICO YA SE SABE COMO (+, -, /, *)

            // modulo '%' -> retorna el resto de la division

            Console.Write("Valor de a :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor de b :");

            int b = Convert.ToInt32(Console.ReadLine());

            double r = a % b;
            Console.WriteLine("El resto de la division es : " +r);

            // incremento '++'
                int valor =0;
                
                while (valor <10)
                {
                Console.WriteLine("su valor es : "+ valor);
                valor++;
                
                }

            // decremento
            int i = 10;

            while(i>0)
            {
                Console.WriteLine("El valor de i : "+ i);
                i--;
            }


        }
    }
}
