using Entities.Entities;
using Entities.Exceptions;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private List<T> _repo;

        public GenericRepository()
        {
            _repo = new List<T>();
        }
        public void AddAsync(T data)
        {
            _repo.Add(data);
        }

        public void ClearAllAsync()
        {
            _repo.Clear();
        }

        public Task<List<T>>GetAllAsync()
        {
            if(_repo.Count == 0)
            {
                throw new RepositoryException("La lista de reportes se encuentra vacía!!");
            }
            var getList = Task.Run(() =>
            {
                return _repo;
            });
            return getList;
        }
    }
}
