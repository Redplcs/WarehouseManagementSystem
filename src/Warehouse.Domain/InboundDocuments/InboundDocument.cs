using Warehouse.Shared;

namespace Warehouse.Domain.InboundDocuments;

public sealed class InboundDocument : Entity<InboundDocument>
{
    public int Number { get; set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;

    public ICollection<InboundResource> Items { get; set; } = [];
}
