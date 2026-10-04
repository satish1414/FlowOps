using System.Text.Json;
using System.Text.Json.Serialization;

namespace FlowOps.FlowOps.Domain.Entities
{
    public class WorkItem
    {
        [JsonPropertyName("orderid")]
        public Guid OrderId { get; set; }
        [JsonPropertyName("orderitemname")]
        public string? OrderItemName { get; set; }
        [JsonPropertyName("orderquantity")]
        public int OrderQuantity { get; set; }
    }
}
