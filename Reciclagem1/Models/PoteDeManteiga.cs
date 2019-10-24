using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models
{
    public class PoteDeManteiga: Objeto,IVermelho {
        public bool ReciclarPlastico () {
            Console.WriteLine ("reciclando o material feito de plastico");
            return true;
        }
    
        
    }
}