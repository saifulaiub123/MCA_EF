
namespace MCA_EF.Data.Entities
{
    
    public interface IAuditable
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
    
}
