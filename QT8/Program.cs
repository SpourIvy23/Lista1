/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser 
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade 
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos
@Lista: 01 - Lógica de Programação
@Autor: Murilo Pires
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        int força, agilidade, inteligencia, destreza, vitalidade, pontos;


        Console.WriteLine("Digite os pontos de seus atributos começando por força");
        int.TryParse(Console.ReadLine(), out força);
        System.Console.WriteLine("Digite os pontos de agilidade");
        int.TryParse(Console.ReadLine(), out agilidade);
        System.Console.WriteLine("Digite os pontos de inteligencia");
        int.TryParse(Console.ReadLine(), out inteligencia);
        System.Console.WriteLine("Digite os pontos de destreza");
        int.TryParse(Console.ReadLine(), out destreza);
        System.Console.WriteLine("Digite os pontos de vitalidade");
        int.TryParse(Console.ReadLine(), out vitalidade);

        pontos = força + agilidade + inteligencia + destreza + vitalidade;
        Console.Clear();

        System.Console.WriteLine("Seus pontos de atributo são: \n" +
         "FORÇA: " + força + "\n" +
         "AGILIDADE: " + agilidade + "\n" +
         "INTELIGENCIA: " + inteligencia + "\n" +
         "DESTREZA: " + destreza + "\n" +
         "VITALIDADE: " + vitalidade + "\n" +
         "Seus pontos são: " + pontos + "\n");

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();


    }
}
