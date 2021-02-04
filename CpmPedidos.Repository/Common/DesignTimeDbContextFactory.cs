using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace CpmPedidos.Repository
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            //retorna o ambiente -> Produção, stage, desenvolvimento
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            
            var fileName = Directory.GetCurrentDirectory() + $"/../cpmPedidos.API/appsettings.{environmentName}.json";
            
            //obtem uma configuração
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(fileName)
                .Build();
            var connectionString = configuration.GetConnectionString("App");

            //criando um builder
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseNpgsql(connectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }
}
