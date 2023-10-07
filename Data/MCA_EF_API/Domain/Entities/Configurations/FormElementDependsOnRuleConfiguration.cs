﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MCA_EF_API.Domain.Entities.Configurations
{
    public partial class FormElementDependsOnRuleConfiguration : IEntityTypeConfiguration<FormElementDependsOnRule>
    {
        public void Configure(EntityTypeBuilder<FormElementDependsOnRule> entity)
        {
            entity.ToTable("FormElement_DependsOnRule", "DynamicForms");

            entity.HasOne(d => d.Operator)
                .WithMany(p => p.FormElementDependsOnRule)
                .HasForeignKey(d => d.OperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_DependsOnRule_Operator");

            entity.HasOne(d => d.Option)
                .WithMany(p => p.FormElementDependsOnRule)
                .HasForeignKey(d => d.OptionId)
                .HasConstraintName("FK_FormElement_DependsOnRule_FormElement_Option");

            entity.HasOne(d => d.SubjectFormElement)
                .WithMany(p => p.FormElementDependsOnRule)
                .HasForeignKey(d => d.SubjectFormElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormElement_DependsOnRule_FormElement");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FormElementDependsOnRule> entity);
    }
}
