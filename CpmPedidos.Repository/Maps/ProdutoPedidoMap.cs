﻿using CpmPedidos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Repository
{
    public class ProdutoPedidoMap : BaseDomainMap<ProdutoPedido>
    {
        ProdutoPedidoMap(): base("tb_produtopedido")
        {

        }

        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);
        }
    }
}