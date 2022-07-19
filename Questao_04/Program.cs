using System;
using Questao_04.Entities;

namespace Questao_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso normal = new Normal();
            VIP vip = new VIP();
            CamaroteInferior camInf = new CamaroteInferior();
            CamaroteSuperior camSup = new CamaroteSuperior();

            System.Console.WriteLine("Ingresso: ");
            string tipoIngresso = Console.ReadLine();
            if (tipoIngresso == "Normal")
            {
                normal.imprimeValor();
            }
            if (tipoIngresso == "VIP")
            {
                System.Console.WriteLine("Valor adicional");
                vip.valorVip = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Valor vip: " + vip.imprimeValor());
            }
            if (tipoIngresso == "Camarote inferior")
            {
                System.Console.WriteLine(camInf.imprimirLocal());
            }
            if (tipoIngresso == "Camarote superior")
            {
                System.Console.WriteLine(camSup.textoCamarote());
            }
            Console.ReadKey();            
        }
    }
}