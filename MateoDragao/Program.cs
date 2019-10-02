using System;
using MateoDragao.Models;

namespace MateoDragao
{
    class Program
    {
        static void Main(string[] args)



        {
            bool jogadorNaoDesistiu = true;
            do
            {

                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão");
                System.Console.WriteLine("==============================");
                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opçaojogador = Console.ReadLine();

                switch (opçaojogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = CriarGuerreiro();
                        

                        Dragao dragao = new Dragao();
                        dragao.Nome = "blue eyes ";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*Inicio - Primeiro Dialogo */
                        CriarDialogo(guerreiro.Nome, $"( {dragao.Nome}, seu louco! vim-lhe derrotar-lhe!");

                        CriarDialogo(dragao.Nome, $" Humano tolo. Quem pensas que é?");

                        FinalizarDialogo();
                        /*fim - Primeiro Dialogo */

                        /*inicio - segundo Dialogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: eu sou {guerreiro.Nome}! da casa {guerreiro.Sobrenome}, O CRIATURA MORFETICA");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: vim de {guerreiro.CidadeNatal}! para derrotar-lhe e mostrar meu valor");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: quem? de onde? bom que sejas... fritar-te-el e devolver-te-ei , humano insolente! ");
                        System.Console.WriteLine("harry: esta na hora do seu derradeiro suspiro");
                        System.Console.WriteLine();
                        System.Console.WriteLine("aperta enter para prosseguir");
                        Console.ReadLine();
                        /*fim do segundo dialogo */

                        Console.Clear();
                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;
                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("*** turno do jogador ***");
                            System.Console.WriteLine("*** escolha uma açao ***");
                            System.Console.WriteLine("*** 1 - Atacar ***");
                            System.Console.WriteLine("*** 2 - Fugir ***");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAlaeatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAlaeatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAlaeatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto maldito birrrr !");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"hp dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"hp guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: erroooooou!");
                                    }


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: adios amigo");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: gg easy");
                                    jogadorNaoCorreu = false;

                                    break;

                            }
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("aperte enter para prosseguir");
                        Console.ReadLine();
                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** turno do dragao ***");
                            Random geradorNumeroAlaeatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAlaeatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAlaeatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal)
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: fritou o anos foi? !");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"hp dragao: {dragao.Vida}");
                                System.Console.WriteLine($"hp guerreiro: {guerreiro.Vida}");
                            }
                            else
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: erroooooou!");
                            }

                            System.Console.WriteLine();
                            System.Console.WriteLine("aperte enter para prosseguir");
                            Console.ReadLine();

                            Console.Clear();
                            System.Console.WriteLine("*** turno do jogador ***");
                            System.Console.WriteLine("*** escolha uma açao ***");
                            System.Console.WriteLine("*** 1 - Atacar ***");
                            System.Console.WriteLine("*** 2 - Fugir ***");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAlaeatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAlaeatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAlaeatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto maldito birrrr !");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"hp dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"hp guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: erroooooou!");
                                    }


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: adios amigo");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: gg easy");
                                    jogadorNaoCorreu = false;

                                    break;

                            }

                        }
                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("voce perdeu!");
                        }
                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine(" voce venceu!");
                        }


                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine(" Game Over");

                        break;
                    default:
                        System.Console.WriteLine("comando invalido");
                        break;
                }
            } while (jogadorNaoDesistiu);









        }

        public static void CriarDialogo(string nome, string frase)
        {
            System.Console.WriteLine($"{nome.ToUpper()}: {frase}");
        }

        public static void FinalizarDialogo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("aperta enter para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        public static Guerreiro CriarGuerreiro()
        {

            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Digs ";
            guerreiro.Sobrenome = "Weelwood";
            guerreiro.CidadeNatal = "polo norte";
            guerreiro.DataNascimento = DateTime.Parse("26/12/2000");
            guerreiro.FerramentaAtaque = "Espada Relampago";
            guerreiro.FerramentaProtecao = "Escudo de airr";
            guerreiro.Forca = 3;
            guerreiro.Destreza = 2;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 20;

            return guerreiro;


        }




    }
}
