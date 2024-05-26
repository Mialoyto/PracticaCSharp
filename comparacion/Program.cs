namespace comparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            Console.WriteLine(x>y); // imprimira un valor booleano = true

            Console.WriteLine("----- OPERADORES LÓGICOS -----");

            Console.WriteLine(x<6 && x <10); // RETORNA UN VALOR BOOL = TRUE SI AMBOS VERDADEROS
            Console.WriteLine(x<6 || x >10); // RETORNA UN VALOR BOOL = TRUE SI UNO DE LOS ELEMENTOS ES VERDADERO
            Console.WriteLine("-- NEGACION --");
            Console.WriteLine(!(x<6 && x <10));
            Console.WriteLine(!(x<6 || x >10));
        }
    }
}
