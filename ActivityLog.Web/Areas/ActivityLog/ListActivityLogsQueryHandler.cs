using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ActivityLog.Web.Areas.ActivityLog.Models;
using MediatR;

namespace ActivityLog.Web.Areas.ActivityLog
{
    public class ListActivityLogsQuery : IRequest<IEnumerable<ActivityEntryModel>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }

    public class ListActivityLogsQueryHandler : IRequestHandler<ListActivityLogsQuery, IEnumerable<ActivityEntryModel>>
    {
        public Task<IEnumerable<ActivityEntryModel>> Handle(ListActivityLogsQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
