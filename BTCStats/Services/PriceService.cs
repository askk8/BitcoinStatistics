using BTCStats.Data;
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

        public async Task<IEnumerable<ApiResponse>> GetPrices()
        {
            return await httpClient.GetJsonAsync<ApiResponse[]>("api/v3/coins/ethereum/history?date=16-09-2020");
        }
    }
}
