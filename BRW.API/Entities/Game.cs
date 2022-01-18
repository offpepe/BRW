namespace BRW.API.Entities;

public class Game: Basis
{
    public char Genre { get; set; }
    public virtual List<Championship> Championships { get; set; }
}