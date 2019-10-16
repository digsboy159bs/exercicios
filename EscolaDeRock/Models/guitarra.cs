using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class guitarra : instrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes da guitarra");
            return true;
        }
        public bool TocarSolo(){
            System.Console.WriteLine("tocando sol ona guitarra");
            return true;
        }
        
    }
}