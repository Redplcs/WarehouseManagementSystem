using Warehouse.Shared;

namespace Warehouse.Domain.Common;

public sealed class Customer : Entity<Customer>
{
    public required string Name { get; set; }
    public required string Address { get; set; }
    public RecordState State { get; set; }
}
