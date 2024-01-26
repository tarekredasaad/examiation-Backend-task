
using Domain.Interfaces.Services;
using Domain.Interfaces.UnitOfWork;
using Domain.Models;
using Infrastructure;
using Infrastructure.UnitOfWork;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DynamicAuthApi.Middlewaare;
//using DynamicAuthApi.AuthorizationRequirement;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json.Serialization;
using System.Reflection;
using Infrastructure.Answers.Query;
using MediatR;
using Domain.DTO;
using Infrastructure.MapperProfile;
using Infrastructure.Answers.Commands;

namespace DynamicAuthApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddJsonOptions(x =>
               x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // Add services to the container.
            builder.Services.AddDbContext<Context>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("Default"));

            });
           
            builder.Services.AddTransient< CustomMiddleWare>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<assessment_Answers_Service, assessment_Answers_Service>();
            builder.Services.AddTransient<IRequestHandler<AnswerByIdQuery, assessment_answers>, AnswerQueryHandler>();
            builder.Services.AddTransient<IRequestHandler<AnswerAddCommand, Assessment_AnswersDTO>, AnswerCommandHandler>();

            //builder.Services.AddScoped<IAuthorizationHandler, GroupPermissionAuthorizationHandler>();
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())); // instead name of each one 
            builder.Services.AddAutoMapper(typeof(AnswersProfile).Assembly);
            builder.Services.AddAutoMapper(typeof(AnswerAddCommandProfile).Assembly);
            
            builder.Services.AddLogging(builder => builder.AddDebug());

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
            app.UseMiddleware<CustomMiddleWare>();
            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseAuthorization();
            

            app.MapControllers();

            app.Run();
        }
    }
}