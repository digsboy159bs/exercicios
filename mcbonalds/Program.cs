using System;

namespace mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente1 = new cliente("jose", "5555-5555", "ze@email.com");

            Console.WriteLine("nome: " + cliente1.Nome);
            Console.WriteLine("telefone: " + cliente1.Telefone);
            Console.WriteLine("email: " + cliente1.Email);



        }
    }
}

