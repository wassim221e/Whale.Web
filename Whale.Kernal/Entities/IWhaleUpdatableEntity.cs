namespace Whale.Entities;

public interface IWhaleUpdatableEntity:IWhaleEntity
{
    public DateTimeOffset UtcDateUpdated { get; set; }
}