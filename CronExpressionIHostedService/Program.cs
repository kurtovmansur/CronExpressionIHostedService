using CronExpressionIHostedService.MyHostedServices;
using CronExpressionIHostedService.MyHostedServices.HrmJobs;
using Cronos;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCronJob<HrmJob1>(c =>
{
    c.TimeZoneInfo = TimeZoneInfo.Local;

    //Bu task har 5 sekundda ishlaydi
    c.CronExpression = CronExpression.Parse("0/5 * * * * *", CronFormat.IncludeSeconds);
    //c.CronExpression = CronExpression.Parse("50 12 * * *");
});
builder.Services.AddCronJob<HrmJob2>(c =>
{
    c.TimeZoneInfo = TimeZoneInfo.Local;
    //Bu task har 8 sekindda ishlaydi
    c.CronExpression = CronExpression.Parse("0/8 * * * * *", CronFormat.IncludeSeconds);
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
