/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
•Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem diminui.
•Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de regeneração, do atacado, 
e dois modificadores, do atacante, (um para equipamentos e outro para habilidades), e calcule a vida restante.
@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        int dano, vida, regen;
        double modHab, modEq, total;

        System.Console.WriteLine("Escreva o total de vida");
        int.TryParse(Console.ReadLine(), out vida);
        System.Console.WriteLine("Escreva o total de dano recebido");
         int.TryParse(Console.ReadLine(), out dano);
         System.Console.WriteLine("Escreva o bonus de regeneração");
         int.TryParse(Console.ReadLine(), out regen);
         System.Console.WriteLine("Escreva o modificador de equipamento");
         double.TryParse(Console.ReadLine(), out modEq);
         System.Console.WriteLine("Escreva o modificador de habilidade");
         double.TryParse(Console.ReadLine(), out modHab);

         total = vida + regen - (dano * modEq * modHab);

         System.Console.WriteLine("Sua vida total é: " + total);
         
         System.Console.WriteLine("Aperte ENTER para fechar");
         Console.ReadLine();
         
    }
}