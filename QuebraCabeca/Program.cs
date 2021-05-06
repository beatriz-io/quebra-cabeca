using System;
using System.Collections.Generic;
using System.Text;


namespace Payments
{
    class Program
    {
        static List<string> Pecas = new List<string>();
        static List<string> PecasNaOrdem = new List<string>();

        static void Main(string[] args)
        {
            RecebePecas();

            PreenchePrimeiroValor();

            PreencheLista();

            MontaPalavraFinal();
        }

        static void RecebePecas()
        {
            Console.WriteLine("Digite o numero de peças: ");
            short tamanho = short.Parse(Console.ReadLine());

            Console.WriteLine("Digite as peças a seguir: ");

            for (int i = 0; i < tamanho; i++)
            {
                Pecas.Add(Console.ReadLine());
            }
        }

        static void PreenchePrimeiroValor()
        {
            for (int i = 0; i < Pecas.Count; i++)
            {
                if (Pecas[i].Split(" ")[0] == "0")
                {
                    PecasNaOrdem.Add(Pecas[i]);
                    break;
                }
            }
        }

        static void PreencheLista()
        {
            for (int j = 0; j < PecasNaOrdem.Count; j++)
            {
                for (int i = 0; i < Pecas.Count; i++)
                {
                    if (PecasNaOrdem[j].Split(" ")[2] == Pecas[i].Split(" ")[0])
                    {
                        PecasNaOrdem.Add(Pecas[i]);
                        break;
                    }

                    if (PecasNaOrdem.Count > Pecas.Count)
                    {
                        Console.WriteLine("As peças não estão em um padrão que funcione.");
                        return;
                    }
                }
            }
        }

        static void MontaPalavraFinal()
        {
            var palavraFinal = new StringBuilder();

            if (PecasNaOrdem[PecasNaOrdem.Count - 1].Split(" ")[2] == "1")
            {
                foreach (var item in PecasNaOrdem)
                {
                    palavraFinal.Append(item.Split(" ")[1]);
                }
                Console.WriteLine($"A Palavra é: {palavraFinal}");
            }
            else
            {
                Console.WriteLine("Houve um problema com a geração da palavra");
            }
        }
    }
}
