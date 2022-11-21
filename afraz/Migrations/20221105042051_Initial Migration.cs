using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace afraz.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Mobile = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManagers",
                columns: table => new
                {
                    PMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Mobile = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Pincode = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectM__5C86FF4611FBA1B0", x => x.PMId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false),
                    CusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    ProManid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Projects__C5775540F8A8BEE7", x => x.PId);
                    table.ForeignKey(
                        name: "FK__Projects__CusId__3D5E1FD2",
                        column: x => x.CusId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Projects__ProMan__3E52440B",
                        column: x => x.ProManid,
                        principalTable: "ProjectManagers",
                        principalColumn: "PMId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CusId",
                table: "Projects",
                column: "CusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProManid",
                table: "Projects",
                column: "ProManid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProjectManagers");
        }
    }
}
