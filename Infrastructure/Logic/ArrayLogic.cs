using System;
using System.Collections.Generic;
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
        private IGenericRepository<Report> _repo;
        private IReportFactory _reportFactory;

        public ArrayLogic()
        {
            _repo = new GenericRepository<Report>();
            _reportFactory = new ReportFactory();
        }

        public async Task<int[]> GenerateArrayAndFillRandomNumbers(int numberElements)
        {
            array = new int[numberElements];
            return await this.array.GenerateAndFillArrayWithRandomNumbers();            
        }

        public async Task<int[]> SortArrayBasedOnMethod(string method)
        {
            var init = DateTime.Now.Millisecond;
            switch (method)
            {
                case "Burbuja":
                    await array.BurbleSort();
                    break;
            }
            var end = DateTime.Now.Millisecond;
            long timeElapsed = end - init;
            AddReport(method, timeElapsed);
            array = null;
            return array;
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
