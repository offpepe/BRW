using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.API.Entities;

public class Championship : Basis
{
    
    [Column("Jogo")]
    public int GameId { get; set; }
    public virtual Game Game { get; set; }
    
    public List<User> Apresentadores { get; set; }
    
    public List<User> Mvps { get; set; }
    
    public List<Player> Players { get; set; }
}

