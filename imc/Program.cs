using System;

namespace imc {
    class Program {
        static void Main (string[] args) {
            double peso;
            double altura;
            double imc;

            System.Console.WriteLine ("qual o seu nome");
            string nome = Console.ReadLine ();

            System.Console.WriteLine ("qual seu peso em kg");
            peso = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("qual a altura em metros");
            altura = double.Parse (Console.ReadLine ());

            imc = peso / (altura * altura);

            System.Console.WriteLine ($"{nome} o seu imc é " + imc);

            if (imc < 20) {
                System.Console.WriteLine ("abaixo do peso");
            } else
            if ((imc >= 20) && (imc <= 25)) {
                System.Console.WriteLine ("normal");

            } else
            if ((imc > 25) && (imc <= 30)) {
                System.Console.WriteLine ("excesso de peso");
            } else
            if ((imc > 30) && (imc <= 35)) {
                System.Console.WriteLine ("obesidade");
            } else
            if (imc > 35) {
                System.Console.WriteLine ("obesidade mórbida");
            }
        }
    }
}