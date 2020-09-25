using System;
using Metadata_Service.DataTransferObjects;

namespace Metadata_Service.Events
{
    public class VideoCmsInfoCreatedEvent : IEvent<CmsInfoInputDto>
    {
        public Guid EventId { get; set; }

        public CmsInfoInputDto Data { get; set; }
    }
}
