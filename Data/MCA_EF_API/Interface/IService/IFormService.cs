using MCA_EF_API.Domain.ViewModel;

namespace MCA_EF_API.Interface.IService
{
    public interface IFormService
    {
        Task<List<FormViewModel>> GetAll();
    }
}
