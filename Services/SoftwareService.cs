using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vszk.Services
{
    public class SoftwareService : ISoftwareService
    {
        private static List<Software> Softwares = new List<Software>
        {
            new Software(),
            new Software()
        };

        public async Task<List<Software>> GetAllSoftwares()
        {
            return Softwares;
        }

        public async Task<Software> GetSoftwareById(int id)
        {
            var software = Softwares.FirstOrDefault(c => c.SoftwareID == id);
            if(software is not null) return software;

            throw new Exception("Software not found");
        }
    }
}