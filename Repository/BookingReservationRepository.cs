using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        private readonly BaseDAO<BookingReservation> _baseDao;

        public BookingReservationRepository()
        {
            _baseDao = new BaseDAO<BookingReservation>();
        }
        bool IBaseRepository<BookingReservation>.Create(BookingReservation entity)
        {
            return _baseDao.Create(entity);
        }

        bool IBaseRepository<BookingReservation>.Delete(BookingReservation entity)
        {
            return _baseDao.Delete(entity);
        }

        List<BookingReservation> IBaseRepository<BookingReservation>.GetAll()
        {
            return _baseDao.GetAll();
        }

        BookingReservation IBaseRepository<BookingReservation>.GetById(int entityId)
        {
            return _baseDao.GetById(entityId);
        }

        bool IBaseRepository<BookingReservation>.Update(BookingReservation entity)
        {
            return _baseDao.Update(entity);
        }
    }
}
