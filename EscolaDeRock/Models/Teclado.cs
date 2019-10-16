using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Teclado : instrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes(){
            System.Console.WriteLine("tocando acordes do teclado");
            return true;
        }
        public bool TocarSolo(){
            System.Console.WriteLine("tocando solo no teclado");
            return true;
        }
    }
}