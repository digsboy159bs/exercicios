using System;

namespace bytebank4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region cadastro do cliente.
            #region cadastro. 

            Console.WriteLine("bytebank - cadastro do cliente");
            Console.WriteLine("nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Cpf: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("email: ");
            string Email = Console.ReadLine();


            bool trocouSenha = false;

            Cliente cliente1 = new Cliente(Nome, Cpf, Email);
            do
            {
                Console.Write("senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocarSenha(senha);
                if (trocouSenha)
                {
                    Console.WriteLine("senha alterada com sucesso");
                }
                else
                {
                    Console.WriteLine("senha invalida");
                }
            } while (!trocouSenha);
            #endregion 




            Console.WriteLine("bytebank - cadastro da conta");
            Console.Write("entre com a agencia: ");
            int Agencia = int.Parse(Console.ReadLine());
            Console.Write("entre com a conta: ");
            int Conta = int.Parse(Console.ReadLine());


            ContaCorrente contacorrente1 = new ContaCorrente(Agencia, Conta, cliente1);
            double Saldo;
            do
            {
                Console.Write("entre com o saldo: ");
                Saldo = double.Parse(Console.ReadLine());
                if (Saldo > 0)
                {
                    contacorrente1.Saldo = Saldo;
                }
                else
                {
                    System.Console.WriteLine("valor do saldo deve ser positivo");
                }
            } while (Saldo < 0);
            Console.WriteLine();
            #endregion

            Cliente cliente2 = new Cliente("cesar", "131313131313","@email");
        ContaCorrente contaCorrente2 = new ContaCorrente(" 41q4","1424",cliente2);

        #region deposito
        Cliente usuario = ContaCorrente.Titular;
        Console.WriteLine("bytebank - deposito em conta");
        Console.WriteLine($"bem vindo - {usuario.Nome}");
        Console.WriteLine($"Agencia {ContaCorrente.Agencia} conta: {contacorrente1.Numero}");
        System.Console.WriteLine();
        System.Console.WriteLine("digite o valor do deposito: ");
        double valor = double.Parse(Console.ReadLine());
        contacorrente1.deposito(valor);
        System.Console.WriteLine();
        System.Console.WriteLine($"Novo saldo: {ContaCorrente.Saldo}");
        System.Console.WriteLine();
        #endregion
        

        


        }
    }
}
