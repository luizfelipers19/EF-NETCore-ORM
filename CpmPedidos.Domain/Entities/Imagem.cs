﻿using CpmPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain
{
    public class Imagem : BaseDomain
    {
      

        public string Nome { get; set; }

        public string NomeArquivo { get; set; }

        public bool ImagemPrincipal { get; set; }



    }
}