namespace CronExpressionIHostedService.MyHostedServices
{
    public static class ScheduledServiceExtensions
    {
        public static IServiceCollection AddCronJob<T>(this IServiceCollection services, Action<IScheduleConfig<T>> options) where T : HrmCronJobService
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options), @"Please provide Schedule Configurations.");
            }
            var config = new ScheduleConfig<T>();
            options.Invoke(config);

            services.AddSingleton<IScheduleConfig<T>>(config);
            services.AddHostedService<T>();
            return services;
        }
    }
}
