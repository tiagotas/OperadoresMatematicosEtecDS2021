using System;

namespace OperadoresMatematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /**
                 * Numeros em C#
                 * Int       => numero inteiro.
                 * Double
                 * Decimal
                 * Float
                 * 1,999999999999 (float)
                 * 1,9999999999999999999999999999999999999 (decimal)
                 * 1,9999999999999999999999999999999999999999999999999999999999999999999999 (double)
                 * 1,9999999999999999999999999999999999999999999999999999999999999999999999 (double)
                 */

                double numero_qualquer;

                Console.WriteLine("Digite um número qualquer: ");
                numero_qualquer = Convert.ToDouble(Console.ReadLine());

                // numero_qualquer = -20

                // Testando se é negativo ou positivo.
                if (numero_qualquer > 0)
                {
                    Console.WriteLine("Você digitou um número positivo.");

                }
                else if (numero_qualquer < 0)
                {
                    Console.WriteLine("Você digitou um número negativo.");

                }
                else /*if(numero_qualquer == 0)*/
                {
                    Console.WriteLine("Você digitou zero.");
                }

                // Testando se par ou impar
                double resto = numero_qualquer % 2;

                Console.WriteLine("O resto da divisão é {0} ", resto);


                if (resto == 0)
                {
                    Console.WriteLine("O número digitado é par.");

                }
                else
                {
                    Console.WriteLine("O número digitado é impar.");
                }

            } catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar apenas números.");
                
            } catch(Exception ex)
            {
                Console.WriteLine("Deu erro: {0} ", ex.Message);
            }   

            Console.ReadKey();
        }
    }
}
