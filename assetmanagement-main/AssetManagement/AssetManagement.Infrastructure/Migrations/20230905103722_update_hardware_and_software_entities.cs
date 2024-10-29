using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update_hardware_and_software_entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HardwareDevices_Customers_CustomerId",
                table: "HardwareDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_HardwareDevices_Employees_EmployeeId",
                table: "HardwareDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareLicenses_Employees_EmployeeId",
                table: "SoftwareLicenses");

            migrationBuilder.DropIndex(
                name: "IX_SoftwareLicenses_EmployeeId",
                table: "SoftwareLicenses");

            migrationBuilder.DropIndex(
                name: "IX_HardwareDevices_CustomerId",
                table: "HardwareDevices");

            migrationBuilder.DropIndex(
                name: "IX_HardwareDevices_EmployeeId",
                table: "HardwareDevices");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "SoftwareLicenses");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "HardwareDevices");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "HardwareDevices");

            migrationBuilder.CreateTable(
                name: "UserHardwareDeviceEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HardwareDeviceTypeId = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsDelegated = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHardwareDeviceEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHardwareDeviceEntity_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHardwareDeviceEntity_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHardwareDeviceEntity_HardwareDevicesTypes_HardwareDeviceTypeId",
                        column: x => x.HardwareDeviceTypeId,
                        principalTable: "HardwareDevicesTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSoftwareLicenseEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    SerialKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSoftwareLicenseEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSoftwareLicenseEntity_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSoftwareLicenseEntity_Softwares_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Softwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserHardwareDeviceEntity_CustomerId",
                table: "UserHardwareDeviceEntity",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHardwareDeviceEntity_EmployeeId",
                table: "UserHardwareDeviceEntity",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHardwareDeviceEntity_HardwareDeviceTypeId",
                table: "UserHardwareDeviceEntity",
                column: "HardwareDeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSoftwareLicenseEntity_EmployeeId",
                table: "UserSoftwareLicenseEntity",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSoftwareLicenseEntity_SoftwareId",
                table: "UserSoftwareLicenseEntity",
                column: "SoftwareId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHardwareDeviceEntity");

            migrationBuilder.DropTable(
                name: "UserSoftwareLicenseEntity");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "SoftwareLicenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "HardwareDevices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "HardwareDevices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareLicenses_EmployeeId",
                table: "SoftwareLicenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareDevices_CustomerId",
                table: "HardwareDevices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareDevices_EmployeeId",
                table: "HardwareDevices",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_HardwareDevices_Customers_CustomerId",
                table: "HardwareDevices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HardwareDevices_Employees_EmployeeId",
                table: "HardwareDevices",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SoftwareLicenses_Employees_EmployeeId",
                table: "SoftwareLicenses",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}