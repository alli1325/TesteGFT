using System;
using System.Collections.Generic;
using System.Linq;

class Lista {
    static void Main(){

        int[] valores = new int[10];
        for(int i=0;i<valores.Length;i++){
            Console.Write("Digite número: ");
            valores[i] = int.Parse(Console.ReadLine());
        }

        var minimo = valores.Min();
        var maximo = valores.Max();
        var media = valores.Average();

        System.Console.WriteLine("Mínimo: {0}" , minimo);
        System.Console.WriteLine("Maximo: {0}" , maximo);
        System.Console.WriteLine("Media: {0}" , media);


    }
}