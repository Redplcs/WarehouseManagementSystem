using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class Balance : Entity<Balance>
{
    public required Resource Resource { get; set; }
    public required MeasurementUnit MeasurementUnit { get; set; }
    public decimal Quantity { get; set; }
}
