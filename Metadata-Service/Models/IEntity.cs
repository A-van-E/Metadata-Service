using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
