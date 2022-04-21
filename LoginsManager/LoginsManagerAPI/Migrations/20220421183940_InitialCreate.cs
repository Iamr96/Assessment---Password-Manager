using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginsManagerAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Privilege",
                columns: table => new
                {
                    PrivilegeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivilegeName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    PrivilegeFriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilege", x => x.PrivilegeID);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    ProfileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ProfileID);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePrivilege",
                columns: table => new
                {
                    ProfilePrivilegeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    PrivilegeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePrivilege", x => x.ProfilePrivilegeID);
                    table.ForeignKey(
                        name: "FK_Privilege_Privilege",
                        column: x => x.PrivilegeID,
                        principalTable: "Privilege",
                        principalColumn: "PrivilegeID");
                    table.ForeignKey(
                        name: "FK_Profile_Privilege",
                        column: x => x.ProfileID,
                        principalTable: "Profile",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Mobile = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    ForceLogin = table.Column<bool>(type: "bit", nullable: true),
                    EmailVeryFied = table.Column<bool>(type: "bit", nullable: true),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_PROFILE",
                        column: x => x.ProfileID,
                        principalTable: "Profile",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePrivilege_PrivilegeID",
                table: "ProfilePrivilege",
                column: "PrivilegeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePrivilege_ProfileID",
                table: "ProfilePrivilege",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfileID",
                table: "Users",
                column: "ProfileID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfilePrivilege");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Privilege");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
