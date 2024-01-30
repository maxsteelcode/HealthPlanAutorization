using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareAuthorization.Models
{
    public class Diagnostics
    {
        public string Decease { get; set; }

        public int DeceaseId { get; set; }

        public Diagnostics()
        {
                
        }

        public Diagnostics(string decease, int deceaseId)
        {
            Decease = decease;
            DeceaseId = deceaseId;
        }
    }
}
