using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jetstream.Migrations
{
    /// <inheritdoc />
    public partial class Testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JetDbKind",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Namespace = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JetDbKind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitKinds",
                columns: table => new
                {
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false),
                    KindId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitKinds", x => new { x.UnitId, x.KindId });
                    table.ForeignKey(
                        name: "FK_UnitKinds_JetDbKind_KindId",
                        column: x => x.KindId,
                        principalTable: "JetDbKind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitKinds_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitKinds_KindId",
                table: "UnitKinds",
                column: "KindId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitKinds");

            migrationBuilder.DropTable(
                name: "JetDbKind");
        }
    }
}
