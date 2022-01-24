namespace BRW.Domain.Entities;

public class Team : Basis
{
    public List<User> Integrants { get; set; }
}