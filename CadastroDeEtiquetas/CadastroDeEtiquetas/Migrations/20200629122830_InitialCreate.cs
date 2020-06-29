using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroDeEtiquetas.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    FormularioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: true),
                    Colunas = table.Column<int>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Largura = table.Column<double>(nullable: false),
                    Fixacao = table.Column<int>(nullable: false),
                    GapLinha = table.Column<double>(nullable: false),
                    GapColuna = table.Column<double>(nullable: false),
                    Rfid = table.Column<int>(nullable: false),
                    Imagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.FormularioId);
                });

            migrationBuilder.CreateTable(
                name: "Etiquetas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularioId = table.Column<int>(nullable: false),
                    Linguagem = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    LarguraImpressao = table.Column<int>(nullable: false),
                    Densidade = table.Column<int>(nullable: false),
                    Velocidade = table.Column<int>(nullable: false),
                    Imagem = table.Column<string>(nullable: true),
                    EstruturaEtiqueta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiquetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etiquetas_Formularios_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Formularios",
                        principalColumn: "FormularioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etiquetas_FormularioId",
                table: "Etiquetas",
                column: "FormularioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etiquetas");

            migrationBuilder.DropTable(
                name: "Formularios");
        }
    }
}
