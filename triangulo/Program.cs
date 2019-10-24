using System;

namespace triangulo {
    class Program {
        static void Main (string[] args) {
            int num;
            int num2;
            int num3;
            int soma1;
            int soma2;
            int soma3;

            System.Console.WriteLine ("digite o 1° numero");
            num = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("digite o 2° numero");
            num2 = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("digite o 3° numero");
            num3 = int.Parse (Console.ReadLine ());

            soma1 = (num+num2);
            soma2 = (num+num3);
            soma3 = (num2+num3);

            if((num<soma3)&&(num2<soma2)&&(num3<soma1)){
                System.Console.WriteLine("podem ser lados de um triangulo");
            }else
            if((num>=soma3)||(num2>=soma2)||(num3>=soma1)){
                System.Console.WriteLine("nao podem ser lados de um triangulo");
            }

            
        }
    }
}