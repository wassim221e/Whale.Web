namespace Whale.Entities;

public interface IWhaleDeletableEntity:IWhaleEntity
{
    public DateTimeOffset ?UtcDateDeleted { get; set; }
}