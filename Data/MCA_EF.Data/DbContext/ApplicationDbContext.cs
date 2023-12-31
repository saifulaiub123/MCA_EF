﻿
#nullable disable

using MCA_EF.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCA_EF.Data.DbContext
{
    public partial class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Checklist> Checklist { get; set; }
        public virtual DbSet<ChecklistArea> ChecklistArea { get; set; }
        public virtual DbSet<ChecklistFrequency> ChecklistFrequency { get; set; }
        public virtual DbSet<ChecklistType> ChecklistType { get; set; }
        public virtual DbSet<ChecklistTypeUnitType> ChecklistTypeUnitType { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<FormElement> FormElement { get; set; }
        public virtual DbSet<FormElementDependsOnRule> FormElementDependsOnRule { get; set; }
        public virtual DbSet<FormElementFormSection> FormElementFormSection { get; set; }
        public virtual DbSet<FormElementOption> FormElementOption { get; set; }
        public virtual DbSet<FormElementResponse> FormElementResponse { get; set; }
        public virtual DbSet<FormElementTypeAsset> FormElementTypeAsset { get; set; }
        public virtual DbSet<FormElementValidator> FormElementValidator { get; set; }
        public virtual DbSet<FormResponse> FormResponse { get; set; }
        public virtual DbSet<FormSection> FormSection { get; set; }
        public virtual DbSet<NestedFormSection> NestedFormSection { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<ResponseValue> ResponseValue { get; set; }
        public virtual DbSet<TypeFormElement> TypeFormElement { get; set; }
        public virtual DbSet<TypeValidator> TypeValidator { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new Configurations.ChecklistConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.ChecklistAreaConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.ChecklistFrequencyConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.ChecklistTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.ChecklistTypeUnitTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormElementConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormElementDependsOnRuleConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormElementFormSectionConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormElementOptionConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormElementResponseConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormElementTypeAssetConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormElementValidatorConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormResponseConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.FormSectionConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.NestedFormSectionConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.OperatorConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.PersonConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.ResponseValueConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.TypeFormElementConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.TypeValidatorConfiguration());

            //OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var item in ChangeTracker.Entries<IAuditable>())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.UtcNow;
                        item.Entity.CreatedBy = item.Entity.CreatedBy != 0 ? item.Entity.CreatedBy : 0;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
