using System;
using SENAIzinho.Models;

namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("cadastro do aluno");
            Console.WriteLine ("nome: ");
            string Nome = Console.ReadLine ();
            Console.WriteLine ("data de nascimento: ");
            DateTime DataNascimento = DateTime.Parse (Console.ReadLine ());

            Console.WriteLine ("Curso: ");
            string Curso = Console.ReadLine ();
            Console.WriteLine ("numero da sala: ");
            int numeroSala = int.Parse (Console.ReadLine ());

            Console.WriteLine ("capacidade total: ");
            int capacidadeTotal = int.Parse (Console.ReadLine ());
            Console.WriteLine ("numero da sala: ");
            numeroSala = Console.ReadLine ();
            sala sala1 = new sala (capacidadeTotal, numeroSala);

        }
    }
}