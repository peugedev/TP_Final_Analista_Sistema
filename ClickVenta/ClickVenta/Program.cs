using ClickVenta.Config;
using ClickVenta.forms;
using ClickVenta.forms.Empleado;
using Microsoft.Extensions.DependencyInjection;

namespace ClickVenta
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new frmlogin());
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.SetDefaultFont(new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point));

                var host = ConfigurationBase.CreateHostBuilter().Build();
                ServiceProvider = host.Services;

                var mainForm = ServiceProvider.GetRequiredService<frmlogin>();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}