using System;
namespace MinimalAPi1
{
    public class MyService: IMyService
    {
        private readonly ILogger<MyService> _logger;
        public MyService(ILogger<MyService> logger)
        {
            _logger = logger;
        }

        public Greeting GetGreeting()
        {
            _logger.LogInformation($"In {nameof(GetGreeting)}");
            return new Greeting("Hello");
        }
    }

    public interface IMyService
    {
        Greeting GetGreeting();
    }
}

