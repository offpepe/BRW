using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.API.Entities;

public class Group: Basis
{
    public List<Team> Teams { get; set; }
    public List<User> Players { get; set; }
    public List<Prize> Prizes { get; set; }
}