using AutoMapper;
using MCA_EF.Core.Interface.IService;
using MCA_EF.Core.ViewModel;
using MCA_EF.Data.DbContext;
using Microsoft.EntityFrameworkCore;

namespace MCA_EF.Core.Service
{
    public class FormService : IFormService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FormService(
            ApplicationDbContext context, 
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
