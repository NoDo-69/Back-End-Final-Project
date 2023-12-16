using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Project.Migrations
{
    public partial class SecondGameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "Genre",
                value: "First-Person Shooter Action");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "Genre",
                value: "Open World Zombies Survival Story Rich");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Developer", "Genre", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 9, "Winner of over 175 Game of the Year Awards and recipient of over 250 perfect scores, RDR2 is the epic tale of outlaw Arthur Morgan and the infamous Van der Linde gang, on the run across America at the dawn of the modern age. Also includes access to the shared living world of Red Dead Online.", "Rockstar", "Open World Story Rich Adventure", "Red Dead Redemption 2", new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "A co-op horror about scavenging at abandoned moons to sell scrap to the Company.", "Zeekerss", "Online Co-op Horror First-Person", "Lethal Company", new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Your Ultimate Horizon Adventure awaits! Explore the vibrant open world landscapes of Mexico with limitless, fun driving action in the world’s greatest cars. Conquer the rugged Sierra Nueva in the ultimate Horizon Rally experience. Requires Forza Horizon 5 game, expansion sold separately.", "Playground Games", "Racing Open World", "Forza Horizon 5", new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "Genre",
                value: "First Person Shooter");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "Genre",
                value: "Open World Zombies Survival");
        }
    }
}
