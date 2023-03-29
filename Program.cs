using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace EstruturaCondicionalNota
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao das variaveis
            double notaum;
            double notadois;
            double soma;

            //Interaçao
            Console.WriteLine("Digite a nota do primeiro semestre!");
            notaum = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo semestre!");
            notadois = double.Parse(Console.ReadLine());

            soma = notaum + notadois;

            //Condiçao
            if (soma < 60.00) { 
                Console.WriteLine("NOTA FINAL: " + soma.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");

                //Final
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("NOTA FINAL: " + soma.ToString("F1", CultureInfo.InvariantCulture));

                //Final
                Console.ReadKey();
            }

        }
    }
}
