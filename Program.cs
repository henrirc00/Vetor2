using System;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] nomes = {"Bruno","Camila","Raphaela","Fábio"};

          for(int y = 3; y >= 0; y--){
              Console.WriteLine(nomes[y]);


          }  
          Console.WriteLine("_____________________________________________");

          int p = 0;
          while (p<=3){
              Console.WriteLine(nomes[p]);
              p++;

          }


        }
    }
}
