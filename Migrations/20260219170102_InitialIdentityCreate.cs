using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SneakerShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentityCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Classic 90s comfort.", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600", "Air Max Retro", 130.00m },
                    { 2, "High performance knit.", "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=600", "Boost Runner", 180.00m },
                    { 3, "Minimalist leather sneaker.", "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=600", "Court Classic", 110.00m },
                    { 4, "Everyday streetwear staple.", "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=600", "Dunk Low Panda", 120.00m },
                    { 5, "Primeknit comfort and style.", "https://images.unsplash.com/photo-1560769629-975ec94e6a86?w=600", "Yeezy 350 V2", 230.00m },
                    { 6, "The one that started it all.", "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600", "Jordan 1 High", 180.00m },
                    { 7, "Retro hoops silhouette.", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600", "NB 550 Vintage", 110.00m },
                    { 8, "Maximum energy return.", "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=600", "Ultraboost 1.0", 190.00m },
                    { 9, "Chunky retro-future design.", "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=600", "RS-X Toys", 115.00m },
                    { 10, "Split tongue classic.", "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=600", "Gel-Lyte III", 130.00m },
                    { 11, "Clean tennis aesthetics.", "https://images.unsplash.com/photo-1560769629-975ec94e6a86?w=600", "Club C 85", 85.00m },
                    { 12, "Upgraded canvas icon.", "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600", "Chuck 70 High", 90.00m },
                    { 13, "Skate ready durability.", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600", "Old Skool Pro", 75.00m },
                    { 14, "Crisp white leather.", "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=600", "Air Force 1 '07", 115.00m },
                    { 15, "Off-road performance.", "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=600", "XT-6 Trail", 200.00m },
                    { 16, "Water ripple inspired.", "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=600", "Air Max 97", 175.00m },
                    { 17, "Indoor soccer legend.", "https://images.unsplash.com/photo-1560769629-975ec94e6a86?w=600", "Samba OG", 100.00m },
                    { 18, "Y2K running style.", "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600", "NB 2002R", 140.00m },
                    { 19, "Vintage hoops design.", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600", "Blazer Mid '77", 105.00m },
                    { 20, "Flight club essential.", "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=600", "Jordan 4 Retro", 210.00m },
                    { 21, "Suede perfection.", "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=600", "Gazelle Indoor", 120.00m },
                    { 22, "B-boy certified.", "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=600", "Suede Classic", 75.00m },
                    { 23, "Ankle support for days.", "https://images.unsplash.com/photo-1560769629-975ec94e6a86?w=600", "Sk8-Hi", 80.00m },
                    { 24, "Tech runner revival.", "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600", "Kayano 14", 150.00m },
                    { 25, "Plush daily trainer.", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600", "Clifton 9", 145.00m },
                    { 26, "Maximum cushioning.", "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=600", "Cloudmonster", 170.00m },
                    { 27, "Breathable mesh overlay.", "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=600", "Vomero 5", 160.00m },
                    { 28, "Elephant print details.", "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=600", "Jordan 3 Retro", 200.00m },
                    { 29, "Strap it down.", "https://images.unsplash.com/photo-1560769629-975ec94e6a86?w=600", "Forum Low", 110.00m },
                    { 30, "Made in USA excellence.", "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600", "NB 990v6", 200.00m },
                    { 31, "Chunky platform style.", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600", "Run Star Hike", 110.00m },
                    { 32, "Timeless everyday wear.", "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=600", "Classic Leather", 85.00m },
                    { 33, "Smooth transition running.", "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=600", "Wave Rider 27", 140.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
