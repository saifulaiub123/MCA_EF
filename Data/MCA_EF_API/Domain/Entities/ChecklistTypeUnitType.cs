﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
namespace MCA_EF_API.Domain.Entities
{
    public partial class ChecklistTypeUnitType
    {
        public int ChecklistTypeUnitTypeId { get; set; }
        public int ChecklistTypeId { get; set; }
        public int UnitTypeId { get; set; }

        public virtual ChecklistType ChecklistType { get; set; }
    }
}