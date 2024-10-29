// <copyright file="Program.cs" company="Global Logitech">
// Copyright (c) Global Logitech. All rights reserved.
// </copyright>

namespace AssetManagement.WebApi
{
    using AssetManagement.Application.Repositories;
    using AssetManagement.Application.Services.Employee;
    using AssetManagement.Domain.Entities;
    using AssetManagement.Infrastructure.Data;
    using AssetManagement.Infrastructure.Repositories;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// A class that runs the app.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("AssetManagementDbContext"));
            });

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            // Repository dependencies
            builder.Services.AddScoped(typeof(IBaseRepository<EmployeeEntity>), typeof(EmployeeRepository));

            // Service dependencies
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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