using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jetstream.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitKinds_JetDbKind_KindId",
                table: "UnitKinds");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitKinds_Units_UnitId",
                table: "UnitKinds");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Gateways_GatewayId",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitKinds",
                table: "UnitKinds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JetDbKind",
                table: "JetDbKind");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gateways",
                table: "Gateways");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Unit");

            migrationBuilder.RenameTable(
                name: "UnitKinds",
                newName: "UnitKind");

            migrationBuilder.RenameTable(
                name: "JetDbKind",
                newName: "Kind");

            migrationBuilder.RenameTable(
                name: "Gateways",
                newName: "Gateway");

            migrationBuilder.RenameIndex(
                name: "IX_Units_GatewayId",
                table: "Unit",
                newName: "IX_Unit_GatewayId");

            migrationBuilder.RenameIndex(
                name: "IX_UnitKinds_KindId",
                table: "UnitKind",
                newName: "IX_UnitKind_KindId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitKind",
                table: "UnitKind",
                columns: new[] { "UnitId", "KindId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kind",
                table: "Kind",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gateway",
                table: "Gateway",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Gateway_GatewayId",
                table: "Unit",
                column: "GatewayId",
                principalTable: "Gateway",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitKind_Kind_KindId",
                table: "UnitKind",
                column: "KindId",
                principalTable: "Kind",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitKind_Unit_UnitId",
                table: "UnitKind",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Gateway_GatewayId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitKind_Kind_KindId",
                table: "UnitKind");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitKind_Unit_UnitId",
                table: "UnitKind");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitKind",
                table: "UnitKind");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kind",
                table: "Kind");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gateway",
                table: "Gateway");

            migrationBuilder.RenameTable(
                name: "UnitKind",
                newName: "UnitKinds");

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Units");

            migrationBuilder.RenameTable(
                name: "Kind",
                newName: "JetDbKind");

            migrationBuilder.RenameTable(
                name: "Gateway",
                newName: "Gateways");

            migrationBuilder.RenameIndex(
                name: "IX_UnitKind_KindId",
                table: "UnitKinds",
                newName: "IX_UnitKinds_KindId");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_GatewayId",
                table: "Units",
                newName: "IX_Units_GatewayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitKinds",
                table: "UnitKinds",
                columns: new[] { "UnitId", "KindId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JetDbKind",
                table: "JetDbKind",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gateways",
                table: "Gateways",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitKinds_JetDbKind_KindId",
                table: "UnitKinds",
                column: "KindId",
                principalTable: "JetDbKind",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitKinds_Units_UnitId",
                table: "UnitKinds",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Gateways_GatewayId",
                table: "Units",
                column: "GatewayId",
                principalTable: "Gateways",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
