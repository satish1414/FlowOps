
using FlowOps.Application.WorkItems;
using FlowOps.FlowOps.Application.WorkItems;
using FlowOps.Infrastructure.Persistence;
using FlowOps.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowOps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IWorkItemService, WorkItemService>();
            builder.Services.AddScoped<IWorkItemRepository, WorkItemRepository>();
            builder.Services.AddDbContext<FlowOpsDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("FlowOpsDb")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
