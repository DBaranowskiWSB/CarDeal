using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDeal.API.Migrations
{
    public partial class CarsRecordsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    MerchantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyTypeId = table.Column<int>(type: "int", nullable: true),
                    VehicleBrandId = table.Column<int>(type: "int", nullable: true),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    YearOfProduction = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: true),
                    MerchantTelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarAds_BodyType_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "BodyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarAds_FuelType_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarAds_VehicleBrand_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhotoAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarAdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoAddress_CarAds_CarAdId",
                        column: x => x.CarAdId,
                        principalTable: "CarAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BodyType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Coupe" },
                    { 2, "Cabriolet" },
                    { 3, "SUV" },
                    { 4, "Sedan" },
                    { 5, "Compact" },
                    { 6, "Combi" },
                    { 7, "Other" }
                });

            migrationBuilder.InsertData(
                table: "FuelType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 3, "Petrol" },
                    { 4, "LPG" },
                    { 1, "Diesel" },
                    { 2, "Electric" }
                });

            migrationBuilder.InsertData(
                table: "VehicleBrand",
                columns: new[] { "Id", "Brand" },
                values: new object[,]
                {
                    { 9, "Skoda" },
                    { 1, "BMW" },
                    { 2, "Opel" },
                    { 3, "Audi" },
                    { 4, "Volkswagen" },
                    { 5, "Ford" },
                    { 6, "Mercedes-Benz" },
                    { 7, "Renault" },
                    { 8, "Toyota" },
                    { 10, "Other" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarAds_BodyTypeId",
                table: "CarAds",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAds_FuelTypeId",
                table: "CarAds",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAds_VehicleBrandId",
                table: "CarAds",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoAddress_CarAdId",
                table: "PhotoAddress",
                column: "CarAdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoAddress");

            migrationBuilder.DropTable(
                name: "CarAds");

            migrationBuilder.DropTable(
                name: "BodyType");

            migrationBuilder.DropTable(
                name: "FuelType");

            migrationBuilder.DropTable(
                name: "VehicleBrand");
        }
    }
}
