namespace Whale.Entities;

public interface IWhaleEntity<TKey>:IWhaleEntity
{
    public TKey Id { get; set; }
}