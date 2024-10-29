using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_base_entity_properties_to_all_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supervisors_Employees");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Softwares",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateDeleted",
                table: "Softwares",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Softwares",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SerialKey",
                table: "SoftwareLicenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "SoftwareLicenses",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateDeleted",
                table: "SoftwareLicenses",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "SoftwareLicenses",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "HardwareDevicesTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "HardwareDevicesTypes",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateDeleted",
                table: "HardwareDevicesTypes",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "HardwareDevicesTypes",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "HardwareDevices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "HardwareDevices",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateDeleted",
                table: "HardwareDevices",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "HardwareDevices",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Employees",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateDeleted",
                table: "Employees",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Employees",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Customers",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateDeleted",
                table: "Customers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Customers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SupervisorsEmployees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupervisorsEmployees", x => new { x.SupervisorId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_SupervisorsEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupervisorsEmployees_Employees_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorsEmployees_EmployeeId",
                table: "SupervisorsEmployees",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupervisorsEmployees");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Softwares");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Softwares");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Softwares");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "SoftwareLicenses");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "SoftwareLicenses");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "SoftwareLicenses");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "HardwareDevicesTypes");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "HardwareDevicesTypes");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "HardwareDevicesTypes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "HardwareDevices");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "HardwareDevices");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "HardwareDevices");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "SerialKey",
                table: "SoftwareLicenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "HardwareDevicesTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "HardwareDevices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Supervisors_Employees",
                columns: table => new
                {
                    SupervisorId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors_Employees", x => new { x.SupervisorId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_Supervisors_Employees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Supervisors_Employees_Employees_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_Employees_EmployeeId",
                table: "Supervisors_Employees",
                column: "EmployeeId");
        }
    }
}