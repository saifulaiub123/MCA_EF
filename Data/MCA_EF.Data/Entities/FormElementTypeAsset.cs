﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
namespace MCA_EF.Data.Entities
{
    public partial class FormElementTypeAsset
    {
        public int FormElementTypeAssetId { get; set; }
        public int FormElementId { get; set; }
        public int UnitTypeId { get; set; }

        public virtual FormElement FormElement { get; set; }
    }
}