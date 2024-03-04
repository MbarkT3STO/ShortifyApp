using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shared.Database.Data;

namespace DatabaseService.DI;

public static class DatabaseDIExtensions
{
	/// <summary>
	/// Adds database services to the specified <see cref="IServiceCollection"/>.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <returns>The modified <see cref="IServiceCollection"/>.</returns>
	public static IServiceCollection AddDatabaseServices(this IServiceCollection services, string connectionString)
	{
		services.AddDbContext<AppDbContext>(options =>
		{
			options.UseNpgsql(connectionString, x => x.MigrationsAssembly("DatabaseService"));
		});

		return services;
	}
}
