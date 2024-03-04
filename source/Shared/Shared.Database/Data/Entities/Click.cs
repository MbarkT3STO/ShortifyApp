namespace Shared.Database.Data.Entities;

public class Click
{
	public int Id { get; set; }
	public int LinkId { get; set; }
	public DateTime ClickDateTime { get; set; }
	public string IpAddress { get; set; }
	public string UserAgent { get; set; }

	public virtual Link Link { get; set; }
}
