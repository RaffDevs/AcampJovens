using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace AcampJovens.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCampers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campers",
                columns: new string[] { "FirstName", "LastName", "CreatedAt" },
                values: new object[,]
                {
                    { "Beatriz", "Miranda Rocha", DateTime.Now.ToUniversalTime() },
                    { "Yasmin", "Cristina Rodrigues", DateTime.Now.ToUniversalTime() },
                    { "Nicolas", "Henrique Lopes", DateTime.Now.ToUniversalTime() },
                    { "Julia", "Miranda Rocha", DateTime.Now.ToUniversalTime() },
                    { "Gabriel", "da Silva Bruno", DateTime.Now.ToUniversalTime() },
                    { "Mariana", "Ferraz Dias dos Santos", DateTime.Now.ToUniversalTime() },
                    { "Samuel", "Ferraz Dias dos Santos", DateTime.Now.ToUniversalTime() },
                    { "Eloá", "Silva Costa", DateTime.Now.ToUniversalTime() },
                    { "Pedro", "Henrique Goulart", DateTime.Now.ToUniversalTime() },
                    { "Albert", "Fernando De Ol. Santos", DateTime.Now.ToUniversalTime() },
                    { "Maria", "Rita Da Silva Andrade", DateTime.Now.ToUniversalTime() },
                    { "Thainá", "Santiago Bastos Lima", DateTime.Now.ToUniversalTime() },
                    { "Vinícius", "Borges Branquinho", DateTime.Now.ToUniversalTime() },
                    { "Jessica", "Pedrina de Paula Silva", DateTime.Now.ToUniversalTime() },
                    { "Lucas", "Pereira Lourenço", DateTime.Now.ToUniversalTime() },
                    { "Davi", "Guimarães Silva", DateTime.Now.ToUniversalTime() },
                    { "Lívia", "Martins Rocha", DateTime.Now.ToUniversalTime() },
                    { "Bruna", "Araújo Oliveira", DateTime.Now.ToUniversalTime() },
                    { "Pedro", "Lourenço Gonçalves", DateTime.Now.ToUniversalTime() },
                    { "Letícia", "Silva", DateTime.Now.ToUniversalTime() },
                    { "Túlio", "Barbosa Andrian", DateTime.Now.ToUniversalTime() },
                    { "Vitor", "Hugo Silva Borges", DateTime.Now.ToUniversalTime() },
                    { "Ana", "Carla Paula da Silva", DateTime.Now.ToUniversalTime() },
                    { "Gabriel", "Silva Dias", DateTime.Now.ToUniversalTime() },
                    { "Felipe", "Barcelos", DateTime.Now.ToUniversalTime() },
                    { "Rafaela", "Silva Neves", DateTime.Now.ToUniversalTime() },
                    { "Helena", "Alves da Silva", DateTime.Now.ToUniversalTime() },
                    { "Lucas", "Souza Hilquias", DateTime.Now.ToUniversalTime() },
                    { "Maria", "Luiza de Araújo Souza", DateTime.Now.ToUniversalTime() },
                    { "José", "Henrique de Araújo Souza", DateTime.Now.ToUniversalTime() },
                    { "Benício", "", DateTime.Now.ToUniversalTime() }, // Sem sobrenome fornecido
                    { "Mariana", "Silva Alves", DateTime.Now.ToUniversalTime() }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Deleção dos registros inseridos
            migrationBuilder.Sql("DELETE FROM Campers WHERE FirstName IN ('Beatriz', 'Yasmin', 'Nicolas', 'Julia', 'Gabriel', 'Mariana', 'Samuel', 'Eloá', 'Pedro', 'Albert', 'Maria', 'Thainá', 'Vinícius', 'Jessica', 'Lucas', 'Davi', 'Lívia', 'Bruna', 'Pedro', 'Letícia', 'Túlio', 'Vitor', 'Ana', 'Gabriel', 'Felipe', 'Rafaela', 'Helena', 'Lucas', 'Maria', 'José', 'Benício', 'Mariana')");
        }
    }
}
