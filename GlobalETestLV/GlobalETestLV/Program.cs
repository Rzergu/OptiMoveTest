using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Data;
using GlobalETestLV.Data.Contexts;
using GlobalETestLV.Data.Repositories;
using GlobalETestLV.Interfaces;
using GlobalETestLV.Jobs;
using GlobalETestLV.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.AspNetCore;
using Quartz.Impl.AdoJobStore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        builder.Services.AddDbContext<CustomerContext>(c =>
            c.UseNpgsql(builder.Configuration.GetConnectionString("connectionString"), option =>
            {
                option.MigrationsAssembly("GlobalETestLV");
            }));
        builder.Services.AddQuartz( q => {
            q.UseMicrosoftDependencyInjectionJobFactory();
            // Register the job with the DI container
            var jobKey = new JobKey("SendStrategiesJob");
            q.AddJob<SendStrategiesJob>(opts => opts.WithIdentity(jobKey).StoreDurably(true));

            // Create a trigger for the job
        });
        builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
        builder.Services.AddScoped<ICustomersViewModelService,CustomersViewModelService>();
        builder.Services.AddScoped<IFiltersViewModelService,FiltersViewModelService>();
        builder.Services.AddScoped<ITimersViewModelService,TimersViewModelService>();
        builder.Services.AddCors(o => o.AddPolicy("NUXT", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }));
        builder.Services.AddQuartzServer(opt =>
        {
            opt.WaitForJobsToComplete = true;
        });
        var app = builder.Build();

        app.UseCors("NUXT");

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();


        app.Run();
    }
}