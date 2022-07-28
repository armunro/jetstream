using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jetstream.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gateway",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gateway", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kind",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Namespace = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GatewayId = table.Column<Guid>(type: "uuid", nullable: false),
                    Contents = table.Column<JsonDocument>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Gateway_GatewayId",
                        column: x => x.GatewayId,
                        principalTable: "Gateway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Expression = table.Column<string>(type: "text", nullable: true),
                    KindId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proto_Kind_KindId",
                        column: x => x.KindId,
                        principalTable: "Kind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GatewayProto",
                columns: table => new
                {
                    GatewayId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProtoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayProto", x => new { x.GatewayId, x.ProtoId });
                    table.ForeignKey(
                        name: "FK_GatewayProto_Gateway_GatewayId",
                        column: x => x.GatewayId,
                        principalTable: "Gateway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GatewayProto_Proto_ProtoId",
                        column: x => x.ProtoId,
                        principalTable: "Proto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitKind",
                columns: table => new
                {
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    KindId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitKind", x => new { x.UnitId, x.ProtoId, x.KindId });
                    table.ForeignKey(
                        name: "FK_UnitKind_Kind_KindId",
                        column: x => x.KindId,
                        principalTable: "Kind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitKind_Proto_ProtoId",
                        column: x => x.ProtoId,
                        principalTable: "Proto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitKind_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gateway",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[] { new Guid("0202ce66-2504-4211-ba35-bce32e527d41"), new DateTime(2022, 7, 25, 14, 0, 59, 687, DateTimeKind.Local).AddTicks(3542), "Accepts task objects and prototypes data around due dates. ", "Sample Task Gateway" });

            migrationBuilder.InsertData(
                table: "Kind",
                columns: new[] { "Id", "Name", "Namespace" },
                values: new object[] { new Guid("b4e3c63f-78b0-4382-a434-a00d9d3e61f9"), "Due Date", "Jetstream.Core" });

            migrationBuilder.InsertData(
                table: "Proto",
                columns: new[] { "Id", "Expression", "KindId", "Name", "Role" },
                values: new object[] { new Guid("d8c81623-0fd2-49c0-9e09-43242c962996"), "$.Date", new Guid("b4e3c63f-78b0-4382-a434-a00d9d3e61f9"), "Task Due Date", 2 });

            migrationBuilder.InsertData(
                table: "GatewayProto",
                columns: new[] { "GatewayId", "ProtoId" },
                values: new object[] { new Guid("0202ce66-2504-4211-ba35-bce32e527d41"), new Guid("d8c81623-0fd2-49c0-9e09-43242c962996") });

            migrationBuilder.CreateIndex(
                name: "IX_GatewayProto_ProtoId",
                table: "GatewayProto",
                column: "ProtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proto_KindId",
                table: "Proto",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_GatewayId",
                table: "Unit",
                column: "GatewayId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitKind_KindId",
                table: "UnitKind",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitKind_ProtoId",
                table: "UnitKind",
                column: "ProtoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GatewayProto");

            migrationBuilder.DropTable(
                name: "UnitKind");

            migrationBuilder.DropTable(
                name: "Proto");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Kind");

            migrationBuilder.DropTable(
                name: "Gateway");
        }
    }
}
