using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(70);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifeidByName).IsRequired();
            builder.Property(c => c.ModifeidByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Categories");
            builder.HasData(
                new Category
            {
                Id = 1,
                Name = "C#",
                Description = "C# programlama dili ile ilgili en güncel bilgiler",
                IsDeleted = false,
                IsActive = true,
                CreatedByName = "InitailCreate",
                CreatedDate = DateTime.Now,
                ModifeidByName = "InitailCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# blog categorisi",
            }, new Category
            {
                Id = 2,
                Name = "C++",
                Description = "C++ programlama dili ile ilgili en güncel bilgiler",
                IsDeleted = false,
                IsActive = true,
                CreatedByName = "InitailCreate",
                CreatedDate = DateTime.Now,
                ModifeidByName = "InitailCreate",
                ModifiedDate = DateTime.Now,
                Note = "C++ blog categorisi",
            },new Category
            {
                Id = 3,
                Name = "JS",
                Description = "JS programlama dili ile ilgili en güncel bilgiler",
                IsDeleted = false,
                IsActive = true,
                CreatedByName = "InitailCreate",
                CreatedDate = DateTime.Now,
                ModifeidByName = "InitailCreate",
                ModifiedDate = DateTime.Now,
                Note = "JS blog categorisi",
            }
                );
        }
    }
}