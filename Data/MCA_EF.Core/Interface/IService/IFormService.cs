using MCA_EF.Core.Model;

namespace MCA_EF.Core.Interface.IService
{
    public interface IFormService
    {
        Task<List<FormViewModel>> GetAll();
    }
}
