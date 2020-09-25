using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metadata_Service.DataTransferObjects;

namespace Metadata_Service.Events
{
    public class VideoCmsInfoUpdatedEvent : IEvent<CmsInfoInputDto>
    {
        public Guid EventId { get; set; }

        public CmsInfoInputDto Data { get; set; }
    }
}
