using BTCStats.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BTCStats.Services
{
    public class PriceService : IPriceService
    {
        private readonly HttpClient httpClient;

        public PriceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<PriceModel>> GetPrices()
        {
            return await httpClient.GetJsonAsync<PriceModel[]>("bpi/historical/close.json?start=2020-08-01&end=2020-09-16");
        }
    }
}
