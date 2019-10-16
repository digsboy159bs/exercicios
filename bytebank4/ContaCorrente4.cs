using System;

namespace bytebank4 {
    public class ContaCorrente {
        // propriedades
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _Saldo;
        public double Saldo {
            get { return _Saldo }
            set{Saldo }
        }
        public ContaCorrente (int Agencia, int Numero, string Titular) {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }
        public double Deposito (double valor) {
            return this.Saldo += valor;
        }
        public bool Saque (double valor) {
            if (this.Saldo >= valor) {
                this.Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }
        public bool transferencia (ContaCorrente contaDestino, double valor) {
            if (this.Saque (valor)) {
                contaDestino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}