using Warehouse.Domain.Common;
using Warehouse.Domain.Entities;
using Warehouse.Shared;

namespace Warehouse.Domain.OutboundDocuments;

public sealed class OutboundDocument : Entity<OutboundDocument>
{
    public required Customer Customer { get; set; }

    public int Number { get; set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
    public OutboundDocumentState State { get; set; }

    public ICollection<OutboundResource> Items { get; set; } = [];
}
