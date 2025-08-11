using Warehouse.Shared;

namespace Warehouse.Domain.Common;

public sealed class MeasurementUnit : Entity<MeasurementUnit>
{
    public required string Name { get; set; }
    public RecordState State { get; set; }
}
