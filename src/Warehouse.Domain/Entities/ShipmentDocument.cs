using Warehouse.Domain.ValueObjects;
using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class ShipmentDocument : Entity<ShipmentDocument>
{
    public required Customer Customer { get; set; }

    public int Number { get; set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
    public ShipmentDocumentState State { get; set; }

    public ICollection<ShipmentResource> Items { get; set; } = [];
}
