using System.ComponentModel.Design;
using System.Drawing;

namespace EXERCICIODOADORDESANGUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? doador, Pdoacao;
            int idade;
            bool doacao = false;

            Console.WriteLine("Nome do doador: ");
            doador = Console.ReadLine();

            Console.WriteLine("Idade do doador: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primeira doação de sangue? ");
            Pdoacao = Console.ReadLine().ToUpper();

            if (Pdoacao.Equals("SIM"))
                doacao = true;

            else if (Pdoacao.Equals("NÂO"))
                doacao = false;

            if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine($"{doador} está apto para doar sangue.");
            }
            else if (idade >= 60 && idade <= 69 && doacao == true) 
            {
                Console.WriteLine($"{doador} não está apto para doar sangue.");
            }
            else if (idade >= 60 && idade <= 69 && doacao == false)
            {
                Console.WriteLine($"{doador} está apto para doar sangue.");
            }
            else
            {
                Console.WriteLine($"{doador} não está apto para doar sangue.");
            }



        }
    }
}