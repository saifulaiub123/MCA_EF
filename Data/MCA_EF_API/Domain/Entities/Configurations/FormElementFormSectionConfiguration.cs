﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MCA_EF_API.Domain.Entities.Configurations
{
    public partial class FormElementFormSectionConfiguration : IEntityTypeConfiguration<FormElementFormSection>
    {
        public void Configure(EntityTypeBuilder<FormElementFormSection> entity)
        {
            entity.ToTable("FormElement_FormSection", "DynamicForms");

            entity.HasOne(d => d.FormElement)
                .WithMany(p => p.FormElementFormSection)
                .HasForeignKey(d => d.FormElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_FormSection_FormElement");

            entity.HasOne(d => d.FormSection)
                .WithMany(p => p.FormElementFormSection)
                .HasForeignKey(d => d.FormSectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_FormSection_FormSection");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FormElementFormSection> entity);
    }
}
