using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class InitailCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifeidByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifeidByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifeidByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifeidByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifeidByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7246), "C# programlama dili ile ilgili en güncel bilgiler", true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7264), "C#", "C# blog categorisi" },
                    { 2, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7327), "C++ programlama dili ile ilgili en güncel bilgiler", true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7329), "C++", "C++ blog categorisi" },
                    { 3, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7333), "JS programlama dili ile ilgili en güncel bilgiler", true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 38, DateTimeKind.Local).AddTicks(7334), "JS", "JS blog categorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "InitialCreat", new DateTime(2020, 9, 2, 21, 1, 20, 42, DateTimeKind.Local).AddTicks(5515), "Admin Rolü, Tüm haklara sahiptir.", true, false, "InitialCreate", new DateTime(2020, 9, 2, 21, 1, 20, 42, DateTimeKind.Local).AddTicks(5522), "Admin", "Admin Rolüdür." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifeidByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "Username" },
                values: new object[] { 1, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 48, DateTimeKind.Local).AddTicks(7008), "İlk Admin Kullanıcısı", "Alper@at.eb", "Alper", true, false, "Tunga", "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 48, DateTimeKind.Local).AddTicks(7015), "Admin Kullanıcısı", new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 }, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.sordum.ne", 1, "alpertunda" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[] { 1, 1, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, ", "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 35, DateTimeKind.Local).AddTicks(7564), new DateTime(2020, 9, 2, 21, 1, 20, 35, DateTimeKind.Local).AddTicks(6101), true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 35, DateTimeKind.Local).AddTicks(8305), "JC# 9.0  ve .Net 5.0 Yenilikler", "Bunyad Ahmadli", "C# 9.0  ve .Net 5.0 Yenilikler", "C#, C# 9, :net5, :NET  Framework, .Net Core", "Default.jpg", "C# 9.0  ve .Net 5.0 Yenilikler", 1, 100 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[] { 2, 2, 1, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. ", "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(174), new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(167), true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(176), "C++ 11  ve 19 Yenilikler", "Bunyad Ahmadli", "C++ 11  ve 19 Yenilikler", "C++ 11  ve 19 Yenilikler", "Default.jpg", "C++ 11  ve 19 Yenilikler", 1, 130 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[] { 3, 3, 1, "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak .nden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş m", "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(204), new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(203), true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 36, DateTimeKind.Local).AddTicks(205), "JS ES2019 ve JS ES2020", "Bunyad Ahmadli", "JS ES2019 ve JS ES2020", "JS ES2019 ve JS ES2020", "Default.jpg", "JS ES2019 ve JS ES2020", 1, 500 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 1, 1, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8238), true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8245), "C# makkaklle yorumu ", "Lorem ipsum dolor sit amet,consectetur adipiscing elit,sed do eiusmod tempor incididunt u" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 2, 2, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8277), true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8278), "C++ makkaklle yorumu ", "Lorem ipsum dolor sit amet,consectetur adipiscinct laborum." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifeidByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 3, 3, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8282), true, false, "InitailCreate", new DateTime(2020, 9, 2, 21, 1, 20, 40, DateTimeKind.Local).AddTicks(8283), "JS makkaklle yorumu ", "Lorem ipsum dolor sit amet,consectetur adipiscing elit,sed do eiusmodin reculpa qui officia deserunt mollit anim id est laborum." });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
