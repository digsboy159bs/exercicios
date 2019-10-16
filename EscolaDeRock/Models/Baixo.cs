using System;
using EscolaDeRock.Interface;
namespace EscolaDeRock.Models {
    public class Baixo : instrumentoMusical, IPercussao, IHarmonia {
        public bool ManterRitmo () {
            System.Console.WriteLine (" mantendo o ritmo do baixo");
            return true;
        }

        public bool TocarAcordes () {
            System.Console.WriteLine ("tocando acordes do baixo");
            return true;
        }
    }
}