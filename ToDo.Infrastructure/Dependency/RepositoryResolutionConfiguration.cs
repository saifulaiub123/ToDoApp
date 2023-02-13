﻿using ToDo.Domain.DBModel;
using Microsoft.Extensions.DependencyInjection;
using ToDo.Domain.IRepository;
using ToDo.Infrastructure.Repository;

namespace ToDo.Infrastructure.Dependency
{
    public static class RepositoryResolutionConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Agent, int>, Repository<Agent,int>>();
            services.AddScoped<IRepository<Otp, int>, Repository<Otp,int>>();
            services.AddScoped<IRepository<TODO, int>, Repository<TODO,int>>();
            return services;
        }
    }
}
