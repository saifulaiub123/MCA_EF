using AutoMapper;
using MCA_EF_API.Domain.DbContext;
using MCA_EF_API.Domain.ViewModel;
using MCA_EF_API.Interface.IService;
using Microsoft.EntityFrameworkCore;

namespace MCA_EF_API.Service
{
    public class FormService : IFormService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FormService(ApplicationDbContext context, 
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<FormViewModel>> GetAll()
        {
            var forms = await _context.Form.ToListAsync();
            var mappedResult = _mapper.Map<List<FormViewModel>>(forms);
            return mappedResult;
        }
    }
}
