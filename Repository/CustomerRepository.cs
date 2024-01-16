using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BaseDAO<Customer> _baseDao;

        public CustomerRepository()
        {
            _baseDao = new BaseDAO<Customer>();
        }
        bool IBaseRepository<Customer>.Create(Customer entity)
        {
            return _baseDao.Create(entity);
        }

        bool IBaseRepository<Customer>.Delete(Customer entity)
        {
            return _baseDao.Delete(entity);
        }

        List<Customer> IBaseRepository<Customer>.GetAll()
        {
            return _baseDao.GetAll();
        }

        Customer IBaseRepository<Customer>.GetById(int entityId)
        {
            return _baseDao.GetById(entityId);
        }

        bool IBaseRepository<Customer>.Update(Customer entity)
        {
            return _baseDao.Update(entity);
        }
    }
}
