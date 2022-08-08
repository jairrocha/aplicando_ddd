using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Infra.Data.Migrations
{
    public partial class Relacionamento_Cardapio_x_Prato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CARDAPIO",
                columns: table => new
                {
                    ID_CARDAPIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_DIA = table.Column<int>(type: "int", nullable: false),
                    DESC_DIA_SEMANA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARDAPIO", x => x.ID_CARDAPIO);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRATO",
                columns: table => new
                {
                    ID_PRATO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PRECO = table.Column<decimal>(type: "NUMERIC(15,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRATO", x => x.ID_PRATO);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRATO_DIA",
                columns: table => new
                {
                    ID_PRATO_DIA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CARDAPIO = table.Column<int>(type: "int", nullable: false),
                    ID_PRATO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRATO_DIA", x => x.ID_PRATO_DIA);
                    table.ForeignKey(
                        name: "FK_TB_PRATO_DIA_TB_CARDAPIO_ID_CARDAPIO",
                        column: x => x.ID_CARDAPIO,
                        principalTable: "TB_CARDAPIO",
                        principalColumn: "ID_CARDAPIO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_PRATO_DIA_TB_PRATO_ID_PRATO",
                        column: x => x.ID_PRATO,
                        principalTable: "TB_PRATO",
                        principalColumn: "ID_PRATO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRATO_DIA_ID_CARDAPIO_ID_PRATO",
                table: "TB_PRATO_DIA",
                columns: new[] { "ID_CARDAPIO", "ID_PRATO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRATO_DIA_ID_PRATO",
                table: "TB_PRATO_DIA",
                column: "ID_PRATO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PRATO_DIA");

            migrationBuilder.DropTable(
                name: "TB_CARDAPIO");

            migrationBuilder.DropTable(
                name: "TB_PRATO");
        }
    }
}
