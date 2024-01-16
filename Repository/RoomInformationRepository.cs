using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoomInformationRepository : IRoomInformationRepository
    {
        private readonly BaseDAO<RoomInformation> _baseDao;

        public RoomInformationRepository()
        {
            _baseDao = new BaseDAO<RoomInformation>();
        }
        bool IBaseRepository<RoomInformation>.Create(RoomInformation entity)
        {
            return _baseDao.Create(entity);
        }

        bool IBaseRepository<RoomInformation>.Delete(RoomInformation entity)
        {
            return _baseDao.Delete(entity);
        }

        List<RoomInformation> IBaseRepository<RoomInformation>.GetAll()
        {
            return _baseDao.GetAll();
        }

        RoomInformation IBaseRepository<RoomInformation>.GetById(int entityId)
        {
            return _baseDao.GetById(entityId);
        }

        bool IBaseRepository<RoomInformation>.Update(RoomInformation entity)
        {
            return _baseDao.Update(entity);
        }
    }
}
