using FlowOps.FlowOps.Application.WorkItems;
using FlowOps.FlowOps.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemController : ControllerBase
    {

        private readonly IWorkItemService _workItemService;

        public WorkItemController(IWorkItemService workItemService)
        {
            _workItemService = workItemService;
        }

        #region GetRequests

        [HttpGet("getallworkitemdetails")]
        public IEnumerable<WorkItem> GetAll()
        {

           return _workItemService.GetAll();
            
        }

        [HttpGet("{orderId}")]
        public WorkItem? GetById(Guid orderId)
        {
           return _workItemService.GetById(orderId);
           
        }

        #endregion

        [HttpPost]
        public WorkItem Create(WorkItem orderItem)
        {
            return _workItemService.Create(orderItem);
        }


        [HttpPut]
        public WorkItem Update(WorkItem orderItem)
        {
           return _workItemService.Update(orderItem);
        }

        [HttpDelete("{orderId}")]
        public bool Delete(Guid orderId)
        {
            return _workItemService.Delete(orderId);
        }
    }
}
