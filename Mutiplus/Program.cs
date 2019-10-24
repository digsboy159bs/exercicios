using System;

namespace Mutiplus {
    class Program {
        static void Main (string[] args) {
            double num;
            do {
                Console.WriteLine ("digite um numero");
                num = double.Parse (Console.ReadLine ());

                if (num % 3 == 0) {
                    System.Console.WriteLine ("o numero é mutiplo de 3");
                } else {
                    System.Console.WriteLine ("nao é mutiplo");
                }

            } while (num != 0);
        }
    }
}