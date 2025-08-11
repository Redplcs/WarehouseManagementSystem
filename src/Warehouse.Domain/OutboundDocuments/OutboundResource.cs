using Warehouse.Domain.Common;
using Warehouse.Domain.OutboundDocuments;
using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class OutboundResource : Entity<OutboundResource>
{
    public required OutboundDocument Document { get; set; }
    public required Resource Resource { get; set; }
    public required MeasurementUnit MeasurementUnit { get; set; }
    public decimal Quantity { get; set; }
}
