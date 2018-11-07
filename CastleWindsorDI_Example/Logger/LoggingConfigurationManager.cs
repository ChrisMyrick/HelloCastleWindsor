using Serilog;

namespace CastleWindsorDI_Example.Logger
{
    // Handles configuration of the logger
    public static class LoggerConfigurationManager
    {
        private static Serilog.Core.Logger _logger;

        public static Serilog.Core.Logger GetConfiguredLogger()
        {
            _logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();

            return _logger;
        }

        /// <summary>
        /// Forces disposal of the logger to ensure that log cache is flushed. This should only be called as the
        /// application is exiting.
        /// </summary>
        public static void Dispose()
        {
            _logger.Dispose();
        }
    }
}
