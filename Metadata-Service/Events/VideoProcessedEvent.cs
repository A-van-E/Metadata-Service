using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metadata_Service.DataTransferObjects;

namespace Metadata_Service.Events
{
    public class VideoProcessedEvent : IEvent<VideoProcessedInputDto>
    {
        public Guid EventId { get; set; }

        public VideoProcessedInputDto Data { get; set; }
    }
}
