using CpmPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain
{
    public class CategoriaProduto : BaseDomain, IExibivel
    {
      

        public string Nome { get; set; }

        public bool Ativado { get; set; }

        public virtual List<Produto> Produtos { get; set; }

    }
}
