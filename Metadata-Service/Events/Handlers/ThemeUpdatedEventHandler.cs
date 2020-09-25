using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.Events.Handlers
{
    public class ThemeUpdatedEventHandler : IEventHandler<ThemeCmsInfoUpdatedEvent>
    {
        public Task HandleAsync(ThemeCmsInfoUpdatedEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
