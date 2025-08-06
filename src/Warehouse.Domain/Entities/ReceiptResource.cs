using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class ReceiptResource : Entity
{
    public required ReceiptDocument Document { get; set; }
    public required Resource Resource { get; set; }
    public required MeasurementUnit MeasurementUnit { get; set; }
    public decimal Quantity { get; set; }
}
