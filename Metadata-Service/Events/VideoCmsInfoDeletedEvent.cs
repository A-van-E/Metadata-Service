using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.Events
{
    public class VideoCmsInfoDeletedEvent : IEvent<Guid>
    {
        public Guid EventId { get; set; }

        public Guid Data { get; set; }
    }
}
