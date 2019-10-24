using System;

namespace Graus {
    class Program {
        static void Main (string[] args) {

            double grausc;
            double grausf;

            System.Console.WriteLine ("digite a temperatura em graus celcius");
            grausc = double.Parse (Console.ReadLine ());

            grausf = (grausc / 5 * 9) + 32;

            System.Console.WriteLine ("a temperatura em farenhight é  " + grausf);

        }
    }
}