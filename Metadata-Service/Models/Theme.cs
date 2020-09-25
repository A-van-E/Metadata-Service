using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.Models
{
    public class Theme : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
