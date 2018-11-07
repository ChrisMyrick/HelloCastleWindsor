using System.Diagnostics;
using Castle.Core.Logging;
using Castle.DynamicProxy;

namespace CastleWindsorDI_Example.Logger
{
    /// <summary>
    /// Interceptor class which provides logging capabilities to classes configured for usage
    /// See https://github.com/castleproject/Core/blob/master/docs/dynamicproxy.md
    /// NOTE: Comment out the DebuggerStepThrough attribute in order to debug this class
    /// </summary>
    [DebuggerStepThrough]
    public class LoggingInterceptor : ILoggingInterceptor
    {
        private readonly ILogger _logger;

        public LoggingInterceptor(ILogger logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            if (!CanIntercept(invocation))
            {
                invocation.Proceed();
                return;
            }

            LogMethodCallWithTimeElapsed(invocation);
        }

        private static bool CanIntercept(IInvocation invocation)
        {
            return invocation.Method.IsPublic && !IsPropertyCall(invocation);
        }

        private static bool IsPropertyCall(IInvocation invocation)
        {
            return invocation.Method.Name.StartsWith("set_") || invocation.Method.Name.StartsWith("get_");
        }

        private void LogMethodCallWithTimeElapsed(IInvocation invocation)
        {
            var sw = Stopwatch.StartNew();
            invocation.Proceed();
            sw.Stop();

            var elapsedMs = sw.Elapsed.TotalMilliseconds.ToString("F3");

            _logger.InfoFormat("{InvocationTargetClass}.{InvocationTargetMethod} completed in {ElapsedMs} ms",
                invocation.InvocationTarget.GetType().Name,
                invocation.Method.Name,
                elapsedMs);
        }
    }

    public interface ILoggingInterceptor : IInterceptor
    {
    }
}
