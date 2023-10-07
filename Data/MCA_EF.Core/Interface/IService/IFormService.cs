using MCA_EF.Core.ViewModel;

namespace MCA_EF.Core.Interface.IService
{
    public interface IFormService
    {
        Task<List<FormViewModel>> GetAll();
    }
}
