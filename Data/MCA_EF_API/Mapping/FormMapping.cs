using AutoMapper;
using MCA_EF_API.Domain.Entities;
using MCA_EF_API.Domain.ViewModel;

namespace MCA_EF_API.Mapping
{
    public class FormMapping : Profile
    {
        public FormMapping()
        {
            CreateMap<Form, FormViewModel>();
        }
    }
}
