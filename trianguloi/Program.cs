using System;

namespace Triangulo {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Digite o tamanho do triângulo: ");
            int tamanhoTriangulo = int.Parse (Console.ReadLine ());

            for (int i = 0; i <= tamanhoTriangulo; i++) {
                for (int j = i; j < tamanhoTriangulo; j++) {
                    System.Console.Write ("*");
                }
                Console.WriteLine ();
            }
        }
    }
}