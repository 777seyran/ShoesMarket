using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShoesMarket.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DelieveryType",
                table: "Delieveries");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Delieveries");

            migrationBuilder.AddColumn<int>(
                name: "DelieveryTypeDeliveryTypeId",
                table: "Delieveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusDeliveryStatusId",
                table: "Delieveries",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DeliveryStatuses",
                columns: table => new
                {
                    DeliveryStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryStatuses", x => x.DeliveryStatusId);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryTypes",
                columns: table => new
                {
                    DeliveryTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryTypes", x => x.DeliveryTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Delieveries_DelieveryTypeDeliveryTypeId",
                table: "Delieveries",
                column: "DelieveryTypeDeliveryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Delieveries_StatusDeliveryStatusId",
                table: "Delieveries",
                column: "StatusDeliveryStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Delieveries_DeliveryTypes_DelieveryTypeDeliveryTypeId",
                table: "Delieveries",
                column: "DelieveryTypeDeliveryTypeId",
                principalTable: "DeliveryTypes",
                principalColumn: "DeliveryTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Delieveries_DeliveryStatuses_StatusDeliveryStatusId",
                table: "Delieveries",
                column: "StatusDeliveryStatusId",
                principalTable: "DeliveryStatuses",
                principalColumn: "DeliveryStatusId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delieveries_DeliveryTypes_DelieveryTypeDeliveryTypeId",
                table: "Delieveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Delieveries_DeliveryStatuses_StatusDeliveryStatusId",
                table: "Delieveries");

            migrationBuilder.DropTable(
                name: "DeliveryStatuses");

            migrationBuilder.DropTable(
                name: "DeliveryTypes");

            migrationBuilder.DropIndex(
                name: "IX_Delieveries_DelieveryTypeDeliveryTypeId",
                table: "Delieveries");

            migrationBuilder.DropIndex(
                name: "IX_Delieveries_StatusDeliveryStatusId",
                table: "Delieveries");

            migrationBuilder.DropColumn(
                name: "DelieveryTypeDeliveryTypeId",
                table: "Delieveries");

            migrationBuilder.DropColumn(
                name: "StatusDeliveryStatusId",
                table: "Delieveries");

            migrationBuilder.AddColumn<string>(
                name: "DelieveryType",
                table: "Delieveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Delieveries",
                nullable: true);
        }
    }
}
