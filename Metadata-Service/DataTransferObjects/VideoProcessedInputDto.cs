using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.DataTransferObjects
{
    public class VideoProcessedInputDto
    {
        public Guid Id { get; set; }

        public bool Processed { get; set; }
    }
}
