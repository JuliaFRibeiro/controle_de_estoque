using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace controle_de_estoque
{
    public class Produto
    {
        // declarando variaveis
        public string Nome;
        public double Preco;
        public int Quantidade;

        // construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // construtor
        public double ValorTotalEstoque()
        {
            // claculo
            return Preco * Quantidade;
        }

        // construtor
        public void AdicionarProduto(int quantidade)
        {
            // claculo
            Quantidade += quantidade;
        }

        // construtor
        public void RemoverProdutos(int quantidade)
        {
            // claculo
            Quantidade = Quantidade - quantidade;
        }

        // construtor
        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    
}
