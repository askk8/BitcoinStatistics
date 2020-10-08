using BTCStats.Data;
using BTCStats.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Services
{
    public interface IPriceService
    {
        Task<IEnumerable<ApiResponse>> GetPrices();
    }
}
