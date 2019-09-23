using System;

namespace idade1
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade=0 ;
           int anodnasc=0;
            do{
           Console.Write("digite o ano de nascimento:");
         
            anodnasc =int.Parse(Console.ReadLine());
            if (anodnasc > 2019){
                Console.WriteLine("ano invalido");
            }
            }while((anodnasc >2019)||(anodnasc<0));
            idade= 2019-anodnasc;
            
            
           

             Console.WriteLine("a idade é " + idade );
             
              

            if((idade>=0) && (idade<= 2)){
            Console.WriteLine("recem nascido"  );
            }else
            
           
            if((idade>=3) && (idade<=11)){
            Console.WriteLine("criança" );
            }
            else
            if((idade>=12)&&(idade<=19)){
            Console.WriteLine("adolescente");
            }
            else
            if((idade>=20)&&(idade<=65)){
                Console.WriteLine("adulto");
            }
            else
            if(idade>65){
            Console.WriteLine("idoso");
            }
            
           
           
            
            }
            

            

        }
    }

