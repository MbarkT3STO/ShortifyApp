using Microsoft.Extensions.DependencyInjection;
using Shared.Database.RPC.Options;

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

		services.Configure<DatabaseRpcConnectionSettings>(options =>
		{
			options.Host = "http://localhost";
			options.Port = 5256;
		});

		services.AddSingleton<HostDetails>(new HostDetails("http://localhost", 5211));
		services.AddSingleton<UrlService>();
		services.AddSingleton<DatabaseRpcClientContext>();

		return services;
	}
}
