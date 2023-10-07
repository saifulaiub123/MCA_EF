namespace MCA_EF.Core.ViewModel
{
    public class FormViewModel
    {
        public int FormId { get; set; }
        public Guid FormExternalId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
