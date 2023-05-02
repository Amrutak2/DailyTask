using RollOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOff.Services
{
    public interface IService
    {
        Task<IEnumerable<SupplyDatum>> Find();
    }
    
}
