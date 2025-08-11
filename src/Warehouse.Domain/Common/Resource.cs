using Warehouse.Domain.Common;
using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class Resource : Entity<Resource>
{
    public required string Name { get; set; }
    public RecordState State { get; set; }
}
