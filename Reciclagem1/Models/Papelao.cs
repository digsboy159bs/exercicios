using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models
{
    public class Papelao:Objeto, IAzul {
        public bool ReciclarPapel () {
            Console.WriteLine ("reciclando o material feito de papel");
            return true;
        }
    
        
    }
}