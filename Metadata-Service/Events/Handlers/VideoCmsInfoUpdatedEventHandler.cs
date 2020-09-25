using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.Events.Handlers
{
    public class VideoCmsInfoUpdatedEventHandler : IEventHandler<ThemeUpdatedEventHandler>
    {
        public Task HandleAsync(ThemeUpdatedEventHandler @event)
        {
            throw new NotImplementedException();
        }
    }
}
