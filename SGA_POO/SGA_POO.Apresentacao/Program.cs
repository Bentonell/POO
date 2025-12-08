using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGA_POO.Dados.Entidades;
using SGA_POO.Dados.Repositorios;
using SGA_POO.Negocio.Interfaces;
using SGA_POO.Negocio.Servicos;
using System;
using System.IO;
using System.Windows.Forms;

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

            // --- REGISTAR OS REPOSITÓRIOS (A Lógica) ---
            services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
            services.AddScoped<ICursoRepositorio, CursoRepositorio>(); // OBRIGATÓRIO PARA CURSOS
            services.AddScoped<IDocenteRepositorio, DocenteRepositorio>(); // NOVO
            services.AddScoped<IUnidadeCurricularRepositorio, UnidadeCurricularRepositorio>(); // NOVO
            services.AddScoped<IAnoLetivoRepositorio, AnoLetivoRepositorio>();
            services.AddScoped<IInscricaoRepositorio, InscricaoRepositorio>();

            // --- SERVIÇOS DE DOMÍNIO (Regras de Negócio) ---
            services.AddScoped<GestorInscricoes>();

            // --- REGISTAR OS FORMULÁRIOS (A Visualização) ---
            services.AddTransient<Form1>();        // Menu Principal
            services.AddTransient<FormAlunos>();   // Janela de Alunos
            services.AddTransient<FormCursos>();   // Janela Cursos
            services.AddTransient<FormUnidadesCurriculares>(); // Janela Unidades Curriculares
            services.AddTransient<FormDocentes>();
            services.AddTransient<FormAnosLetivos>();
            services.AddTransient<FormInscricoes>();
            services.AddTransient<FormTurmas>();

            // 4. Construir e Arrancar
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // Arrancar sempre com o Menu Principal (Form1)
                var formPrincipal = serviceProvider.GetRequiredService<Form1>();
                Application.Run(formPrincipal);
            }
        }
    }
}