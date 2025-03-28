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

            // Registrar os formul�rios e servi�os do projeto
            services.AddScoped<Main>(); // Formul�rio principal
            services.AddScoped<Login>(); // Formul�rio Login
            services.AddScoped<Registrar>(); // Outro formul�rio
            services.AddScoped<IUsuarioDB, UsuarioDB>(); // Reposit�rio

            var provider = services.BuildServiceProvider();
            services.AddSingleton(provider);

            // Criar e retornar o provedor de servi�os
            return services.BuildServiceProvider();
        }
    }
}