/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
• Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma 
batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o 
jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual 
do personagem.
• Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido 
pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada 
tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total 
acumulado após a batalha e determinar o nível atual do jogador.
@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        int xpA, xpInimigo1, derrotados1, xpInimigos2, derrotados2, constante, xpTotal, level;

        Console.WriteLine("Quanto de Xp você tem acumulado?");
        int.TryParse(Console.ReadLine(), out xpA);
        System.Console.WriteLine("Quanto é o Xp do inimigo?");
        int.TryParse(Console.ReadLine(), out xpInimigo1);
        System.Console.WriteLine("Quantos foram derrotados?");
        int.TryParse(Console.ReadLine(), out derrotados1);

        System.Console.WriteLine("Quanto é o Xp dos segundos inimigos derrotados?");
        int.TryParse(Console.ReadLine(), out xpInimigos2);
        System.Console.WriteLine("Quantos foram derrotados?");
        int.TryParse(Console.ReadLine(), out derrotados2);
        System.Console.WriteLine("Qual a constante de Nível?");
        int.TryParse(Console.ReadLine(), out constante);

        xpTotal = xpA + (xpInimigo1 * derrotados1) + (xpInimigos2 * derrotados2);
        level = xpTotal / constante ;

        Console.Clear();
        

        System.Console.WriteLine("Seu XP total é: " + xpTotal + "\n" +
        "Seu nível é: " + level);

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
    





    }
}