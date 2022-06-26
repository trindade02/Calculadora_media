using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks ;

namespace Primeiros_passos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            long cpf;
            int  a, b, c, d, media;

            Console.Write("Olá, como vai ?\nPor gentileza, informe seu nome:");
            Nome = Console.ReadLine();
            Console.Write("E o seu CPF:");
            cpf = long.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Seja bem-vindo " + Nome);
            Console.WriteLine("Por genitela, informe abaixo sua nota do 1º Bimestre");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe abaixo sua nota do 2º Bimestre");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe abaixo sua nota do 3º Bimestre");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe abaixo sua nota do 4º Bimestre");
            d = int.Parse(Console.ReadLine());
            Console.Clear();

            media = (a + b + c + d) / 4;

            if(media >= 7)
            {
                Console.Write("Parabéns " + Nome + ".\nVocê passou de ano");
                Console.ReadLine();
            }
            else if(media == 5 || media ==6)
            {
                Console.WriteLine(Nome + ", você se encontra de reforço.\nPor favor, procure o professor representante de sua sala");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não foi dessa vez que você passou sem problemas.\nTe encontro no ano que vem aqui para melhorarmos");
                Console.ReadLine();
            }
        }
    }
}
