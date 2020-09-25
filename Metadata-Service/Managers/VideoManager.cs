using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Metadata_Service.DataTransferObjects;
using Metadata_Service.Events;
using Metadata_Service.Models;
using Metadata_Service.Repositories;

namespace Metadata_Service.Managers
{
    public class VideoManager : IVideoManager
    {
        private readonly IVideoRepository _videoRepository;
        private readonly IMapper _mapper;

        public VideoManager(IVideoRepository videoRepository, IMapper mapper)
        {
            _videoRepository = videoRepository;
            _mapper = mapper;
        }

        public async Task<VideoOutputDto> InsertAsync(CmsInfoInputDto input)
        {
            var entity = _mapper.Map<Video>(input);

            var inserted = await _videoRepository.InsertAsync(entity);
            return _mapper.Map<VideoOutputDto>(inserted);
        }

        public async Task<VideoOutputDto> UpdateAsync(VideoProcessedInputDto input)
        {
            var entity = await _videoRepository.GetAsync(input.Id);

            _mapper.Map(input, entity);

            var updated = await _videoRepository.UpdateAsync(entity);
            return _mapper.Map<VideoOutputDto>(updated);
        }

        public async Task<VideoOutputDto> UpdateAsync(CmsInfoInputDto input)
        {
            var entity = await _videoRepository.GetAsync(input.Id);

            _mapper.Map(input, entity);

            var updated = await _videoRepository.UpdateAsync(entity);
            return _mapper.Map<VideoOutputDto>(updated);
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<VideoOutputDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<VideoOutputDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
