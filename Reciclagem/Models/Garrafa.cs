using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : Lixo, IVidro
    {
        public string ReciclarFeitoVidro()
        {
            return this.GetType().Name;
        }
    }
}
        
    
