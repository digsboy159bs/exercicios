using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoList {
    class Program {
        static void Main (string[] args) {
            List<ToDoitem> ToDoList = new List<ToDoitem> ();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try {
                string[] todoFile = File.ReadAllLines (filePath);

                foreach (string line in todoFile) {

                    string[] itens = line.Split (",");
                    string Titulo = itens[0].Replace ("\"", "");
                    string Nota = itens[1].Replace ("\"", "");

                    ToDoitem todoitem = new ToDoitem (Titulo, Nota);
                    ToDoList.Add (todoitem);

                }

            } catch (IOException ioe) {
                System.Console.WriteLine (" erro em acessar arquivo");
                System.Console.WriteLine (ioe.Message);

            }

            int opcao = 0;

            do {
                Console.Clear ();
                System.Console.WriteLine (" todo list");
                System.Console.WriteLine ();
                ListaItens(ToDoList);
                System.Console.WriteLine ("Digite uma opçao! ");
                System.Console.WriteLine ("1 - adicionar item");
                System.Console.WriteLine ("2 - remover item");
                System.Console.WriteLine ("3 - sair do progrma");
                System.Console.Write ("opçao: ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                    AddItem(ToDoList);

                        break;
                    case 2:
                        RemoveLine(ToDoList);

                        break;
                        case 3:

                        System.Console.WriteLine("tchau");
                        break;
                        default:
                        System.Console.WriteLine(" opçao invalida");
                        Console.ReadLine();
                        break;

                }

            } while (opcao != 3);

        }
        public static void ListaItens(List<ToDoitem> todoList)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("todo list");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2}Titulo{"",12}Notas");
            foreach(ToDoitem item in todoList)
            {
                System.Console.WriteLine($"{count, 3}: {item.Titulo,15} - {item.Nota}"); 
                count++;
            }
        }

        public static void AddItem(List<ToDoitem> todoList)
        {
            Console.Clear();
            System.Console.WriteLine(" novo item");
            System.Console.WriteLine();
            System.Console.WriteLine("Titulo");
            string Titulo = Console.ReadLine();
            System.Console.WriteLine("nota");
            string Nota = Console.ReadLine();
            ToDoitem item = new ToDoitem(Titulo, Nota);

            todoList.Add(item);
        }
        public static void RemoveLine(List<ToDoitem> todoList)
        {
            int index = 0;
            do{
                Console.Clear();
                System.Console.WriteLine(" remove itens");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine(" digite o ID ou x para terminar");
                System.Console.Write("ID");
                string id = Console.ReadLine();

                if(id.ToLower() == "x"){
                    break;
                }
                else{
                    index = int.Parse(id) - 1;
                }

                if((index < 0)  || (index > todoList.Count - 1 )){
                    System.Console.WriteLine("ID invalido");
                    System.Console.WriteLine("pressione <enter> para continuar");
                    Console.ReadLine();

                    
                }else{
                    todoList.RemoveAt(index);
                }
                

            }while(true);
        }
    }
}