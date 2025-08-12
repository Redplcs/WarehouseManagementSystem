namespace Warehouse.Shared;

public abstract class Entity<TSelf> : IEquatable<Entity<TSelf>>
    where TSelf : Entity<TSelf>
{
    public Id<TSelf> Id { get; init; } = Id<TSelf>.New();

    public bool Equals(Entity<TSelf>? other)
    {
        return Id == other?.Id;
    }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TSelf> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(Entity<TSelf>? left, Entity<TSelf>? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Entity<TSelf>? left, Entity<TSelf>? right)
    {
        return !Equals(left, right);
    }
}
