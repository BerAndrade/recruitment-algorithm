using System;

namespace empresa
{
    class Program
    {
        static void Main(string [] args)
        {
            double rg, cpf, tel, idade, idam=0, numtotal =0;
            string sexo, nome, exp, forma;
            Console.WriteLine("\nDigite seus dados para o recrutamento:");

            for (int i = 0; i <= 2; i++)
            {
                Console.Write("\n\n\nNome: ");
                nome = Console.ReadLine();

                Console.Write("\nRG: ");
                rg = double.Parse(Console.ReadLine());

                Console.Write("\nCPF: ");
                cpf = double.Parse(Console.ReadLine());

                Console.Write("\nTelefone/celular: ");
                tel = double.Parse(Console.ReadLine());

                Console.Write("\nIdade: ");
                idade = double.Parse(Console.ReadLine());              
                
                Console.Write("\nSexo (M/F): ");
                sexo = Console.ReadLine();

                Console.Write("\nFormação acadêmica: ");
                forma = Console.ReadLine();

                Console.Write("\nPossui alguma experiência profissional(S/N)? ");
                exp = Console.ReadLine();

                while (exp.ToUpper() != "SIM" && exp.ToUpper() != "NÃO")
                {                 
                    Console.WriteLine("Inválido, Redigite! ");
                    exp = Console.ReadLine();
                }
                numtotal = numtotal + i;
                idam = idade + i / 3;
            }
            Console.WriteLine("\nNúmero total de candidatos: {0}", numtotal);
            Console.ReadKey();
        }
    }
}
