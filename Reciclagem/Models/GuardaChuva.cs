

using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : Lixo, IIndefinido
    {

        public string ProcurarOQueFazer()
        {
            return this.GetType().Name;
        }
    }
}