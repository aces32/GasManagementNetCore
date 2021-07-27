using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonitorGas.GasManagement.Persistence.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GasSizes",
                columns: table => new
                {
                    GasSizeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeInKg = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasSizes", x => x.GasSizeID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderTotal = table.Column<int>(type: "int", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPaid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gas",
                columns: table => new
                {
                    GasID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GasVendorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GasSizeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gas", x => x.GasID);
                    table.ForeignKey(
                        name: "FK_Gas_GasSizes_GasSizeID",
                        column: x => x.GasSizeID,
                        principalTable: "GasSizes",
                        principalColumn: "GasSizeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GasSizes",
                columns: new[] { "GasSizeID", "SizeInKg" },
                values: new object[,]
                {
                    { new Guid("9110ec52-c457-4924-a7ee-03e497fa865d"), 10.0 },
                    { new Guid("089be77d-e198-4832-9eb5-4a041b155506"), 20.0 },
                    { new Guid("1bf57a70-e896-4273-874d-15a38291d73b"), 30.0 },
                    { new Guid("3fe536ae-ada3-4097-b255-aa27f8d65c87"), 40.0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "OrderPaid", "OrderPlaced", "OrderTotal", "UserID" },
                values: new object[,]
                {
                    { new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(8956), 400, new Guid("a441eb40-9636-4ee6-be49-a66c5ec1330b") },
                    { new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9732), 135, new Guid("ac3cfaf5-34fd-4e4d-bc04-ad1083ddc340") },
                    { new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9763), 85, new Guid("d97a15fc-0d32-41c6-9ddf-62f0735c4c1c") },
                    { new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9786), 245, new Guid("4ad901be-f447-46dd-bcf7-dbe401afa203") },
                    { new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9806), 142, new Guid("7aeb2c01-fe8e-4b84-a5ba-330bdf950f5c") },
                    { new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 7, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(9908), 40, new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923") }
                });

            migrationBuilder.InsertData(
                table: "Gas",
                columns: new[] { "GasID", "Color", "Date", "Description", "GasSizeID", "GasVendorName", "ImageUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("51d03858-68eb-4887-94a0-2ed111ef954b"), "Blue", new DateTime(2022, 1, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(7257), "Red gas added to the company by Red Coporate Gas limited.", new Guid("9110ec52-c457-4924-a7ee-03e497fa865d"), "Red Coporate Gas Limited", "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg", 25 },
                    { new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"), "Red", new DateTime(2022, 1, 22, 21, 16, 21, 481, DateTimeKind.Local).AddTicks(1127), "Red gas added to the company by Abc Ga limited.", new Guid("089be77d-e198-4832-9eb5-4a041b155506"), "ABC Gas Limited", "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg", 65 },
                    { new Guid("7ea5e087-06e7-4bfc-ab17-bb182a42ce3d"), "Yellow", new DateTime(2021, 11, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(7199), "Yellow gas added to the company by Abc Gas limited.", new Guid("089be77d-e198-4832-9eb5-4a041b155506"), "ABC Gas Limited", "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg", 95 },
                    { new Guid("7bc4b468-2c09-44b0-9ddb-32d09aec5b08"), "Green", new DateTime(2022, 1, 22, 21, 16, 21, 482, DateTimeKind.Local).AddTicks(7284), "Green added to the company by Smart Gas Limited.", new Guid("1bf57a70-e896-4273-874d-15a38291d73b"), "Smart Gas Limited", "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg", 175 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gas_GasSizeID",
                table: "Gas",
                column: "GasSizeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gas");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "GasSizes");
        }
    }
}
