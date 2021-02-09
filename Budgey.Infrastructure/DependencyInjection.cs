
using Budgey.Domain.Interfaces;
using Budgey.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Budgey.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<INoteRepository, NoteRepository>();
            services.AddTransient<IExpenseRepository, ExpenseRepository>();
            return services;
        }
    }
}
