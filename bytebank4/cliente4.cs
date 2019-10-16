using System;

namespace bytebank4 {
    public class Cliente {
        // propriedades
        public string Nome;

        public string _Cpf;

        private string _Email;
        
        private string _Senha;

        public string Senha {

            get { return _Senha; }
            set { _Senha = value; }

        }

        public Cliente (string Nome, string Cpf, string Email) {
            this.Nome = Nome;
            this._Cpf = Cpf;
            this._Email = Email;
        }

        public bool TrocarSenha (string senha) {
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this._Senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
}