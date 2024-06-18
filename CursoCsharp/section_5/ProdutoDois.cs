using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_5
{
    internal class ProdutoDois
    {
        
        // Ordem recomendada:
        private String _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public ProdutoDois(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public ProdutoDois(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2") + ", Unidades: " + Quantidade + ", Valor total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
