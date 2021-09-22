using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace controle_de_estoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            // interaçao com usuario
            Console.WriteLine("Entre com dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // declarando classe
            Produto p = new Produto(nome, preco, quantidade);

            // interaçao com usuario
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            // resultado
            Console.WriteLine("Dados do atualizados: " + p);

            // resultado
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            // resultado
            Console.WriteLine("Dados do atualizados: " + p);

            Console.ReadKey();
        }
    }
}
