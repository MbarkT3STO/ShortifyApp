
namespace LinkShortenerService.Application.Common;

/// <summary>
/// Represents a shortened URL.
/// </summary>
public class ShortenedUrl(string code, string shortUrl)
{
	/// <summary>
	/// Gets or sets the code associated with the shortened URL.
	/// </summary>
	public string Code { get; set; } = code;

	/// <summary>
	/// Gets or sets the short URL.
	/// </summary>
	public string ShortUrl { get; set; } = shortUrl;

	/// <summary>
	/// Deconstructs the <see cref="ShortenedUrl"/> object into its individual properties.
	/// </summary>
	/// <param name="Code">The code of the shortened URL.</param>
	/// <param name="ShortUrl">The short URL.</param>
	/// <returns>A tuple containing the code and the short URL.</returns>
	/// <example>
	/// <code>
	/// var shortenedUrl = new ShortenedUrl("abc123", "http://localhost/abc123");
	/// var (code, shortUrl) = shortenedUrl;
	/// </code>
	/// </example>
	internal void Deconstruct(out string Code, out string ShortUrl)
	{
		Code = this.Code;
		ShortUrl = this.ShortUrl;
	}
}