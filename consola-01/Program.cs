using System;


namespace consola_01
{
    // DECLARACION DE LA CLASE
    public class Program
    {
        static void Main(string[] args)
        {

            // SUMA
            Console.WriteLine(3+3);

            // ESTRUCTURA REPITIVA FOR
            Console.WriteLine("CICLO for :");
            for( int i = 0; i < 10; i++ )
            {
                Console.WriteLine("Iteración : "+ i);
            }


            // ESTRUCTURA WHILE
            Console.WriteLine("CICLO while :");
            bool Valor = true;

            while ( Valor )
            {
                for( int i = 0;i < 10;i++ )
                {
                    
                    if( i < 5)
                    {
                        Console.WriteLine("ciclo while :" + i);
                    }
                    else
                    {
                        Valor = false;
                    }
                }
            }

            // ESTRUCTURA do while
            Console.WriteLine("ESTRUCTURA do while :");
            bool valor2 = true;
            do
            {
                for( int i = 0; i<10 ; i++)
                {
                    if (i < 5)
                    {
                        Console.WriteLine($"Hare esto hasta que valor2 cambie a false si i = {i}.  i < 5 cambia false");
                    }
                    else
                    {
                        valor2= false;
                    }
                }
            } while (valor2);

        }
    }
}
