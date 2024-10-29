using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update_hardware_and_software_entities_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserHardwareDeviceEntity_Customers_CustomerId",
                table: "UserHardwareDeviceEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHardwareDeviceEntity_Employees_EmployeeId",
                table: "UserHardwareDeviceEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHardwareDeviceEntity_HardwareDevicesTypes_HardwareDeviceTypeId",
                table: "UserHardwareDeviceEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSoftwareLicenseEntity_Employees_EmployeeId",
                table: "UserSoftwareLicenseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSoftwareLicenseEntity_Softwares_SoftwareId",
                table: "UserSoftwareLicenseEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSoftwareLicenseEntity",
                table: "UserSoftwareLicenseEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHardwareDeviceEntity",
                table: "UserHardwareDeviceEntity");

            migrationBuilder.RenameTable(
                name: "UserSoftwareLicenseEntity",
                newName: "UserSoftwareLicenses");

            migrationBuilder.RenameTable(
                name: "UserHardwareDeviceEntity",
                newName: "UserHardwareDevices");

            migrationBuilder.RenameIndex(
                name: "IX_UserSoftwareLicenseEntity_SoftwareId",
                table: "UserSoftwareLicenses",
                newName: "IX_UserSoftwareLicenses_SoftwareId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSoftwareLicenseEntity_EmployeeId",
                table: "UserSoftwareLicenses",
                newName: "IX_UserSoftwareLicenses_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserHardwareDeviceEntity_HardwareDeviceTypeId",
                table: "UserHardwareDevices",
                newName: "IX_UserHardwareDevices_HardwareDeviceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserHardwareDeviceEntity_EmployeeId",
                table: "UserHardwareDevices",
                newName: "IX_UserHardwareDevices_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserHardwareDeviceEntity_CustomerId",
                table: "UserHardwareDevices",
                newName: "IX_UserHardwareDevices_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSoftwareLicenses",
                table: "UserSoftwareLicenses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHardwareDevices",
                table: "UserHardwareDevices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserHardwareDevices_Customers_CustomerId",
                table: "UserHardwareDevices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHardwareDevices_Employees_EmployeeId",
                table: "UserHardwareDevices",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHardwareDevices_HardwareDevicesTypes_HardwareDeviceTypeId",
                table: "UserHardwareDevices",
                column: "HardwareDeviceTypeId",
                principalTable: "HardwareDevicesTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSoftwareLicenses_Employees_EmployeeId",
                table: "UserSoftwareLicenses",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSoftwareLicenses_Softwares_SoftwareId",
                table: "UserSoftwareLicenses",
                column: "SoftwareId",
                principalTable: "Softwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserHardwareDevices_Customers_CustomerId",
                table: "UserHardwareDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHardwareDevices_Employees_EmployeeId",
                table: "UserHardwareDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHardwareDevices_HardwareDevicesTypes_HardwareDeviceTypeId",
                table: "UserHardwareDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSoftwareLicenses_Employees_EmployeeId",
                table: "UserSoftwareLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSoftwareLicenses_Softwares_SoftwareId",
                table: "UserSoftwareLicenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSoftwareLicenses",
                table: "UserSoftwareLicenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHardwareDevices",
                table: "UserHardwareDevices");

            migrationBuilder.RenameTable(
                name: "UserSoftwareLicenses",
                newName: "UserSoftwareLicenseEntity");

            migrationBuilder.RenameTable(
                name: "UserHardwareDevices",
                newName: "UserHardwareDeviceEntity");

            migrationBuilder.RenameIndex(
                name: "IX_UserSoftwareLicenses_SoftwareId",
                table: "UserSoftwareLicenseEntity",
                newName: "IX_UserSoftwareLicenseEntity_SoftwareId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSoftwareLicenses_EmployeeId",
                table: "UserSoftwareLicenseEntity",
                newName: "IX_UserSoftwareLicenseEntity_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserHardwareDevices_HardwareDeviceTypeId",
                table: "UserHardwareDeviceEntity",
                newName: "IX_UserHardwareDeviceEntity_HardwareDeviceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserHardwareDevices_EmployeeId",
                table: "UserHardwareDeviceEntity",
                newName: "IX_UserHardwareDeviceEntity_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserHardwareDevices_CustomerId",
                table: "UserHardwareDeviceEntity",
                newName: "IX_UserHardwareDeviceEntity_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSoftwareLicenseEntity",
                table: "UserSoftwareLicenseEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHardwareDeviceEntity",
                table: "UserHardwareDeviceEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserHardwareDeviceEntity_Customers_CustomerId",
                table: "UserHardwareDeviceEntity",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHardwareDeviceEntity_Employees_EmployeeId",
                table: "UserHardwareDeviceEntity",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHardwareDeviceEntity_HardwareDevicesTypes_HardwareDeviceTypeId",
                table: "UserHardwareDeviceEntity",
                column: "HardwareDeviceTypeId",
                principalTable: "HardwareDevicesTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSoftwareLicenseEntity_Employees_EmployeeId",
                table: "UserSoftwareLicenseEntity",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSoftwareLicenseEntity_Softwares_SoftwareId",
                table: "UserSoftwareLicenseEntity",
                column: "SoftwareId",
                principalTable: "Softwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}