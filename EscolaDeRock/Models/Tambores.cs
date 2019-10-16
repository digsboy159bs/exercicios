using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Tambores : instrumentoMusical, IPercussao

    
    {
        public bool ManterRitmo(){
            System.Console.WriteLine(" mantendo ritmo com tambores ");
            return true;
        }
    }
}