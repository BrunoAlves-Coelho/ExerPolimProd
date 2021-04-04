using System;
using System.Globalization;
using System.Collections.Generic;
using ExerPolim.Entities;

namespace ExerPolim
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listProduto = new List<Produto>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produto produto = new Produto(nome, preco);
                    listProduto.Add(produto);

                }
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double taxaAlfadegaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produto produto = new ProdutoImportado(nome, preco, taxaAlfadegaria);
                    listProduto.Add(produto);
                }
                if (ch == 'u')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    Produto produto = new ProdutoUsado(nome, preco, dataFabricacao);
                    listProduto.Add(produto);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Produto item in listProduto)
            {
                Console.WriteLine(item.PrecoTag());
            }



        }
    }
}
