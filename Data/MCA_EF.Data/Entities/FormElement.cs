﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
namespace MCA_EF.Data.Entities
{
    public partial class FormElement : IAuditable
    {
        public FormElement()
        {
            FormElementDependsOnRule = new HashSet<FormElementDependsOnRule>();
            FormElementFormSection = new HashSet<FormElementFormSection>();
            FormElementOption = new HashSet<FormElementOption>();
            FormElementResponse = new HashSet<FormElementResponse>();
            FormElementTypeAsset = new HashSet<FormElementTypeAsset>();
            FormElementValidator = new HashSet<FormElementValidator>();
        }

        public int FormElementId { get; set; }
        public int TypeFormElementId { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Placeholder { get; set; }
        public bool AcceptsMultipleResponses { get; set; }
        public string PrependText { get; set; }
        public string HoverText { get; set; }
        public bool IsRequired { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsActive { get; set; }
        public int DisplayRowIndex { get; set; }
        public int DisplayColumnIndex { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public virtual TypeFormElement TypeFormElement { get; set; }
        public virtual ICollection<FormElementDependsOnRule> FormElementDependsOnRule { get; set; }
        public virtual ICollection<FormElementFormSection> FormElementFormSection { get; set; }
        public virtual ICollection<FormElementOption> FormElementOption { get; set; }
        public virtual ICollection<FormElementResponse> FormElementResponse { get; set; }
        public virtual ICollection<FormElementTypeAsset> FormElementTypeAsset { get; set; }
        public virtual ICollection<FormElementValidator> FormElementValidator { get; set; }
    }
}