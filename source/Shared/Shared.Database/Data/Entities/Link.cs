namespace Shared.Database.Data.Entities;

public class Link
{
	public int Id { get; set; }
	public string OriginalUrl { get; set; }
	public string ShortCode { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime? ExpirationDate { get; set; }
}
