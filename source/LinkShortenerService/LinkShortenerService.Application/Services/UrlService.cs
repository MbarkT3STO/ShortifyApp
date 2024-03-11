namespace LinkShortenerService.Application.Services;

/// <summary>
/// Provides functionality to shorten URLs.
/// </summary>
public class UrlService(HostDetails hostDetails)
{
	readonly HostDetails _hostDetails = hostDetails;

    /// <summary>
    /// Shortens the specified original URL.
    /// </summary>
    /// <param name="originalUrl">The original URL to be shortened.</param>
    /// <returns>The shortened URL.</returns>
    public ShortenedUrl ShortenUrl(string originalUrl)
	{
		var code     = GenerateShortCode();
		var shortUrl = $"{_hostDetails.Host}:{_hostDetails.Port}/{code}";
		var result   = new ShortenedUrl(originalUrl, shortUrl);

		return result;
	}

	private string GenerateShortCode()
	{
		var chars       = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		var stringChars = new char[8];
		var random      = new Random();

		for (int i = 0; i < stringChars.Length; i++)
		{
			stringChars[i] = chars[random.Next(chars.Length)];
		}

		return new string(stringChars);
	}
}