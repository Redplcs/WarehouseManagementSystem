using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class ShipmentResource : Entity<ShipmentResource>
{
    public required ShipmentDocument Document { get; set; }
    public required Resource Resource { get; set; }
    public required MeasurementUnit MeasurementUnit { get; set; }
    public decimal Quantity { get; set; }
}
