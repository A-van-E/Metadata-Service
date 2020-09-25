using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata_Service.DataTransferObjects
{
    public class CmsInfoInputDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public Guid ThemeId { get; set; }
    }
}
