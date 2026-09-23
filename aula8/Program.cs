using System;

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        // Console.WriteLine("Digite seu nome: ");
        // nome = Console.ReadLine();
        // Console.WriteLine("Seu nome é {0}", nome);

        Console.WriteLine("Qual o primeiro número?");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o segundo número?");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma de {0} mais {1}, é igual a {2}",v1,v2,soma);
    }
}