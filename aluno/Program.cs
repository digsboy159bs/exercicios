using System;

namespace aluno
{
    class Program
    {
        static void Main(string[] args)
        {
          aluno aluno1 = new aluno("diego","344.368.108.52");
          aluno aluno2 = new aluno("digs","344.368.108.53", "prog1");
          Console.WriteLine("nome: " + aluno1.Nome);
          Console.WriteLine("cpf: " + aluno1.Cpf);
            Console.WriteLine("Curso: " + aluno1.Curso);

            Console.WriteLine("nome: " + aluno2.Nome);
            Console.WriteLine("cpf: " + aluno2.Cpf);
            Console.WriteLine("Curso: " + aluno2.Curso);

            Console.Write("entre com o nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("entre com o Cpf: ");
            string Cpf = Console.ReadLine();
            
            Console.Write("entre com o curso: ");
            string Curso = Console.ReadLine();

             Console.Write("entre com a nota: ");
            int nota = int.Parse(Console.ReadLine());

            Console.Write("entre com o bimestre: ");
            int bimestre = int.Parse(Console.ReadLine());


            
            
          

            aluno aluno3 = new aluno(nome,cpf,curso);
            aluno3.setnotas(bimestre,nota);
            Console.WriteLine("nome: " + aluno3.Nome);
            Console.WriteLine("cpf: " + aluno3.Cpf);
            Console.WriteLine("Curso: " + aluno3.Curso);

            Console.WriteLine("notas: ");
            foreach(int nota in aluno3.getNotas()){
            Write(nota + "");
            }
            Console.WriteLine();
            

        }
    }
}
