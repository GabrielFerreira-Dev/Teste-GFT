using System;
using Questao_02.Entities;

namespace Questao_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Raça> list = new List<Raça>();
            int n = 1;
            for (int i = 0; i < n; i++)
            {
                list.Add(new Anao(2,2,2));
                list.Add(new Elfo(2,2,2));
                list.Add(new Humano(1,1,1,1,1,1));
            }
            
            foreach (Raça obj in list)
            {
                System.Console.WriteLine(obj.ToString());
            }
            Console.ReadKey();

            
        }
    }
}