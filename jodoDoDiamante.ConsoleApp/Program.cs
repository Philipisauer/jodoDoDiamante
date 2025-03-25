using System.Data.SqlTypes;

namespace jodoDoDiamante.ConsoleApp
{
    internal class Program
    {
        //
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("~~~ Seja bem-vindo ao jogo dos diamante ~~~");

                Console.WriteLine("Informe o número IMPAR desejado: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                int numeroDeEspacos = numeroDigitado;


                if (numeroDigitado == 1)
                {
                    Console.WriteLine("Diamante: ");
                    Console.WriteLine("x");
                }

                if (numeroDigitado == 3)
                {
                    Console.WriteLine("Diamante: ");
                    Console.WriteLine(" x");
                    Console.WriteLine("xxx");
                    Console.WriteLine(" x");
                }

                if (numeroDigitado == 5)
                {
                    Console.WriteLine("Diamante: ");
                    Console.WriteLine("  x");
                    Console.WriteLine(" xxx");
                    Console.WriteLine("xxxxx");
                    Console.WriteLine(" xxx");
                    Console.WriteLine("  x");
                }



                Console.WriteLine("deseja continuar (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }   
        }
    }
}
