
namespace CronExpressionIHostedService.MyHostedServices.HrmJobs
{
    public class HrmJob2(IScheduleConfig<HrmJob2> config, ILogger<HrmJob2> logger)
        : HrmCronJobService(config.CronExpression, config.TimeZoneInfo)
    {
        private int n = 0;
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[HrmJob2 ga start berildi va u {config.CronExpression.ToString()} bo'yicha ishlaydi]");
            Console.WriteLine();
            Console.ResetColor();
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            n++; 
            Console.WriteLine($"HrmJob2 {n} - marta ishlayapdi");

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
