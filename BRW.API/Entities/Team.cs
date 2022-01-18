using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.API.Entities;

public class Team: Basis
{
    public List<Championship> Championships { get; set; }
    public List<User> Players { get; set; }
    public List<Prize> Prizes { get; set; }
}