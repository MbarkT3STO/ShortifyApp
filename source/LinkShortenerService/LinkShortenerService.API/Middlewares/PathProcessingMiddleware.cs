namespace LinkShortenerService.API.Middlewares;

/// <summary>
/// Middleware for processing the request path and performing redirection based on the path value.
/// </summary>
public class PathProcessingMiddleware(RequestDelegate next)
{
	private readonly RequestDelegate _next = next;

	/// <summary>
	/// Invokes the middleware to process the request path and perform redirection.
	/// </summary>
	/// <param name="context">The HttpContext representing the current request.</param>
	public async Task Invoke(HttpContext context)
	{
		var path = context.Request.Path;

		if (path.Value == "/" || path.Value.Contains("/api/"))
		{
			await _next(context);
			return;
		}

		// Extract code from path
		var shortCode = path.Value?.Substring("/".Length);

		if (path.Value.StartsWith("/code/"))
		{
			var exclude   = "/code/";
			    shortCode = path.Value.Substring(exclude.Length);

			// Redirect to the desired controller action
			context.Response.Redirect($"/api/Links/Redirect/{shortCode}");
		}
		else if (!path.Value.StartsWith("/code/"))
		{
			// Add /code/ to the path
			context.Response.Redirect($"/code/{shortCode}");
		}
	}
}