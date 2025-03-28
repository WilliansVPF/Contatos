using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace Forms
{
    internal static class Program
    {

        private static IServiceProvider serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            serviceProvider = ConfigureServices();

            var mainForm = serviceProvider.GetRequiredService<Main>();

            Application.Run(mainForm);
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Registrar os formulários e serviços do projeto
            services.AddScoped<Main>(); // Formulário principal
            services.AddScoped<Login>(); // Formulário Login
            services.AddScoped<Registrar>(); // Outro formulário
            services.AddScoped<IUsuarioDB, UsuarioDB>(); // Repositório

            var provider = services.BuildServiceProvider();
            services.AddSingleton(provider);

            // Criar e retornar o provedor de serviços
            return services.BuildServiceProvider();
        }
    }
}