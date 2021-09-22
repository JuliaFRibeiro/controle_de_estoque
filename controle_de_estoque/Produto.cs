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

        //contrutor padrao
        public Produto()
        {

        }

        public string nome
        {
            //Lendo o conteudo de Nome
            get { return Nome; }
            //Atribuindo o conteudo de value em Nome depois da validação
            set
            {
                if (value != null && value.Length > 1)
                {
                    Nome = value;
                }
            }
        }

        //Função para calcular o valor total do estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Função para adicionar Produtos ao estoque
        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        //Função para remover produtos do estoque
        public void RemoverProdutos(int qtd)
        {
            Quantidade = Quantidade - qtd;
        }

        //Criando um formato para o ToString
        public override string ToString()
        {
            return Nome
            + ",R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ","
            + Quantidade
            + " unidades,Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }

    
}
