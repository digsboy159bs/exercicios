using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models {
    public class Garrafa :Objeto, IVerde {
        public bool ReciclarVidro () {
            Console.WriteLine ("reciclando o material feito de vidro");
            return true;
        }

    }
}