using Business.ViewModels;
using DataAccessObject;

namespace Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AdminDAO _adminDAO;

        public AdminRepository()
        {
            _adminDAO = new AdminDAO();
        }
        public Admin GetAdminViewModel()
        {
            return _adminDAO.GetDataFromFile();
        }
    }
}