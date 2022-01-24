namespace BRW.Domain.Entities;

public class Championship
{
    public string Title { get; set; }
    public int Id { get; set; }
    public Guid Guid { get; set; }
    public List<Team> Teams { get; set; }
    public List<Prize> Prizes { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}