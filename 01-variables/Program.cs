using System.Xml.Linq;

namespace _01_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LAS CONSTANTES DE DEBEN DE DECLARAR E INICIALIZAR DE LO CONTARIO DARA ERROR! 
            const int number = 100;
            Console.WriteLine("soy una constante :"+ number);

            // CONVERSION DE TIPOS DE DATOS
            /*
             CONVERISON IMPLICITA (automaticamente):
            conversion de un tipo más pequeño a un tamaño de letra más grande.
            char -> int -> long -> float -> double
            se realiza automaticamente al pasar unt tipo de tamaño mas pequeño a un tipo 
            de tamaño mas grande:
            */
            int myInt = 9;
            Console.WriteLine("soy de tipo de dato INT:" + myInt);
            Console.WriteLine(myInt.GetType().Name); // Int32
            double myDouble = myInt;
            Console.WriteLine("Soy de tipo datos double : "+ myDouble);
            Console.WriteLine(myDouble.GetType().Name); // Double
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            /*
            CONVERSION EXPLICITA(manualmente):
            conversion de un tipo más grande a un tipo de tamaño mas pequeño.
            double -> float -> long -> int -> char
            Debe de realizarce de manera manual colcando el tipo de dato entre parentesis () delante del valor
             */

            double myDouble2 = 65.49;
            int myInt2 = (int)myDouble2;
            Console.WriteLine("Soy 'double' ->"+myDouble2);
            Console.WriteLine("Soy 'int' -> "+myInt2);

            // usando Convert.ToInt32() -> redondea el numero decimal
            Console.WriteLine("Otra forma de convertir tipos de datos ->"+Convert.ToUInt16(myDouble2));
            Console.WriteLine("String : "+ Convert.ToString(myDouble2));
            Console.WriteLine(myDouble2 + myInt2);
        
        }
    }
}
