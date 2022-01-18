using System.ComponentModel.DataAnnotations.Schema;
using BRW.API.Entities.Interfaces;

namespace BRW.API.Entities;

public class Player : User
{
    
    public int ChampionshipPlayedId { get; set; }
    public virtual Championship Championship { get; set; }

}