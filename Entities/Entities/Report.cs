using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Report : BaseEntity
    {
        public string Method { get; set; }
        public int NumberElements { get; set; }
        public long TimeElapsed { get; set; }

        public Report(int id, string method, int numberElements, long timeElapsed): base(id)
        {
            Method = method;
            NumberElements = numberElements;
            TimeElapsed = timeElapsed;
        }
    }
}
