using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.API.Entities;

public class Player : User
{
    
    public int ChampionshipPlayedId { get; set; }
    public virtual Championship Championship { get; set; }

}