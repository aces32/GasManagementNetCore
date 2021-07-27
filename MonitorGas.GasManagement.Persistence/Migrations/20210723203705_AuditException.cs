using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonitorGas.GasManagement.Persistence.Migrations
{
    public partial class AuditException : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "GasSizes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "GasSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "GasSizes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "GasSizes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Gas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Gas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Gas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Gas",
                type: "datetime2",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GasSizes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "GasSizes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "GasSizes");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "GasSizes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Gas");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Gas");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Gas");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Gas");

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("51d03858-68eb-4887-94a0-2ed111ef954b"),
                column: "Date",
                value: new DateTime(2022, 1, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("7bc4b468-2c09-44b0-9ddb-32d09aec5b08"),
                column: "Date",
                value: new DateTime(2022, 1, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("7ea5e087-06e7-4bfc-ab17-bb182a42ce3d"),
                column: "Date",
                value: new DateTime(2021, 11, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Gas",
                keyColumn: "GasID",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2022, 1, 22, 21, 16, 21, 481, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9908));
        }
    }
}
