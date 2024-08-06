using System;
using System.Linq;

namespace Palindromo
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* 
             * 1. pega a string, coloca ela ao contrario e compara se sao iguais
             * 1.1 - trasformar em array de chars
             * 1.2 - inverter o array (novo array com o resultado)
             * 1.3 - transformar o array em string
             * 1.4 - comparar a palavra original e a reversa 
            */

            Console.WriteLine("Digite uma palavra para verificar se é um palíndromo ou não:");
            string palavra = Console.ReadLine();

            char[] arrayChars = palavra.ToCharArray();
            Array.Reverse(arrayChars);
            string reversa = new string(arrayChars);

            if (palavra == reversa)
            {
                Console.WriteLine("A palavra é um palíndromo!");
            }
            else
            {
                Console.WriteLine("Apalavra não é um palíndromo!");
            }

            /*2. Compara se a primeira e a ultima letra são iguais, depois se a segunda e a penultima letra são iguais e assim por diante
            2.1 - contar a quantidade de caracteres e dividir por 2 para saber quantas vezes sera necessário testar as letras até o meio da palavra
            2.2 - testar a primeira e ultima letra se sao iguais e removê-las
            2.3 - testar novamente e remover pelo numero de vezes definido em 2.1
            */

            Console.WriteLine("Digite uma palavra para verificar se é um palíndromo ou não:");
            string palavra2 = Console.ReadLine();

            char[] arrayChars2 = palavra2.ToCharArray();

            int numLetras = palavra2.Count();

            int contador = numLetras / 2;

            int repeticao = (int)contador;

            for (int i = 0; i < repeticao; i++)
            {
                var primeiraLetra = arrayChars2.First();
                var ultimaLetra = arrayChars2.Last();

                if (primeiraLetra == ultimaLetra)
                {
                    arrayChars2.shift();
                    arrayChars2.pop();

                }
            }




        }
    }
}
