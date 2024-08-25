/*-------------------------------------------------------------------
Questão 4: • Contextualização:No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total 
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os
@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    { int primeiro, segundo, terceiro, quarto, quinto, total;
        Console.WriteLine("Digite o primeiro número de moedas coletadas");
        int.TryParse(Console.ReadLine(), out primeiro);
        System.Console.WriteLine("Digite o segundo número de moedas coletadas");
        int.TryParse(Console.ReadLine(), out segundo);
        System.Console.WriteLine("Escreva o terceiro número de moedas coletadas");
        int.TryParse(Console.ReadLine(), out terceiro);
        System.Console.WriteLine("Digite o quarto número de moedas coletadas");
        int.TryParse(Console.ReadLine(), out quarto);
        System.Console.WriteLine("Digite o quinto número de moedas coletadas");
        int.TryParse(Console.ReadLine(), out quinto);

        total = primeiro + segundo + terceiro + quarto + quinto;
        Console.Clear();
        System.Console.WriteLine("O total de moedas é:" + total);
        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        
    }
}