using Warehouse.Domain.ValueObjects;
using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class Resource : Entity
{
    public required string Name { get; set; }
    public RecordState State { get; set; }
}
