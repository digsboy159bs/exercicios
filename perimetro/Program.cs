using System;

namespace perimetro {
    class Program {
        static void Main (string[] args) {
            double Base = 0;
            double Altura = 0;
            double perimetro = 0 ;
            double area = 0 ;
            
            System.Console.WriteLine ("qual a base do retangulo");
            Base = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("qual a altura do retangulo");
            Altura = double.Parse (Console.ReadLine ());

            perimetro = (Base * 2)+ (Altura * 2);
            area = ( Base * Altura);

            System.Console.WriteLine(" o perimetro é  " + perimetro);
            System.Console.WriteLine(" a area é  " + area);
            
            

        }
    }
}