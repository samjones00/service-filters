using Microsoft.AspNetCore.Mvc.Filters;

namespace service_filters.Filters
{
    public class ExampleFilter : IAsyncActionFilter
    {
        private readonly ILogger<ExampleFilter> _logger;

        public ExampleFilter(ILogger<ExampleFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("Before controller action");
            await next();
            _logger.LogInformation("After controller action");
        }
    }
}
