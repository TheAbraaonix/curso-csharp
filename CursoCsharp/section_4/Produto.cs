using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_4
{
    internal class Produto
    {
        public String Nome;
        public double Preco;
        public int Quantidade;

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
            return Nome + ", $ " + Preco.ToString("F2") + ", Unidades: " + Quantidade + ", Valor total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
