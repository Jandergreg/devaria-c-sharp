using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            // Comentario linha

            /*
             * Comentario com mais de uma linha
             */
            const string constante = "Uma constante que não muda";

            if(argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar número inteiro");
                return;
            }

            int inteiro;
            bool teste = int.TryParse(argumentos[0], out inteiro);

            if(teste == false)
            {
                Console.WriteLine("O argumento informado não é um número inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi:" + inteiro);

        }
    }
}
