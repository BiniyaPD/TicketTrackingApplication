using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketTracking.EFLayer.Migrations
{
    public partial class ticketTracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employeeid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Epassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employeeid);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoggedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaisedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ticketdescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResolvedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResolvedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TicketStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoggedByEmployeeEmployeeid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ResolvedByEmployeeEmployeeid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Employees_LoggedByEmployeeEmployeeid",
                        column: x => x.LoggedByEmployeeEmployeeid,
                        principalTable: "Employees",
                        principalColumn: "Employeeid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Employees_ResolvedByEmployeeEmployeeid",
                        column: x => x.ResolvedByEmployeeEmployeeid,
                        principalTable: "Employees",
                        principalColumn: "Employeeid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_LoggedByEmployeeEmployeeid",
                table: "Tickets",
                column: "LoggedByEmployeeEmployeeid");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ResolvedByEmployeeEmployeeid",
                table: "Tickets",
                column: "ResolvedByEmployeeEmployeeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
