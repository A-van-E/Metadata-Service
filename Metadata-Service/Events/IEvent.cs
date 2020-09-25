using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.Events
{
    public interface IEvent<T>
    {
        Guid EventId { get; set; }

        T Data { get; set; }
    }
}
