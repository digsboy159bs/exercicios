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

        }
        public string AlocarAluno (string Nome) {
            this.Nome = Nome;

            string[Nome]  vetor  =   { 1, 2 };
            return true;
            

        }

    }
}