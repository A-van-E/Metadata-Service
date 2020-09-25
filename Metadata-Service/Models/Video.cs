using System;

namespace Metadata_Service.Models
{
    public class Video : IEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public bool Processed { get; set; }

        public Guid ThemeId { get; set; }

        public Theme Theme { get; set; }
    }
}
