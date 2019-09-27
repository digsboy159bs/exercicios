using System;

namespace aluno
{
    public class aluno{
        // propriedades
       public string Nome{get; set;}
       public  string Curso{get; set;}
       public string Cpf{get; set;}
       public int[] Notas;
    //    construtor
    public aluno(string Nome, string Cpf){
    this.Nome = Nome;
    this.Cpf = Cpf;
    
    }
    public aluno(string Nome, string Cpf, string Curso){
         this.Nome = Nome;
         this.Cpf = Cpf;
         this.Curso = Curso;
    }
    public int[] getnotas(){return Notas;}

    public void setnotas(int bi, int nota){
        if((i<0) || (i>3)){
            throw new argumentOutOFRangerExcepition($"{nameof(value)} must 1 and 4 ");
        } else if(nota<0 ||)

       
    }
}
}