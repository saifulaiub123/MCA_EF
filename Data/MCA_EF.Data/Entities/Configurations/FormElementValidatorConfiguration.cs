﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MCA_EF.Data.Entities.Configurations
{
    public partial class FormElementValidatorConfiguration : IEntityTypeConfiguration<FormElementValidator>
    {
        public void Configure(EntityTypeBuilder<FormElementValidator> entity)
        {
            entity.ToTable("FormElement_Validator", "DynamicForms");

            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.FormElement)
                .WithMany(p => p.FormElementValidator)
                .HasForeignKey(d => d.FormElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_Validator_FormElement_Validator");

            entity.HasOne(d => d.Operator)
                .WithMany(p => p.FormElementValidator)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_FormElement_Validator_Operator");

            entity.HasOne(d => d.TypeValidator)
                .WithMany(p => p.FormElementValidator)
                .HasForeignKey(d => d.TypeValidatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_Validator_TypeValidator");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FormElementValidator> entity);
    }
}