using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pessoa p1 = new Pessoa();

            Aluno a1 = new Aluno("Leonardo", "Buta", "teste");
            a1.Apresentar();
            Log log = Log.GetInstance();

            log.PropriedadeLog = "teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);


            Data data = new Data();
            //data.SetMes(13);
            data.Mes = 12;
            data.ApresentarMes();
            System.Console.WriteLine(data.Mes);
        }
    }
}
