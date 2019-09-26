using System;

namespace exmatris
{
    class Program
    {
        static void Main(string[] args)
        {
            double maior= 0;
               double menor= 0;
             double[] temperatura = new double[12];
          for(int i = 0; i<12; i++){
             Console.Write($"digite a temperatura do mes {i+ 1}: ");
             temperatura[i]= double.Parse(Console.ReadLine());
          }
          maior = temperatura[0];
          menor = temperatura[0];

          foreach(double temp in temperatura){
              if(temp > maior){
                  maior= temp;
              }else if(temp < menor){
                  menor = temp;
              }

          }
          Console.WriteLine($"a maior temperatura é {maior}");
           Console.WriteLine($"a menor temperatura é {menor}");
        }
    }
}
