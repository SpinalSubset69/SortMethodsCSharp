using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IReportFactory
    {
        Report MakeReport(String method, int numberElements, long timeElapsed);
        Report ValidateReport(String method, int numberElements, long timeElapsed);

    }
}
