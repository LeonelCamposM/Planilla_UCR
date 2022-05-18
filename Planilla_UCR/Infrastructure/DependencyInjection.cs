﻿using Domain.Core.Repositories;
using Infrastructure.Projects;
using Infrastructure.Projects.Repositories;
using Domain.Projects.Repositories;
using Infrastructure.Persons;
using Infrastructure.Persons.Repositories;
using Domain.Persons.Repositories;
using Domain.Projects.Repositories;
using Infrastructure.Employees;
using Infrastructure.Employees.Repositories;
using Domain.Employees.Repositories;
using Application.Projects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IProjectRepository, ProjectRepository>();

            services.AddDbContext<PersonDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IPersonRepository, PersonRepository>();

            services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
