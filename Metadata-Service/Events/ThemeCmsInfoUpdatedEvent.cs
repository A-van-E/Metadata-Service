using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metadata_Service.DataTransferObjects;

namespace Metadata_Service.Events
{
    public class ThemeCmsInfoUpdatedEvent : IEvent<ThemeInputDto>
    {
        public Guid EventId { get; set; }
        public ThemeInputDto Data { get; set; }
    }
}
