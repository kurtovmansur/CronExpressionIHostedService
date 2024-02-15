using Cronos;

namespace CronExpressionIHostedService.MyHostedServices
{
    public class ScheduleConfig<T> : IScheduleConfig<T>
    {
        public CronExpression CronExpression { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; } = TimeZoneInfo.Local;
    }
}
