using System;

namespace bytebank4
{
    public class Cliente
    {
        // propriedades
        public string Nome;

        public string Cpf;

        public string Email;
        public string Senha;




        public Cliente(string Nome, string Cpf, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }



        public bool TrocarSenha(string senha)
        {
            if ((senha.Length > 6) && (senha.Length < 16))
            {
                this.Senha = senha;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
