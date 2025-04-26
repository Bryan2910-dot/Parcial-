using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial_.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoDatosMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_asignamiento_t_equipo_EquipoId",
                table: "t_asignamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_t_asignamiento_t_jugadores_JugadorId",
                table: "t_asignamiento");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "t_jugadores");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "t_jugadores",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Edad",
                table: "t_jugadores",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "t_jugadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Posicion",
                table: "t_jugadores",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "t_equipo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "JugadorId",
                table: "t_asignamiento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "t_asignamiento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_t_jugadores_EquipoId",
                table: "t_jugadores",
                column: "EquipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_asignamiento_t_equipo_EquipoId",
                table: "t_asignamiento",
                column: "EquipoId",
                principalTable: "t_equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_asignamiento_t_jugadores_JugadorId",
                table: "t_asignamiento",
                column: "JugadorId",
                principalTable: "t_jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_jugadores_t_equipo_EquipoId",
                table: "t_jugadores",
                column: "EquipoId",
                principalTable: "t_equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_asignamiento_t_equipo_EquipoId",
                table: "t_asignamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_t_asignamiento_t_jugadores_JugadorId",
                table: "t_asignamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_t_jugadores_t_equipo_EquipoId",
                table: "t_jugadores");

            migrationBuilder.DropIndex(
                name: "IX_t_jugadores_EquipoId",
                table: "t_jugadores");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "t_jugadores");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "t_jugadores");

            migrationBuilder.DropColumn(
                name: "Posicion",
                table: "t_jugadores");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "t_jugadores",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "t_jugadores",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "t_equipo",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JugadorId",
                table: "t_asignamiento",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "t_asignamiento",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_t_asignamiento_t_equipo_EquipoId",
                table: "t_asignamiento",
                column: "EquipoId",
                principalTable: "t_equipo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_t_asignamiento_t_jugadores_JugadorId",
                table: "t_asignamiento",
                column: "JugadorId",
                principalTable: "t_jugadores",
                principalColumn: "Id");
        }
    }
}
