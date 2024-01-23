using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookingDetailRepository : IBookingDetailRepository
    {
        private readonly BaseDAO<BookingDetail> _baseDao;

        public BookingDetailRepository()
        {
            _baseDao = new BaseDAO<BookingDetail>();
        }
        bool IBaseRepository<BookingDetail>.Create(BookingDetail entity)
        {
            return _baseDao.Create(entity);
        }

        bool IBaseRepository<BookingDetail>.Delete(BookingDetail entity)
        {
            return _baseDao.Delete(entity);
        }

        BookingDetail IBaseRepository<BookingDetail>.GetById(int entityId)
        {
            return _baseDao.GetById(entityId);
        }

        List<BookingDetail> IBaseRepository<BookingDetail>.GetAll()
        {
            return _baseDao.GetAll();
        }

        bool IBaseRepository<BookingDetail>.Update(BookingDetail entity)
        {
            return _baseDao.Update(entity);
        }

        public List<BookingDetail> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var result = _baseDao.GetAll().Where(b =>
                    b.StartDate >= startDate && b.EndDate <= endDate
                ).ToList();
                
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
