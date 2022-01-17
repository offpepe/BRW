namespace BRW.API.Entities.Interfaces;

public interface IUser
{
    public IUser GetUserById(Guid id);

    public IUser UpdateUser();

    public IUser ToggleGroup(Guid groupId);

    public IUser JoinTeam(Guid teamId);

}