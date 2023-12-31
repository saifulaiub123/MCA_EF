﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MCA_EF.Data.Entities.Configurations
{
    public partial class FormSectionConfiguration : IEntityTypeConfiguration<FormSection>
    {
        public void Configure(EntityTypeBuilder<FormSection> entity)
        {
            entity.ToTable("FormSection", "DynamicForms");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LabelColorClass)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation)
                .WithMany(p => p.FormSection)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormSection_Person");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.FormSection)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormSection_Form");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FormSection> entity);
    }
}
