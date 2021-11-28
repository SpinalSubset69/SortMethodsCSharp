using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Entities;
using Entities.Exceptions;
using Entities.Interfaces;
using GUI.Dtos;
using Infrastructure.Data;
using Infrastructure.Extensions;
using Infrastructure.Factory;

namespace Infrastructure.Logic
{
    public class ArrayLogic
    {
        private int[] array;
        private int[] tempArray;
        private IGenericRepository<Report> _repo;
        private IReportFactory _reportFactory;

        public ArrayLogic()
        {
            _repo = new GenericRepository<Report>();
            _reportFactory = new ReportFactory();
        }

        public async Task<int[]> GenerateArrayAndFillRandomNumbers()
        {            
            return await this.array.GenerateAndFillArrayWithRandomNumbers();            
        }

        public async Task SortArrayBasedOnMethod(string method)
        {
            var timer = new Stopwatch();
            timer.Start();
            switch (method)
            {
                case "Burble":
                    array = await array.BurbleSort();
                    break;
                case "QuickSort":
                    await array.QuickSort(0, array.Length - 1);
                    break;
                case "Merge":
                    array = await array.mergeSort();
                    break;
                case "Selection":
                    array = await array.Selection();
                    break;
                case "Insertion":
                    array = await array.InsertionSort();
                    break;
            }
            timer.Stop();

            TimeSpan ts = timer.Elapsed;            
            AddReport(method, (long)ts.TotalSeconds);
            tempArray = array;
            array = null;            
        }        

        public void InitialieArray(int nElements) {
            array = new int[nElements];
            tempArray = new int[nElements];
        }
        public int[] GetArray()
        {
            return tempArray;
        }

        public void AddReport(string method, long timeElapsed)
        {
            var report = _reportFactory.MakeReport(method, array.Length, timeElapsed);
            _repo.AddAsync(report);
        }
        public async Task<List<ReportDto>> GetReportsAsync()
        {           
            var listReports = await _repo.GetAllAsync();
            var config= new MapperConfiguration(cfg => cfg.CreateMap<Report, ReportDto>());
            var mapper = new Mapper(config);
            var reportsDto = mapper.Map<List<Report>, List<ReportDto>>(listReports);
            return reportsDto;
        }
    }
}
