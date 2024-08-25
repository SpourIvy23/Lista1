/*-------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque
• Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em 
sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos 
e pelo tipo da arma.
• Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de 
Comando: habilidades, um modificador de crítico, e um modificador para o tipo da arma. O 
programa deve calcular o total de ataque do personagem
@Lista: 01 - Lógica de Programação
@Autor: Murilo Pires
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        double força, arma, bonHab, modCrit, modArma, total;

        Console.WriteLine("Digite quanto de força você tem");
        double.TryParse(Console.ReadLine(), out força);
        System.Console.WriteLine("Digite o poder da sua arma");
        double.TryParse(Console.ReadLine(), out arma);
        System.Console.WriteLine("Insira o bonus de habilidade");
        double.TryParse(Console.ReadLine(), out bonHab);
        System.Console.WriteLine("Insira o modificador de critico");
        double.TryParse(Console.ReadLine(), out modCrit);
        System.Console.WriteLine("Insira o modificador de arma");
        double.TryParse(Console.ReadLine(), out modArma);

        total = força + (arma * bonHab * modCrit * modArma);
        Console.Clear();
        
        System.Console.WriteLine("Seu total de força é: " + total);

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        
    }
}