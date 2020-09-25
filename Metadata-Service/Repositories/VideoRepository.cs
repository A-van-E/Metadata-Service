using System;
using System.Threading.Tasks;
using Metadata_Service.Models;

namespace Metadata_Service.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        public Task<Video> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Video> InsertAsync(Video entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Video> UpdateAsync(Video entity)
        {
            throw new NotImplementedException();
        }
    }
}