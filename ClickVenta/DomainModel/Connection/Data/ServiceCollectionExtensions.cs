using DomainModel.Connection.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Connection.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSqlConnectionFactory(this IServiceCollection services)
        {
            // Scoped: una fábrica por scope (por ventana / request / unit-of-work)
            services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();
            return services;
        }

        /// <summary>
        /// Registra automáticamente todos los repositorios que heredan de RepositoryBase&lt;T&gt;
        /// y también los repositorios concretos que implementan una interfaz.
        /// </summary>
        public static IServiceCollection AddRepositories(this IServiceCollection services, params Type[] types)
        {
            if (types.Length % 2 != 0)
                throw new ArgumentException(
                    "Debes pasar los tipos en pares (interfaz, implementación).",
                    nameof(types));

            for (int i = 0; i < types.Length; i += 2)
            {
                var serviceType = types[i];
                var implementationType = types[i + 1];

                // Validación de seguridad: evita exactamente el error actual
                if (serviceType == implementationType)
                    throw new InvalidOperationException(
                        $"El par ({serviceType.Name}, {implementationType.Name}) es inválido: " +
                        $"el servicio y la implementación no pueden ser el mismo tipo.");

                if (serviceType.IsInterface && implementationType.IsInterface)
                    throw new InvalidOperationException(
                        $"El par ({serviceType.Name}, {implementationType.Name}) es inválido: " +
                        $"la implementación debe ser una clase concreta, no una interfaz.");

                if (!serviceType.IsAssignableFrom(implementationType))
                    throw new InvalidOperationException(
                        $"{implementationType.Name} no implementa {serviceType.Name}.");

                services.AddScoped(serviceType, implementationType);
            }

            return services;
        }
    }
}
