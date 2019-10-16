using System;
using System.Collections.Generic;
using EscolaDeRock.Interface;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    enum FormacaoEnum : int {
        TRIO = 3,
        QUARTETO
    };

    enum instrumentosEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    }

    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    }

    class Program {
        static void Main (string[] args) {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames (typeof (CategoriaEnum));

            var opcoesFormacao = new List<string> () {
                "     - 0                   ",
                "     - 1                   "

            };
            int opcaoFormacaoSelecionadas = 0;
            string menuBar = "==================================";

            do {
                bool FormacaoEscolhida = false;

                do {
                    #region area do menu
                    Console.Clear();
                    System.Console.WriteLine (menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine ("      seja bem vindo              ");
                    System.Console.WriteLine ("      Escolha uma formaçao:       ");
                    Console.ResetColor ();
                    System.Console.WriteLine (menuBar);

                    for (int i = 0; i < opcoesFormacao.Count; i++) {
                        string Titulo = itensMenuPrincipal[i];
                        if (opcaoFormacaoSelecionadas == i) {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine (opcoesFormacao[opcaoFormacaoSelecionadas].Replace ("-", ">").Replace (i.ToString (), Titulo));
                            Console.ResetColor ();

                        } else {
                            System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), Titulo));
                        }
                    }

                    var key = Console.ReadKey (true).Key;

                    switch (key) {
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionadas = opcaoFormacaoSelecionadas == 0 ? opcaoFormacaoSelecionadas : --opcaoFormacaoSelecionadas;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionadas = opcaoFormacaoSelecionadas == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionadas : ++opcaoFormacaoSelecionadas;
                            break;
                            case ConsoleKey.Enter:
                            FormacaoEscolhida = true;
                            break;

                    }

                    #endregion 
                } while (FormacaoEscolhida);

            } while (!querSair);
        }
    }
}