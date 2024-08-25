/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Murilo Pires
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        string? nome, classe, raca;
        int idade, nivel;
        
        System.Console.WriteLine("Escreva o nome do seu personagem");
        nome = Console.ReadLine();
        System.Console.WriteLine("Escreva a idade do seu personagem");
        int.TryParse(Console.ReadLine(), out idade);
        System.Console.WriteLine("Escreva seu nível");
        int.TryParse(Console.ReadLine(), out nivel);
        System.Console.WriteLine("Escreva sua classe");
        classe = Console.ReadLine();
        System.Console.WriteLine("Escreva sua raça");
        raca = Console.ReadLine();
        Console.Clear();
        

        System.Console.WriteLine("Dados do seu personagem são: \n" +
     "NOME: " + nome + "\n" +
     "IDADE: " + idade + "\n" +
     "NÍVEL: " + nivel + "\n" +
     "CLASSE: " + classe + "\n" +
     "RAÇA: " + raca + "\n");

     System.Console.WriteLine("\n Aperte ENTER para fechar.");

     Console.ReadLine();
     

    }
}