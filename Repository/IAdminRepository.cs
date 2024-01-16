using Business.ViewModels;

namespace Repository
{
    public interface IAdminRepository
    {
        public AdminModel GetAdminViewModel();
    }
}