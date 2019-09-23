using System;

namespace parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
         int numero=0;

            do{
                  Console.Write("digite um numero:");
                numero =int.Parse(Console.ReadLine());

               
                if(numero % 2 == 0){
                Console.WriteLine("o numero é par");
                }
                else
                Console.WriteLine("o numero é impar" );

            }while(numero!= 0);
              
              }
             

        }
    }

