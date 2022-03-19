using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Industry.API.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfferRows");

            migrationBuilder.DropTable(
                name: "OfferHeads");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderTitlesId",
                table: "Product",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OfferNo = table.Column<string>(type: "text", nullable: false),
                    OfferSentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderTitles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    IsTemplate = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderTitleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    RowNo = table.Column<int>(type: "integer", nullable: false),
                    OrderTitlesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrder_OrderTitles_OrderTitlesId",
                        column: x => x.OrderTitlesId,
                        principalTable: "OrderTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfferProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    OfferId = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    OrderTitlesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentWorkOrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    OffersId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkOrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferProducts_Offers_OffersId",
                        column: x => x.OffersId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfferProducts_OrderTitles_OrderTitlesId",
                        column: x => x.OrderTitlesId,
                        principalTable: "OrderTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfferProducts_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfferProducts_WorkOrder_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderTitlesId",
                table: "Product",
                column: "OrderTitlesId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferProducts_OffersId",
                table: "OfferProducts",
                column: "OffersId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferProducts_OrderTitlesId",
                table: "OfferProducts",
                column: "OrderTitlesId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferProducts_ProductId",
                table: "OfferProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferProducts_WorkOrderId",
                table: "OfferProducts",
                column: "WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CustomerId",
                table: "Offers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_OrderTitlesId",
                table: "WorkOrder",
                column: "OrderTitlesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_OrderTitles_OrderTitlesId",
                table: "Product",
                column: "OrderTitlesId",
                principalTable: "OrderTitles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_OrderTitles_OrderTitlesId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "OfferProducts");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "WorkOrder");

            migrationBuilder.DropTable(
                name: "OrderTitles");

            migrationBuilder.DropIndex(
                name: "IX_Product_OrderTitlesId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "OrderTitlesId",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "OfferHeads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<int>(type: "integer", nullable: false)
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
                    OfferHeadId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<double>(type: "double precision", nullable: true)
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
    }
}
