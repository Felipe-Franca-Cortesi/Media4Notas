using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal notaUm, notaDois, notaTres, notaQuatro, mediaFinal;
            string textoNotaUm, textoNotaDois, textoNotaTres, textoNotaQuatro;
            bool notaUmValida, notaDoisValida, notaTresValida, notaQuatroValida;

            Console.Clear();
            Console.WriteLine("--- Média\n");
            Console.WriteLine("Digite as suas notas abaixo");

            Console.Write("Nota um: ");
            textoNotaUm = Console.ReadLine();
            
            Console.Write("Nota dois: ");
            textoNotaDois = Console.ReadLine();

            Console.Write("Nota três: ");
            textoNotaTres = Console.ReadLine();

            Console.Write("Nota quatro: ");
            textoNotaQuatro = Console.ReadLine();

            notaUmValida = decimal.TryParse(textoNotaUm, out notaUm);
            notaDoisValida = decimal.TryParse(textoNotaDois, out notaDois);
            notaTresValida = decimal.TryParse(textoNotaTres, out notaTres);
            notaQuatroValida = decimal.TryParse(textoNotaQuatro, out notaQuatro);

            mediaFinal = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            if (!notaUmValida || !notaDoisValida || !notaTresValida || !notaQuatroValida)
            {
                Console.WriteLine("Valor digitado inválido.");
            }
            else if (notaUm < 0.0m || notaUm > 10.0m)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
            }
            else if (notaDois < 0.0m || notaDois > 10.0m)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
            }
            else if (notaTres < 0.0m || notaTres > 10.0m)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
            }
            else if (notaQuatro < 0.0m || notaQuatro > 10.0m)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
            }
            else if (mediaFinal > 6.0m)
            {
                Console.WriteLine($"Você ficou com média {mediaFinal}. Resultado: Aprovado");
            }
            else if (mediaFinal < 5.0m)
            {
                Console.WriteLine($"Você ficou com média {mediaFinal}. Resultado: Reprovado");
            }
            else if (mediaFinal >= 5.0m && mediaFinal <= 6.0m)
            {
                Console.WriteLine($"Você ficou com média {mediaFinal}. Resultado: Em recuperação");
            }
            
        }
    }
}
