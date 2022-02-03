using System;
using TesteGFT.financas;

class Program{
    static void Main(){
        Investimento invest1 = new Investimento(1000.00, 0.04);
        double lucro = invest1.calcularLucro(2);
        System.Console.WriteLine(lucro.2f);
    }
}