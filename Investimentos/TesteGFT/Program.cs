using System;
using TesteGFT.financas;

class Program{
    static void Main(){
        Investimento invest1 = new Investimento(1000.00, 0.04);
        InvestimentoComIR invest2 = new InvestimentoComIR(1000.00, 0.04);
        InvestimentoSemIR invest3 = new InvestimentoSemIR(900.00, 0.04);
        double lucro = invest1.calcularLucro(2);
        double lucro2 = invest2.calcularLucro(2);
        double lucro3 = invest3.calcularLucro(2);
        System.Console.WriteLine(lucro);
        System.Console.WriteLine(lucro2);
        System.Console.WriteLine(lucro3);
    }
}