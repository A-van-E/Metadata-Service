using System;
using System.Threading.Tasks;
using Metadata_Service.Models;

namespace Metadata_Service.Repositories
{
    public class ThemeRepository : IThemeRepository
    {
        public Task<Theme> InsertAsync(Theme entity)
        {
            throw new NotImplementedException();
        }

        public Task<Theme> UpdateAsync(Theme entity)
        {
            throw new NotImplementedException();
        }
    }
}