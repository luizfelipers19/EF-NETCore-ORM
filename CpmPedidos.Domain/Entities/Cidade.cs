using CpmPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain
{
    public class Cidade : BaseDomain, IExibivel
    {
      

        public string Nome { get; set; }

        public string UF { get; set; }

        public bool Ativado { get; set; }

    }
}
