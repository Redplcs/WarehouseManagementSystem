using Warehouse.Shared;

namespace Warehouse.Domain.Common;

public sealed class Resource : Entity<Resource>
{
    public required string Name { get; set; }
    public RecordState State { get; set; }
}
