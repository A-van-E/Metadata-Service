using AutoMapper;
using Metadata_Service.DataTransferObjects;
using Metadata_Service.Models;

namespace Metadata_Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VideoProcessedInputDto, Video>()
                .ForMember(dest => dest.Description, opt => opt.Ignore())
                .ForMember(dest => dest.ThemeId, opt => opt.Ignore())
                .ForMember(dest => dest.Theme, opt => opt.Ignore())
                .ForMember(dest => dest.Title, opt => opt.Ignore())
                .ForMember(dest => dest.Url, opt => opt.Ignore());

            CreateMap<CmsInfoInputDto, Video>()
                .ForMember(dest => dest.Processed, opt => opt.Ignore())
                .ForMember(dest => dest.Theme, opt => opt.Ignore());

            CreateMap<Video, VideoOutputDto>();

            CreateMap<Theme, ThemeOutputDto>();
        }
    }
}
