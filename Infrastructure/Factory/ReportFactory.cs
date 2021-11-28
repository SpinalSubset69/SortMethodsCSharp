using Entities.Entities;
using Entities.Exceptions;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Factory
{
    public class ReportFactory : IReportFactory
    {       
        private int id { get; set; }

        public ReportFactory()
        {
        }

        public Report MakeReport(String method, int numberElements, long timeElapsed)
        {
            var report = ValidateReport(method, numberElements, timeElapsed);
            return report;
        }

        public Report ValidateReport(string method, int numberElements, long timeElapsed)
        {
            ValidateMethod(method);
            ValidateNumberElements(numberElements);
            ValidateTimeElapsed(timeElapsed);
            var report = new Report((++id), method, numberElements, timeElapsed);
            return report;
        }

        private void ValidateTimeElapsed(long timeElapsed)
        {
            //if (timeElapsed < 0)
            //{
            //    throw new PropertyException("Tiempo de ejecución no puede ser menor a 0");
            //}
        }

        private void ValidateNumberElements(int numberElements)
        {
            if (numberElements <= 0)
            {
                throw new PropertyException("Número de elementos debe ser mayor a 0");
            }
        }

        private void ValidateMethod(string method)
        {
            string[] methods = { "Burble", "Insertion", "Selection", "Merge", "QuickSort" };

            if (!methods.Contains(method))
            {
                throw new PropertyException("El método de ordenamiento no se encuentra disponible");
            }
        }
               
    }
}
