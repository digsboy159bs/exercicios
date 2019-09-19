using System;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
             double nota1 ;
            double nota2 ;
            double nota3 ;
              double nota4 ;
             double media;
        Console.Write("digite a nota1:");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("digite a nota2:");
        nota2 = double.Parse(Console.ReadLine());
        Console.Write("digite a nota3:");
        nota3 = double.Parse(Console.ReadLine());
        Console.Write("digite a nota4:");
        nota4 = double.Parse(Console.ReadLine());
        
        media= (nota1 + nota2 + nota3 + nota4) / 4  ;
        Console.WriteLine("sua media é " + media);
      
        if(media>=7)
        Console.WriteLine("aprovado");
        else
        
        Console.WriteLine("reprovado");
        
         }
    }
}
