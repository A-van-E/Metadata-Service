using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metadata_Service.Managers;

namespace Metadata_Service.Events.Handlers
{
    public class VideoProcessedEventHandler : IEventHandler<VideoProcessedEvent>
    {
        private readonly IVideoManager _videoManager;

        public VideoProcessedEventHandler(IVideoManager videoManager)
        {
            _videoManager = videoManager;
        }

        public async Task HandleAsync(VideoProcessedEvent @event)
        {
            await _videoManager.UpdateAsync(@event.Data);
        }
    }
}
