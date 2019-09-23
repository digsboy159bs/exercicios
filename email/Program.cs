using System;

namespace email
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string logiadm = "admin";
              string admsenha = "admin";
              Console.Write("digite o login: ");
           string login =Console.ReadLine();
            Console.Write("digite a senha: ");
           string senha =Console.ReadLine();

           if ((login == admlogin) && senha == admsenha){
               Console.WriteLine("bem vindo admin.");
           }
           else{
           Console.WriteLine("ola usuario.");
          }
             


        }
    }
}
