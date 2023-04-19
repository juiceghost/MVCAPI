

using Microsoft.EntityFrameworkCore;
using MVCAPI.Data.EFCore;
using MVCAPI.Models;
using MVCAPI.Data;


namespace MVCAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<MVCAPIContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MVCAPIContext")));


        // Read https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
        // Du behöver 3 models och 3 repos.
        builder.Services.AddScoped<EfCoreMovieRepository>();
        builder.Services.AddScoped<EfCoreGenreRepository>();
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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

