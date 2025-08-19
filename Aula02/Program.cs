using System; // Importa o namespace System, que contém funcionalidades básicas, como Console.

namespace Aula02 // Define um namespace chamado Aula02 para organizar o código.
{
    class Program // Declara uma classe chamada Program.
    {
        static void Main(string[] args) // Método principal, ponto de entrada do programa. Recebe argumentos da linha de comando.
        {
            Console.WriteLine("OLÁ MUNDO, CFB CURSOS"); // Exibe uma mensagem no console.

            if (args.GetLength(0) > 0) // Verifica se há argumentos passados na linha de comando.
            {
                Console.Write(args.GetValue(0)); // Exibe o primeiro argumento passado.
            }
        }
    }
}

//Parametros de entrada // Comentário indicando que o código trata de parâmetros de entrada.
