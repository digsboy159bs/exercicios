using System;

namespace Planetas {
    class Program {
        static void Main (string[] args) {
            string Planeta = "";
            do {

                Console.WriteLine ("Calculo peso");
                Console.WriteLine ("1 - mercurio");
                Console.WriteLine ("2 - venus");
                Console.WriteLine ("3 - marte ");
                Console.WriteLine ("4 - jupiter");
                Console.WriteLine ("5 - saturno ");
                Console.WriteLine ("6 - urano");

                Console.WriteLine ("fim para terminar.");
                Console.Write ("Selecione uma planeta: ");
                Planeta = Console.ReadLine ();

                switch (Planeta) {
                    case "1":
                        Console.Write ("Qual o seu peso na terra ");
                        double Pterra = double.Parse (Console.ReadLine ());
                        double Gravidade = 0.37;
                        double Pmercurio = (Pterra / 10) * Gravidade;
                        Console.WriteLine ("o seu peso em mercurio é: " + Pmercurio);
                        break;
                    case "2":
                        Console.Write ("Qual o seu peso na terra ");
                        double Pterra1 = double.Parse (Console.ReadLine ());
                        double Gravidade1 = 0.88;
                        double Pvenus = (Pterra1 / 10) * Gravidade1;
                        Console.WriteLine ("o seu peso em venus é: " + Pvenus);
                        break;
                    case "3":
                        Console.Write ("Qual o seu peso na terra ");
                        double Pterra2 = double.Parse (Console.ReadLine ());
                        double Gravidade2 = 0.38;
                        double Pmarte = (Pterra2 / 10) * Gravidade2;
                        Console.WriteLine ("o seu peso em marte é: " + Pmarte);
                        break;
                    case "4":
                        Console.Write ("Qual o seu peso na terra ");
                        double Pterra3 = double.Parse (Console.ReadLine ());
                        double Gravidade3 = 2.64;
                        double Pjupiter = (Pterra3 / 10) * Gravidade3;
                        Console.WriteLine ("o seu peso em Jupiter é: " + Pjupiter);
                        break;
                    case "5":
                        Console.Write ("Qual o seu peso na terra ");
                        double Pterra4 = double.Parse (Console.ReadLine ());
                        double Gravidade4 = 1.15;
                        double Psaturno = (Pterra4 / 10) * Gravidade4;
                        Console.WriteLine ("o seu peso em saturno é: " + Psaturno);
                        break;
                    case "6":
                        Console.Write ("Qual o seu peso na terra ");
                        double Pterra5 = double.Parse (Console.ReadLine ());
                        double Gravidade5 = 1.17;
                        double Purano = (Pterra5 / 10) * Gravidade5;
                        Console.WriteLine ("o seu peso em mercurio é: " + Purano);
                        break;
                }
                Console.WriteLine ();
            } while (Planeta != "fim");
        }
    }
}