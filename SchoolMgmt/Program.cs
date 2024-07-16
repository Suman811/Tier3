
using Microsoft.EntityFrameworkCore;
using SchoolMgmt.BAL.ServiceInterface;
using SchoolMgmt.BAL.Services;
using SchoolMgmt.DAL.DBContext;
using SchoolMgmt.DAL.Repositories;
using SchoolMgmt.DAL.RepositoyInterface;


namespace SchoolMgmt
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

            IServiceCollection serviceCollection = builder.Services.AddDbContext<databasecontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connect")));


            builder.Services.AddTransient<IStudentRepository,StudentRepository>();
            builder.Services.AddTransient<IStudentService, StudentService>();

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
