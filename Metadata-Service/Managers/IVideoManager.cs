using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metadata_Service.DataTransferObjects;
using Metadata_Service.Events;

namespace Metadata_Service.Managers
{
    public interface IVideoManager
    {
        Task<VideoOutputDto> InsertAsync(CmsInfoInputDto input);

        Task<VideoOutputDto> UpdateAsync(VideoProcessedInputDto input);

        Task<VideoOutputDto> UpdateAsync(CmsInfoInputDto input);

        Task DeleteAsync(Guid id);

        Task<VideoOutputDto> GetAsync(Guid id);

        Task<List<VideoOutputDto>> GetAllAsync();
    }
}
