using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGA_POO.Dados.Entidades;
using System;
using System.IO;
using System.Windows.Forms;
using SGA_POO.Negocio.Interfaces;
using SGA_POO.Dados.Repositorios;

namespace SGA_POO.Apresentacao
{
    internal static class Program
    {
        /// <summary>
        ///  Ponto de entrada principal da aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. Configurações visuais
            ApplicationConfiguration.Initialize();

            // 2. Ler o ficheiro appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // 3. Preparar a "Mochila de Serviços"
            var services = new ServiceCollection();

            // Ler a connection string e configurar o SQL Server
            string stringConexao = configuration.GetConnectionString("EscolaDB");
            services.AddDbContext<EscolaDBContext>(options =>
                options.UseSqlServer(stringConexao));
            // Registar os Repositórios
            services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();

            // Registar o Formulário Principal
            services.AddTransient<Form1>();
            services.AddTransient<FormAlunos>();

            // 4. Construir e Arrancar
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // MUDANÇA AQUI: Pedir o FormAlunos em vez do Form1
                var formParaAbrir = serviceProvider.GetRequiredService<FormAlunos>();
                Application.Run(formParaAbrir);
            }
        }
    }
}