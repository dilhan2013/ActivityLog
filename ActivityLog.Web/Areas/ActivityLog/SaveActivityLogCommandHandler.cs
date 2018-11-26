using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ActivityLog.Web.Areas.ActivityLog.Models;
using MediatR;

namespace ActivityLog.Web.Areas.ActivityLog
{
    public class SaveActivityLogCommand : INotification
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }

    public class SaveActivityLogCommandHandler : INotificationHandler<SaveActivityLogCommand>
    {
        public Task Handle(SaveActivityLogCommand notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
