using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
  public class ArticleMap:IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifeidByName).IsRequired();
            builder.Property(a => a.ModifeidByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a=>a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 9.0  ve .Net 5.0 Yenilikler",
                    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, ",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C# 9.0  ve .Net 5.0 Yenilikler",
                    SeoTags = "C#, C# 9, :net5, :NET  Framework, .Net Core",
                    SeoAuthor = "Bunyad Ahmadli",
                    Date = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitailCreate",
                    CreatedDate = DateTime.Now,
                    ModifeidByName = "InitailCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JC# 9.0  ve .Net 5.0 Yenilikler",
                    UserId = 1,
                    ViewsCount = 100,
                    CommentCount = 1

                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "C++ 11  ve 19 Yenilikler",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. ",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C++ 11  ve 19 Yenilikler",
                    SeoTags = "C++ 11  ve 19 Yenilikler",
                    SeoAuthor = "Bunyad Ahmadli",
                    Date = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitailCreate",
                    CreatedDate = DateTime.Now,
                    ModifeidByName = "InitailCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C++ 11  ve 19 Yenilikler",
                    UserId = 1,
                    ViewsCount = 130,
                    CommentCount = 1

                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "JS ES2019 ve JS ES2020",
                    Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak .nden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş m",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "JS ES2019 ve JS ES2020",
                    SeoTags = "JS ES2019 ve JS ES2020",
                    SeoAuthor = "Bunyad Ahmadli",
                    Date = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitailCreate",
                    CreatedDate = DateTime.Now,
                    ModifeidByName = "InitailCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JS ES2019 ve JS ES2020",
                    UserId = 1,
                    ViewsCount = 500,
                    CommentCount = 1

                }
                );
        }
    }
}
