﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MCA_EF_API.Domain.Entities.Configurations
{
    public partial class FormElementResponseConfiguration : IEntityTypeConfiguration<FormElementResponse>
    {
        public void Configure(EntityTypeBuilder<FormElementResponse> entity)
        {
            entity.ToTable("FormElement_Response", "DynamicForms");

            entity.HasOne(d => d.FormElement)
                .WithMany(p => p.FormElementResponse)
                .HasForeignKey(d => d.FormElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_Response_FormElement");

            entity.HasOne(d => d.FormResponse)
                .WithMany(p => p.FormElementResponse)
                .HasForeignKey(d => d.FormResponseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_Response_Form_Response");

            entity.HasOne(d => d.FormSection)
                .WithMany(p => p.FormElementResponse)
                .HasForeignKey(d => d.FormSectionId)
                .HasConstraintName("FK_FormElement_Response_FormSection");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FormElementResponse> entity);
    }
}
