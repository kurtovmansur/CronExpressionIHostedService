
namespace CronExpressionIHostedService.MyHostedServices.HrmJobs
{
    public class HrmJob1(IScheduleConfig<HrmJob1> config, ILogger<HrmJob1> logger)
        : HrmCronJobService(config.CronExpression, config.TimeZoneInfo)
    {
        private int Count = 0;
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[HrmJob1 ga start berildi va u {config.CronExpression.ToString()} bo'yicha ishlaydi]");
            Console.WriteLine();
            Console.ResetColor();
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            Count++;
            Console.WriteLine($"HrmJob1 {Count} - marta ishlayapdi");

            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }

        protected override Task ScheduleJob(CancellationToken cancellationToken)
        {
            return base.ScheduleJob(cancellationToken);
        }
    }
}
