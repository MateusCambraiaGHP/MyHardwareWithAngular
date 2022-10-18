using Microsoft.Extensions.DependencyInjection;
using MyHardware.Infrastructure.Common.Interfaces;
using MyHardware.Infrastructure.Data;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Infrastructure.Repository;
using MyHardwareWeb.Infrastructure.Services;

namespace MyHardwareWeb.Infrastructure.Common.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext, ApplicationMySqlDbContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ISupplierProductRepository, SupplierProductRepository>();
            services.AddScoped<ISupplierProductCustomerRepository, SupplierProductCustomerRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEmailService, EmailService>();
            return services;
        }
    }
}