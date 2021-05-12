﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace CpmPedidos.API.Controllers
{
    
    public class AppBaseController : ControllerBase
    {

        protected readonly IServiceProvider _serviceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

       
    }
}
