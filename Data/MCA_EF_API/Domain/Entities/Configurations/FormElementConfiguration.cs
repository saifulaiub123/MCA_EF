﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MCA_EF_API.Domain.Entities.Configurations
{
    public partial class FormElementConfiguration : IEntityTypeConfiguration<FormElement>
    {
        public void Configure(EntityTypeBuilder<FormElement> entity)
        {
            entity.ToTable("FormElement", "DynamicForms");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HoverText)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Placeholder)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PrependText)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.TypeFormElement)
                .WithMany(p => p.FormElement)
                .HasForeignKey(d => d.TypeFormElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_TypeFormElement");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FormElement> entity);
    }
}
