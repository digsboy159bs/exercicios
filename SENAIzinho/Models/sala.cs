namespace SENAIzinho.Models {
    public class sala {
        public string Nome;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos;

        public void Sala (int capacidadeTotal, int numeroSala) {

            this.capacidadeTotal = capacidadeTotal;
            this.numeroSala = numeroSala;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];

        }

        public string AlocarAluno (string Nome) {
            int index = 0;
            if(this.capacidadeAtual == this.capacidadeTotal){
                return  "sala vazia" ;
            }
            if (capacidadeAtual > 0) {
                foreach (string aluno in this.Alunos) {

                    if (aluno == "") {
                        this.Alunos[index] = Nome;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return"OK";


            }else{
                return "Lotado";
            }
        }
        public string RemoverAluno (string Nome)
        {
            int index = 0;
            foreach( string aluno in this.Alunos)
            {
                if(Nome == aluno)
                {
                    this.Alunos[index] = "";
                    return"OK";
                }
            }
            return"nao econtrado";
        }

        public string MostrarAluno ()
        {
            string listaAlunos = "";
            foreach(string aluno in this.Alunos){
                if(aluno != ""){
                    listaAlunos = listaAlunos + aluno + "";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos ;
        }

    }
}