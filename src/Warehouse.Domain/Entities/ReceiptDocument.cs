using Warehouse.Shared;

namespace Warehouse.Domain.Entities;

public sealed class ReceiptDocument : Entity
{
    public int Number { get; set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;

    public ICollection<ReceiptResource> Items { get; set; } = [];
}
