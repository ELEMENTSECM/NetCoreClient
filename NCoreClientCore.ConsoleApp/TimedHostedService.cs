using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NCoreClientCore.NetStandard;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NCoreClientCore.ConsoleApp
{
   internal class TimedHostedService : IHostedService, IDisposable
    {
        private readonly ILogger _logger;
        NCoreFactory _factory;
        private Timer _timer;

        public TimedHostedService(ILogger<TimedHostedService> logger, NCoreFactory factory)
        {
            _logger = logger;
            _factory = factory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is starting.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero, 
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            _logger.LogInformation("Timed Background Service is working.");
            var oms = new Oms((s) => _logger.LogInformation(s), _factory);
            oms.LogCases();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
