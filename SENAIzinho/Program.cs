using System;
using SENAIzinho.Models;

namespace SENAIzinho {
    class Program {

        static void Main (string[] args) {
            int limiteAlunos = 0;
            int limiteSalas = 0;
            int TotalAluno = 100;
            aluno[] alunos = new aluno[100];
            sala[] salas = new sala[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            //bool querSair;

        }
        public void CadastrarAluno (aluno[] alunos, int TotalAluno, int alunosCadastrados) {
            if(TotalAluno < alunosCadastrados)
            {
                Console.WriteLine(" cadastro de alunos");
                Console.WriteLine();
                Console.Write("Nome");
                string Nome = Console.ReadLine();
                System.Console.Write("Dt nascimento");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                aluno novoaluno = new aluno();
                novoaluno.Nome = Nome;
                novoaluno.DataNascimento = dtNascimento;

                int index = 0;

                foreach(aluno aluno in alunos){
                    if(aluno == null){
                        alunos[index] = novoaluno;
                        break;
                    }
                    index++;
                
                }
                alunosCadastrados++;
                
            }
        }
        public void CadastrarSala () { }
        public void AlocarAluno () { }
        public void RemoverAluno () { }
        public void VerificarSalas () { }
        public void VerificarAlunos () { }

    }
}