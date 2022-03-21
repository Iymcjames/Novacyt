using System.Threading.Tasks;
using NovacytMapIntegration.Models;

namespace NovacytMapIntegration.Repositories
{
    public interface ILocationsRepository
    {
        Task<LocationCollection> GetAllLocations();
    }
}
