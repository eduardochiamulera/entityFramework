using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CpmPedidos.API.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;
        public AppBaseController(IServiceProvider serviceProvider)
        { 
            ServiceProvider = serviceProvider;
        }

    }
}
