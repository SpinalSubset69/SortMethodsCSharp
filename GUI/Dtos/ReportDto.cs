using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GUI.Dtos
{
    public class ReportDto
    {        
        public int Id { get; set; }
        public string Method { get; set; }
        public int NumberElements { get; set; }
        public long TimeElapsed { get; set; }

    }
}
