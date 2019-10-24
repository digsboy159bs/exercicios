using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models {
    public class GuardaChuva :Objeto, IAmarelo, IVermelho {
        public bool ReciclarMetal () {
            Console.WriteLine ("Reciclando materiais de metal");
            return true;
        }
        public bool ReciclarPlastico () {
            Console.WriteLine ("Reciclando materiais de plastico");
            return true;
        }

    }
}