using System;


namespace tabla_o_numeros_del_1_al_50
{
    class Program
    {
        static void Main(string[] args)
        {
            double opc;
            int n, total;

            do
            {
                Console.WriteLine("que deseas hacer: ");
                Console.WriteLine("1. Imprimir la tabla de multiplicar de un numero");
                Console.WriteLine("2. imprimir los numeros del 1 al 50 ecepto el 25");
                Console.WriteLine("3. salir del programa");
                opc = double.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("ingresa un numero");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= 10; i++)
                        {
                            total = n * i;
                            Console.WriteLine(" " + n + " * " + i + " = " + total);

                        }

                        break;

                    case 2:
                        for (int num = 1; num < 25; num++)
                        {
                            Console.Write(" " + num);
                        }
                        for (int num = 26; num <= 50; num++)
                        {
                            Console.Write(" " + num);
                        }

                        break;

                    default:
                        Console.WriteLine("saliendo del programa...........");
                        break;

                }
                Console.ReadKey();
                Console.Clear();

            } while (opc != 3);
            

           
            
        }
    }
    
}
