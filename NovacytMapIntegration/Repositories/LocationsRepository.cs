using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NovacytMapIntegration.Models;

namespace NovacytMapIntegration.Repositories
{
    public class LocationsRepository : ILocationsRepository
    {
        public LocationsRepository()
        {

        }

        public async Task<LocationCollection> GetAllLocations()
        {
            var locationsJson = File.ReadAllText("locations.json");
            var locations =  JsonConvert.DeserializeObject<LocationCollection>(locationsJson);
            return locations;
        }
    }
}
