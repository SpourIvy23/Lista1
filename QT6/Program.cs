/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por 
cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de 
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos 
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.
@Lista: 01 - Lógica de Programação
@Autor: Murilo Pires
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;


class Program
{
    static void Main()
    {
        
        double bonEvento, bonHab, moedas, taxa, cristais;

        Console.WriteLine("Digite quantas moedas você quer converter");
        double.TryParse(Console.ReadLine(), out moedas);
        System.Console.WriteLine("Digite a taxa de conversão");
        double.TryParse(Console.ReadLine(), out taxa);
        System.Console.WriteLine("Insira o bonus de evento");
        double.TryParse(Console.ReadLine(), out bonEvento);
        System.Console.WriteLine("Insira o bonus de habilidade");
        double.TryParse(Console.ReadLine(), out bonHab);

        cristais = (moedas / taxa) * bonEvento * bonHab;
        Console.Clear();
        

        System.Console.WriteLine("Você tem: " + cristais + " Cristais");

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        

    }
}
