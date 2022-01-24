using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.Domain.Entities;

public class Group : Basis
{
    public List<Team> Teams { get; set; }
    public virtual Team Team { get; set; }
}