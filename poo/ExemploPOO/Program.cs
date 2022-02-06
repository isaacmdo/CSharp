using System;
using ExemploPOO.models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";

            p1.Idade = 20;

            p1.Apresentar();

            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);

            System.Console.WriteLine($"Área: {r.ObterArea()}");

            Professor p2 = new Professor();
            p2.Salario = 2000;
            p2.Nome = "BOB";
            p2.Idade = 20;
            p2.Apresentar();

            

        }
    }
}
