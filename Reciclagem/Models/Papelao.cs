

using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IPapel
    {
        public string ReciclarFeitoPapel()
        {
            return this.GetType().Name;
        }
    }
}