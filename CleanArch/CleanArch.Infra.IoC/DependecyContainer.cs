using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using CleanArch.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Core.Bus;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using MediatR;
using CleanArch.Domain.Commands;
using CleanArch.Domain.CommandHandlers;

namespace CleanArch.Infra.IoC
{
    public class DependecyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Domain InMemory Mediatr
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand,bool>, CourseCommandHandler>();

            //Application layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();
        }
    }
}
