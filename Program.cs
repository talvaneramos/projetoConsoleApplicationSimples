using Projeto03.Entities;
using System;
using System.Collections.Generic;


namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPrograma produtos:\n ");

            try
            {
                var fornecedor = new Fornecedor();
                fornecedor.Produtos = new List<Produto>();
                fornecedor.IdFornecedor = Guid.NewGuid();

                Console.Write("Nome do Fornecedor.........: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ do Fornecedor.........: ");
                fornecedor.Cnpj = Console.ReadLine();

                Console.Write("Quantidade de Produtos: ");
                var quantidade = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantidade; i++)
                {
                    var produto = new Produto();
                    produto.IdProduto = Guid.NewGuid();

                    Console.WriteLine($"\nInforme o {i + 1}º produto:\n ");

                    Console.Write("\tNome do produto........: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("\tPreço do produto.......: ");
                    produto.Preco = decimal.Parse(Console.ReadLine());

                    Console.Write("\tQuantidade do produto..: ");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    fornecedor.Produtos.Add(produto);
                }

                Console.WriteLine("\nDados do produto:\n");

                Console.WriteLine("\tId do Fornecedor..........: " + fornecedor.IdFornecedor);
                Console.WriteLine("\tNome do Fornecedor........: " + fornecedor.Nome);
                Console.WriteLine("\tCNPJ do Fornecedor........: " + fornecedor.Cnpj);

                foreach (var item in fornecedor.Produtos)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("\tId do produto.........: " + item.IdProduto);
                    Console.WriteLine("\tNome do produto.......: " + item.Nome);
                    Console.WriteLine("\tPreço do produto......: " + item.Preco);
                    Console.WriteLine("\tQuantidade do produto.: " + item.Quantidade);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
