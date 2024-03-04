namespace Shared.Database.Data.Entities;

public class Link
{
	public int Id { get; set; }
	public string OriginalUrl { get; set; }
	public string ShortUrl { get; set; }
	public DateTime CreationDateAndTime { get; set; }
	public DateTime? ExpirationDateAndTime { get; set; }
	public bool IsActive { get; set; }

	public virtual ICollection<Click> Clicks { get; set; }
}
