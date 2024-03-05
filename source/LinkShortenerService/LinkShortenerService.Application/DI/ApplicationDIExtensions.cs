using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using LinkShortenerService.Application.Options;
using LinkShortenerService.Application.RPC;
using Microsoft.Extensions.DependencyInjection;

namespace LinkShortenerService.Application.DI;

public static class ApplicationDIExtensions
{
	/// <summary>
	/// Adds Shortener Service Application services to the specified <see cref="IServiceCollection"/>.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
	/// <returns>The modified <see cref="IServiceCollection"/>.</returns>
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
		services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

		services.Configure<RpcConnectionSettingsForDatabaseService>(options =>
		{
			options.Host = "http://localhost";
			options.Port = 5256;
		});

		services.AddSingleton<DatabaseRpcClientProvider>();

		return services;
	}
}
