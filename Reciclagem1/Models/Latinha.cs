using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models
{
    public class Latinha: Objeto,IAmarelo {
        public bool ReciclarMetal () {
            Console.WriteLine ("reciclando o material feito de Metal");
            return true;
        }
    
        
    }
}