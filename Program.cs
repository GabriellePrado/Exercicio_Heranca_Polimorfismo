using Exercicio_Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> listaProduto = new List<Produto>();
            Console.WriteLine("Entre com a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados do produto #{i} ");
                Console.Write("1-Comum, 2-Usado ou  3-Importado : ");
                int tipo = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o preco:");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 1)
                {
                   listaProduto.Add(new Produto(nome, preco));
                }
                else if (tipo == 2)
                {
                    Console.WriteLine("Data de Fabricação (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listaProduto.Add(new ProdutoUsado(nome, preco, date));
                }
                else if(tipo == 3)
                {
                    Console.Write("Taxa de importação: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaProduto.Add(new ProdutoImportado(nome, preco, taxa));
                }
            }

            Console.WriteLine("\nListagem de Produtos: ");
            foreach (var item in listaProduto)
            {
                Console.WriteLine(item.Etiqueta());
            }
        }
    }
}
