using System;

namespace byte_bank
{
    public class cliente
    {
        // propriedades
        public string Nome;

        public string Cpf;

        public string Email;

        public cliente()
        {
        }

        public cliente(string Nome, string Cpf, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }
    }
}
