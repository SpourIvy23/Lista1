/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização:Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois 
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a 
distância total percorrida.
@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        int tempo, velocidade;
        double mC, mEv, total;

        Console.WriteLine("Digite a velocidade do veículo");
        int.TryParse(Console.ReadLine(), out velocidade);
        System.Console.WriteLine("Digite o tempo de viagem");
        int.TryParse(Console.ReadLine(), out tempo);
        System.Console.WriteLine("Digite o multiplicador climatico");
        double.TryParse(Console.ReadLine(), out mC);
        System.Console.WriteLine("Digite o multiplicador do estado do veículo");
        double.TryParse(Console.ReadLine(), out mEv);

        total = tempo * mC * mEv * velocidade;

        Console.Clear();

        System.Console.WriteLine("A distancia percorrida foi: " + total);
        
        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        
    }
}