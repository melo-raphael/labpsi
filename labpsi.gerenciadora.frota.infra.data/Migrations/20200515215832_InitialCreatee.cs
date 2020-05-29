using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace labpsi.gerenciadora.frota.infra.data.Migrations
{
    public partial class InitialCreatee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Km",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValue: new Guid("283663c1-1fb6-4be8-b2ab-0a224c91fa7f")),
                    KmAtual = table.Column<string>(nullable: false),
                    DateSaida = table.Column<DateTime>(nullable: false),
                    DataChegada = table.Column<DateTime>(nullable: false),
                    Destino = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Km", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValue: new Guid("90f3646c-cbab-418e-b2c9-3854b1285324")),
                    _kmId = table.Column<Guid>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Chassi = table.Column<string>(nullable: false),
                    Cor = table.Column<string>(nullable: false),
                    KmAtual = table.Column<string>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    MesIpva = table.Column<int>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    Placa = table.Column<string>(nullable: false),
                    Renavam = table.Column<string>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Km__kmId",
                        column: x => x._kmId,
                        principalTable: "Km",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo__kmId",
                table: "Veiculo",
                column: "_kmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Km");
        }
    }
}
