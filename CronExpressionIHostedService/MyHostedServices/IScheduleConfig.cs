using Cronos;

namespace CronExpressionIHostedService.MyHostedServices
{
    public interface IScheduleConfig<T>
    {
        CronExpression CronExpression { get; set; }
        TimeZoneInfo TimeZoneInfo { get; set; }
    }
}
