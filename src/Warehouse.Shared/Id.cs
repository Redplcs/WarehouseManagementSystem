namespace Warehouse.Shared;

public readonly record struct Id<TEntity>(Guid Value)
{
    public static Id<TEntity> New() => new(Guid.NewGuid());
}