using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace CpmPedidos.API.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;
        public AppBaseController(IServiceProvider serviceProvider)
        { 
            ServiceProvider = serviceProvider;
        }
        protected T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }

    }
}
