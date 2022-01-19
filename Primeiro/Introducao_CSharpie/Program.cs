using System;
using Introducao_CSharpie;
using Interface;
using Enum;

namespace Introducao_CSharpie
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Thaís";
            pessoa.Estado = "São Paulo";
            pessoa.Idade = 25;

            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Gabriel";
            pessoa2.Estado = "São Paulo";
            pessoa2.Idade = 26;

            Animal animal = new Animal();
            animal.Nome = "Lola";
            animal.NomeDono = "Thaís";

            var animal2 = new Animal();
            animal2.Nome = "Meg";
            animal2.NomeDono = "Fernanda";

            var pessoas = (Pessoas)0;

                        
            Console.WriteLine("Hello World!");
        }
    }
}
