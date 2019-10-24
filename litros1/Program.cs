using System;

namespace litros1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo;
            double vm;
            double distancia;
            double litros;

            System.Console.WriteLine("quanto tempo foi gasto na viagem em minutos");
            tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("qual a velocidade media");
            vm = double.Parse(Console.ReadLine());

            distancia = (tempo * vm); 
            litros = (distancia/12);

            System.Console.WriteLine($"a distancia é {distancia} km ");
            System.Console.WriteLine($"a quantidade de litros gastos foi {litros} litros ");
        }
    }
}
