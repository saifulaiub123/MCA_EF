﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
namespace MCA_EF.Data.Entities
{
    public partial class FormElementFormSection
    {
        public int FormElementFormSectionId { get; set; }
        public int FormElementId { get; set; }
        public int FormSectionId { get; set; }

        public virtual FormElement FormElement { get; set; }
        public virtual FormSection FormSection { get; set; }
    }
}