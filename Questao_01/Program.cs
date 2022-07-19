using System;

namespace Questao_01
{
    class Program
    {
        static void Main(string[] args)
        {  
            int soma = 0;
            System.Console.Write("Digite até 3 números romanos que deseja somar: ");
            char num1 = char.Parse(Console.ReadLine());
            char num2 = char.Parse(Console.ReadLine());
            char num3 = char.Parse(Console.ReadLine());

            if ((num1 == 'I')||(num2 == 'I')||(num3 == 'I'))
            {
                soma += 1;
            }
            else if ((num1 == 'V')||(num2 == 'V')||(num3 == 'V'))
            {
                soma += 5;
            }
            else if ((num1 == 'X')||(num2 == 'X')||(num3 == 'X'))
            {
                soma += 10;
            }
            else if((num1 == 'L')||(num2 == 'L')||(num3 == 'L'))
            {
                soma += 50;
            }
            else if ((num1 == 'C')||(num2 == 'C')||(num3 == 'C'))
            {
                soma += 100;
            }
            else if ((num1 == 'D')||(num2== 'D')||(num3 == 'D'))
            {
                soma += 500;
            }
            else if ((num1 == 'M')||(num2 == 'M')||(num3 == 'M'))
            {
                soma += 500;
            }
            System.Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}