using System;

namespace Desafio01
{

class Program
{
    static void Main(string[] args)
    {
        int div=0;
          int resposta=0;
            int count = Convert.ToInt32(Console.ReadLine()); //numero de casos
            while(count> 0)
            {   
               int N = Convert.ToInt32(Console.ReadLine()); //quantidade de esfera
                for(int i=1; i<=N; i++){
                  for(int j=N; j>0; j--){
                  if(i%j==0){
                    div++;
                  }
                  if(div%2==0){
                    resposta++;
                  }
                } 
                }
                count--;
            }
        Console.WriteLine(resposta);
    }
    }

}

