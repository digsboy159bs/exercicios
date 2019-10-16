using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Contrabaixo: instrumentoMusical,IPercussao,IHarmonia
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo do contra baixo");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("tocando acordes de contrabaixo");
            return true;
        }
        
    }
}