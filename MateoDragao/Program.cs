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

                string opçaojogador = Console.Readline();

                switch (opçaojogador)
                {
                    case "1":
                        Console.Clear();
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
                        
                        Dragao dragao = new Dragao();
                        guerreiro.Nome = "blue eyes ";
                        guerreiro.Forca = 5;
                        guerreiro.Destreza = 1;
                        guerreiro.Inteligencia = 3;
                        guerreiro.Vida = 300;
                        

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
    }
}
