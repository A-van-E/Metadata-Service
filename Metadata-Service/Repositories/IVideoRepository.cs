using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metadata_Service.Models;

namespace Metadata_Service.Repositories
{
    public interface IVideoRepository
    {
        Task<Video> GetAsync(Guid id);

        Task<Video> InsertAsync(Video entity);

        Task<Video> UpdateAsync(Video entity);

    }
}
