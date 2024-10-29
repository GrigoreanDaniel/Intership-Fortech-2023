using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update_hardware_and_software_entities_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareLicenses_Softwares_SoftwareId",
                table: "SoftwareLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHardwareDevices_HardwareDevicesTypes_HardwareDeviceTypeId",
                table: "UserHardwareDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSoftwareLicenses_Softwares_SoftwareId",
                table: "UserSoftwareLicenses");

            migrationBuilder.DropIndex(
                name: "IX_UserSoftwareLicenses_SoftwareId",
                table: "UserSoftwareLicenses");

            migrationBuilder.DropIndex(
                name: "IX_UserHardwareDevices_HardwareDeviceTypeId",
                table: "UserHardwareDevices");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserSoftwareLicenses");

            migrationBuilder.DropColumn(
                name: "SerialKey",
                table: "UserSoftwareLicenses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserHardwareDevices");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "UserHardwareDevices");

            migrationBuilder.DropColumn(
                name: "IsDelegated",
                table: "HardwareDevices");

            migrationBuilder.RenameColumn(
                name: "SoftwareId",
                table: "UserSoftwareLicenses",
                newName: "SoftwareLicenseId");

            migrationBuilder.RenameColumn(
                name: "HardwareDeviceTypeId",
                table: "UserHardwareDevices",
                newName: "HardwareDeviceId");

            migrationBuilder.RenameColumn(
                name: "SoftwareId",
                table: "SoftwareLicenses",
                newName: "SoftwareTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SoftwareLicenses_SoftwareId",
                table: "SoftwareLicenses",
                newName: "IX_SoftwareLicenses_SoftwareTypeId");

            migrationBuilder.RenameColumn(
                name: "IsInternal",
                table: "HardwareDevices",
                newName: "IsUsed");

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "SoftwareLicenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_SoftwareLicenses_Softwares_SoftwareTypeId",
                table: "SoftwareLicenses",
                column: "SoftwareTypeId",
                principalTable: "Softwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareLicenses_Softwares_SoftwareTypeId",
                table: "SoftwareLicenses");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "SoftwareLicenses");

            migrationBuilder.RenameColumn(
                name: "SoftwareLicenseId",
                table: "UserSoftwareLicenses",
                newName: "SoftwareId");

            migrationBuilder.RenameColumn(
                name: "HardwareDeviceId",
                table: "UserHardwareDevices",
                newName: "HardwareDeviceTypeId");

            migrationBuilder.RenameColumn(
                name: "SoftwareTypeId",
                table: "SoftwareLicenses",
                newName: "SoftwareId");

            migrationBuilder.RenameIndex(
                name: "IX_SoftwareLicenses_SoftwareTypeId",
                table: "SoftwareLicenses",
                newName: "IX_SoftwareLicenses_SoftwareId");

            migrationBuilder.RenameColumn(
                name: "IsUsed",
                table: "HardwareDevices",
                newName: "IsInternal");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserSoftwareLicenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SerialKey",
                table: "UserSoftwareLicenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserHardwareDevices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "UserHardwareDevices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelegated",
                table: "HardwareDevices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_UserSoftwareLicenses_SoftwareId",
                table: "UserSoftwareLicenses",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHardwareDevices_HardwareDeviceTypeId",
                table: "UserHardwareDevices",
                column: "HardwareDeviceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftwareLicenses_Softwares_SoftwareId",
                table: "SoftwareLicenses",
                column: "SoftwareId",
                principalTable: "Softwares",
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
                name: "FK_UserSoftwareLicenses_Softwares_SoftwareId",
                table: "UserSoftwareLicenses",
                column: "SoftwareId",
                principalTable: "Softwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}