using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metadata_Service.Models;

namespace Metadata_Service.Repositories
{
    public interface IThemeRepository
    {
        Task<Theme> InsertAsync(Theme entity);

        Task<Theme> UpdateAsync(Theme entity);
    }
}
