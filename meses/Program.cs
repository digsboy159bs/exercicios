using System;

namespace meses {
    class Program {
        static void Main (string[] args) {
            int num;

            do {

                System.Console.WriteLine ("Digite um numero de 1 a 12 ");
                num = int.Parse (Console.ReadLine ());

                if (num == 1) {
                    System.Console.WriteLine (" o mes correspondente é janeiro");
                } else
                if (num == 2) {
                    System.Console.WriteLine (" o mes correspondente é fevereiro");

                } else
                if (num == 3) {
                    System.Console.WriteLine (" o mes correspondente é março");
                } else
                if (num == 4) {
                    System.Console.WriteLine (" o mes correspondente é abril");
                } else
                if (num == 5) {
                    System.Console.WriteLine (" o mes correspondente é maio");
                } else
                if (num == 6) {
                    System.Console.WriteLine (" o mes correspondente é junho");
                } else
                if (num == 7) {
                    System.Console.WriteLine (" o mes correspondente é julho");
                } else
                if (num == 8) {
                    System.Console.WriteLine (" o mes correspondente é agosto");
                } else
                if (num == 9) {
                    System.Console.WriteLine (" o mes correspondente é setembro");
                } else
                if (num == 10) {
                    System.Console.WriteLine (" o mes correspondente é outubro");
                } else
                if (num == 11) {
                    System.Console.WriteLine (" o mes correspondente é novembro");
                } else
                if (num == 12) {
                    System.Console.WriteLine (" o mes correspondente é dezembro");
                } else {
                    System.Console.WriteLine ("nao existe mes com esse numero");
                }
            } while (num > 12);

        }
    }
}