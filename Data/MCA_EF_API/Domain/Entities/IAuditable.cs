
namespace MCA_EF_API.Domain.Entities
{
    
    public interface IAuditable
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
    
}
