using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace CBTool
{
    internal static class Program
    {
        public static ILog LOGGER = LogManager.GetLogger(typeof(CBToolCS));

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo("Log4Net.config"));
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LOGGER.Info("Start");
            Application.Run(new CBToolCS());
        }
    }
}