using System; // Importa o namespace System, que contém funcionalidades básicas como Console

class Aula03 // Define uma classe chamada Aula03
{
    static void Main() // Método principal, ponto de entrada do programa
    {
        byte n1 = 10; // Declara uma variável do tipo byte e atribui o valor 10
        int num = -10; // Declara uma variável do tipo int e atribui o valor -10
        char letra = 'c'; // Declara uma variável do tipo char e atribui o caractere 'c'
        float valor = 5.3f; // Declara uma variável do tipo float e atribui o valor 5.3
        string nome = "Lucas"; // Declara uma variável do tipo string e atribui "Lucas"

        var aux = 10; // Declara uma variável com inferência de tipo e atribui 10

        //Console.WriteLine(aux); // Exibe o valor da variável aux no console

        int num1, num2, res; // Declara três variáveis do tipo int

        num1 - 10; // Esta linha não faz nada (possível erro, deveria ser atribuição)
        num2 - 2; // Esta linha não faz nada (possível erro, deveria ser atribuição)
        res = num * num2; // Multiplica num por num2 e armazena o resultado em res

        Console.WriteLine("A multiplicação de  " + num1 + " mais " + num2 + " é igual a " + res); // Exibe o resultado no console
    }
}