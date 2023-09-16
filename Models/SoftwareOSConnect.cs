using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vszk.Models
{
    public class SoftwareOSConnect
    {
        public int SoconnectID { get; set; }
        
        public OS OS { get; set; }       
        
        public Software Software { get; set; } 
    }
}