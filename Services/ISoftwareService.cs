using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vszk.Services
{
    public interface ISoftwareService
    {
        Task<List<Software>> GetAllSoftwares();

        Task<Software> GetSoftwareById(int id);
    }
}