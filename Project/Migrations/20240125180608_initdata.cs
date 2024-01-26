using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class initdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    TypeId = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    TypeName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    UserContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    UserMessage = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceTypeId = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "TypeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceTypeId",
                table: "Appointments",
                column: "ServiceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ServiceTypes");
        }
    }
}
