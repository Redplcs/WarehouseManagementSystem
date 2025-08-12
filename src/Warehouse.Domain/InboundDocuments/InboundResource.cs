using Warehouse.Domain.Common;
using Warehouse.Shared;

namespace Warehouse.Domain.InboundDocuments;

public sealed class InboundResource : Entity<InboundResource>
{
    public required InboundDocument Document { get; set; }
    public required Resource Resource { get; set; }
    public required MeasurementUnit MeasurementUnit { get; set; }
    public decimal Quantity { get; set; }
}
