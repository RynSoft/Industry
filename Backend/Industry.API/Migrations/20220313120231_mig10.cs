using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Industry.API.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfferHeads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferHeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferHeads_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfferRows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    OfferHeadId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferRows_OfferHeads_OfferHeadId",
                        column: x => x.OfferHeadId,
                        principalTable: "OfferHeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfferRows_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OfferHeads_CustomerId",
                table: "OfferHeads",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferRows_OfferHeadId",
                table: "OfferRows",
                column: "OfferHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferRows_ProductId",
                table: "OfferRows",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfferRows");

            migrationBuilder.DropTable(
                name: "OfferHeads");
        }
    }
}
