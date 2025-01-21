namespace main
{
    internal class Program
    {
        int numero;
        int numero1 = 1, numero2 = 2, numero3 = 3, numero4 = 4, numero5 = 5, numero6 = 6, numero7 = 7;

        static void Main(string[] args)
        {

            Console.WriteLine("Inserte Valor del 1 al 7:");

            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1 && numero >= 7) ;

            if (numero == 1)
            {
                Console.WriteLine("Es LUNES!!!");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Es MARTES!!!");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Es MIERCOLES!!!");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Es JUEVES!!!");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Es VIERNES!!!");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Es SABADO!!!");
            }
            else if (numero == 7)
            {
                Console.WriteLine("Es DOMINGO");
            }
            else
            {
                Console.WriteLine("ERROR!!! Introduce un valor del 1 al 7 Por favor :(");
            }
        }
    }
}
