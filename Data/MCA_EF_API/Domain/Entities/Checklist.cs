﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
namespace MCA_EF_API.Domain.Entities
{
    public partial class Checklist : IAuditable
    {
        public int ChecklistId { get; set; }
        public Guid FormResponseExternalId { get; set; }
        public int ChecklistTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}