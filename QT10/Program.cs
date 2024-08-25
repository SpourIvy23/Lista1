/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a 
cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida 
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.
@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 25/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int vida, aumento, level, total;

        System.Console.WriteLine("Digite quanto de vida você tem");
        int.TryParse(Console.ReadLine(), out vida);
        System.Console.WriteLine("Digite o nível alcançado");
        int.TryParse(Console.ReadLine(), out level);
       System.Console.WriteLine("Digite o aumento de vida por nível");
        int.TryParse(Console.ReadLine(), out aumento);

        total = vida + (aumento * level);
        Console.Clear();
        
        System.Console.WriteLine("O total de vida agora é: " + total);

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        

    }
}