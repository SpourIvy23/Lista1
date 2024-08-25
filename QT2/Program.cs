/*-------------------------------------------------------------------
Questão 2: Pontuação Final
•
Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com base nos inimigos derrotados e pontos adicionais.
•Comando: Desenvolva um programa que receba o número de inimigos derrotados, 
a pontuação por inimigo, bônus por missão, e dois multiplicadores 
(um para tipo de inimigo e outro para dificuldade), e então calcule e exiba a pontuação final.
@Lista: 01 - Lógica de Programação
@Autor: Murilo Pires 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int inimigos, pontosInimigo, missao;
        double multDif, multBonus, pontosFinais;
        
        Console.WriteLine("escreva quantos inimigos foram derrotados");
        int.TryParse(Console.ReadLine(), out inimigos);
        Console.WriteLine("Quantos pontos por inimigo?");
        int.TryParse(Console.ReadLine(), out pontosInimigo);
        System.Console.WriteLine("Quanto foi o bonus de missão?");
        int.TryParse(Console.ReadLine(), out missao);

        System.Console.WriteLine("Qual foi o multiplicador de bonus?");
        double.TryParse(Console.ReadLine(), out multBonus);
        System.Console.WriteLine("Qual foi o multiplicador de dificuldade?");
        double.TryParse(Console.ReadLine(), out multDif);

        pontosFinais = inimigos * pontosInimigo * multBonus * multDif + missao;

        System.Console.WriteLine("Sua pontuação final é: " + pontosFinais);

        System.Console.WriteLine(" \n Aperte ENTER para fechar");
        Console.ReadLine();
        
        

        
    }
}