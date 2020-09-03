﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;

namespace ProgrammersBlog.Data.Migrations
{
    [DbContext(typeof(ProgrammersBlogContext))]
    [Migration("20200902180120_InitailCreate")]
    partial class InitailCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.8.20407.4");

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifeidByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, ",
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 35, DateTimeKind.Local).AddTicks(7564),
                            Date = new DateTime(2020, 9, 2, 21, 1, 20, 35, DateTimeKind.Local).AddTicks(6101),
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 35, DateTimeKind.Local).AddTicks(8305),
                            Note = "JC# 9.0  ve .Net 5.0 Yenilikler",
                            SeoAuthor = "Bunyad Ahmadli",
                            SeoDescription = "C# 9.0  ve .Net 5.0 Yenilikler",
                            SeoTags = "C#, C# 9, :net5, :NET  Framework, .Net Core",
                            Thumbnail = "Default.jpg",
                            Title = "C# 9.0  ve .Net 5.0 Yenilikler",
                            UserId = 1,
                            ViewsCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. ",
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(174),
                            Date = new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(167),
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(176),
                            Note = "C++ 11  ve 19 Yenilikler",
                            SeoAuthor = "Bunyad Ahmadli",
                            SeoDescription = "C++ 11  ve 19 Yenilikler",
                            SeoTags = "C++ 11  ve 19 Yenilikler",
                            Thumbnail = "Default.jpg",
                            Title = "C++ 11  ve 19 Yenilikler",
                            UserId = 1,
                            ViewsCount = 130
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak .nden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş m",
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(204),
                            Date = new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(203),
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(205),
                            Note = "JS ES2019 ve JS ES2020",
                            SeoAuthor = "Bunyad Ahmadli",
                            SeoDescription = "JS ES2019 ve JS ES2020",
                            SeoTags = "JS ES2019 ve JS ES2020",
                            Thumbnail = "Default.jpg",
                            Title = "JS ES2019 ve JS ES2020",
                            UserId = 1,
                            ViewsCount = 500
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifeidByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7246),
                            Description = "C# programlama dili ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7264),
                            Name = "C#",
                            Note = "C# blog categorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7327),
                            Description = "C++ programlama dili ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7329),
                            Name = "C++",
                            Note = "C++ blog categorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7333),
                            Description = "JS programlama dili ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7334),
                            Name = "JS",
                            Note = "JS blog categorisi"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifeidByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8238),
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8245),
                            Note = "C# makkaklle yorumu ",
                            Text = "Lorem ipsum dolor sit amet,consectetur adipiscing elit,sed do eiusmod tempor incididunt u"
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8277),
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8278),
                            Note = "C++ makkaklle yorumu ",
                            Text = "Lorem ipsum dolor sit amet,consectetur adipiscinct laborum."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8282),
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8283),
                            Note = "JS makkaklle yorumu ",
                            Text = "Lorem ipsum dolor sit amet,consectetur adipiscing elit,sed do eiusmodin reculpa qui officia deserunt mollit anim id est laborum."
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifeidByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreat",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 42, DateTimeKind.Local).AddTicks(5515),
                            Description = "Admin Rolü, Tüm haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifeidByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 42, DateTimeKind.Local).AddTicks(5522),
                            Name = "Admin",
                            Note = "Admin Rolüdür."
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifeidByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitailCreate",
                            CreatedDate = new DateTime(2020, 9, 2, 21, 1, 20, 48, DateTimeKind.Local).AddTicks(7008),
                            Description = "İlk Admin Kullanıcısı",
                            Email = "Alper@at.eb",
                            FirstName = "Alper",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Tunga",
                            ModifeidByName = "InitailCreate",
                            ModifiedDate = new DateTime(2020, 9, 2, 21, 1, 20, 48, DateTimeKind.Local).AddTicks(7015),
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.sordum.ne",
                            RoleId = 1,
                            Username = "alpertunda"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgrammersBlog.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}