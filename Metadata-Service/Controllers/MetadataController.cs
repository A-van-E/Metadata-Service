using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Metadata_Service.DataTransferObjects;
using Metadata_Service.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Metadata_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetadataController : ControllerBase
    {
        private readonly ILogger<MetadataController> _logger;
        private readonly IVideoManager _videoManager;

        public MetadataController(ILogger<MetadataController> logger, IVideoManager videoManager)
        {
            _logger = logger;
            _videoManager = videoManager;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<VideoOutputDto> Get(Guid id)
        {
            return await _videoManager.GetAsync(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<List<VideoOutputDto>> GetAll()
        {
            return await _videoManager.GetAllAsync();
        }
    }
}
