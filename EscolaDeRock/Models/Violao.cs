using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models

{
    public class Violao : instrumentoMusical, IHarmonia, IPercussao
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo no violao");
            return true;
        }
        public bool TocarSolo(){
            System.Console.WriteLine("tocando solo no violao");
            return true;
        }
        public bool TocarAcordes(){
            Console.WriteLine("Tocando acordes do violao");
            return true;
        }
    }
}