using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly BaseDAO<RoomType> _baseDao;

        public RoomTypeRepository()
        {
            _baseDao = new BaseDAO<RoomType>();
        }
        bool IBaseRepository<RoomType>.Create(RoomType entity)

        {
            return _baseDao.Create(entity); 
        }

        bool IBaseRepository<RoomType>.Delete(RoomType entity)
        {
            return _baseDao.Delete(entity);
        }

        List<RoomType> IBaseRepository<RoomType>.GetAll()
        {
            return _baseDao.GetAll();
        }

        RoomType IBaseRepository<RoomType>.GetById(int entityId)
        {
            return _baseDao.GetById(entityId);
        }

        bool IBaseRepository<RoomType>.Update(RoomType entity)
        {
            return _baseDao.Update(entity);
        }
    }
}
