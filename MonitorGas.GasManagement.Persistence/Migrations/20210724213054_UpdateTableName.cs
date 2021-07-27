using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonitorGas.GasManagement.Persistence.Migrations
{
    public partial class UpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gas_GasSizes_GasSizeID",
                table: "Gas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gas",
                table: "Gas");

            migrationBuilder.RenameTable(
                name: "Gas",
                newName: "Gases");

            migrationBuilder.RenameIndex(
                name: "IX_Gas_GasSizeID",
                table: "Gases",
                newName: "IX_Gases_GasSizeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gases",
                table: "Gases",
                column: "GasID");

            migrationBuilder.UpdateData(
                table: "Gases",
                keyColumn: "GasID",
                keyValue: new Guid("51d03858-68eb-4887-94a0-2ed111ef954b"),
                column: "Date",
                value: new DateTime(2022, 1, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Gases",
                keyColumn: "GasID",
                keyValue: new Guid("7bc4b468-2c09-44b0-9ddb-32d09aec5b08"),
                column: "Date",
                value: new DateTime(2022, 1, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Gases",
                keyColumn: "GasID",
                keyValue: new Guid("7ea5e087-06e7-4bfc-ab17-bb182a42ce3d"),
                column: "Date",
                value: new DateTime(2021, 11, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Gases",
                keyColumn: "GasID",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2022, 1, 24, 22, 30, 53, 552, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.AddForeignKey(
                name: "FK_Gases_GasSizes_GasSizeID",
                table: "Gases",
                column: "GasSizeID",
                principalTable: "GasSizes",
                principalColumn: "GasSizeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gases_GasSizes_GasSizeID",
                table: "Gases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gases",
                table: "Gases");

            migrationBuilder.RenameTable(
                name: "Gases",
                newName: "Gas");

            migrationBuilder.RenameIndex(
                name: "IX_Gases_GasSizeID",
                table: "Gas",
                newName: "IX_Gas_GasSizeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gas",
                table: "Gas",
                column: "GasID");

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("51d03858-68eb-4887-94a0-2ed111ef954b"),
                column: "Date",
                value: new DateTime(2022, 1, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("7bc4b468-2c09-44b0-9ddb-32d09aec5b08"),
                column: "Date",
                value: new DateTime(2022, 1, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("7ea5e087-06e7-4bfc-ab17-bb182a42ce3d"),
                column: "Date",
                value: new DateTime(2021, 11, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2022, 1, 23, 21, 37, 4, 474, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 23, 21, 37, 4, 476, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.AddForeignKey(
                name: "FK_Gas_GasSizes_GasSizeID",
                table: "Gas",
                column: "GasSizeID",
                principalTable: "GasSizes",
                principalColumn: "GasSizeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
