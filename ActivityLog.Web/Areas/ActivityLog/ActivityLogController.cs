using System.Collections.Generic;
using System.Threading.Tasks;
using ActivityLog.Web.Areas.ActivityLog.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ActivityLog.Web.Areas.ActivityLog
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityLogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivityLogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task Save([FromBody]ActivityEntryModel entry)
        {
            await _mediator.Publish(new SaveActivityLogCommand
            {

            });
        }

        [HttpGet]
        public async Task<IEnumerable<ActivityEntryModel>> Get(int page = 0, int pageSize = 10)
        {
            return await _mediator.Send(new ListActivityLogsQuery
            {
                Page = page,
                PageSize = pageSize
            });
        }
    }
}
