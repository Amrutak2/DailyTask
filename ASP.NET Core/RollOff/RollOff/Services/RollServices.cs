using RollOff.Helpers;
using RollOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RollOff.Services
{
    public class RollServices
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/Employee";

        public RollServices(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<SupplyDatum>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<SupplyDatum>>();
        }
    }
}
