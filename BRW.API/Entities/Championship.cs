using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.API.Entities;

public class Championship: Basis
{
    public int TeamId { get; set; }
    public int GameId { get; set; }
}