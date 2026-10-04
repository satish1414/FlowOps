using System.Text.Json;
using System.Text.Json.Serialization;

namespace FlowOps.FlowOps.Domain.Entities
{
    public class WorkItem
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
    }
}
