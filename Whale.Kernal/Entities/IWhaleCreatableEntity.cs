namespace Whale.Entities;

public interface IWhaleCreatableEntity:IWhaleEntity
{
    public DateTimeOffset UtcDateCreated { get; set; }
}