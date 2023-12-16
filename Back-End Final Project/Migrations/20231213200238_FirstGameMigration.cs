using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Project.Migrations
{
    public partial class FirstGameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Developer", "Genre", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "In 2013 the world was devastated by an apocalyptic event, annihilating almost all mankind and turning the Earth's surface into a poisonous wasteland. A handful of survivors took refuge in the depths of the Moscow underground, and human civilization entered a new Dark Age. The year is 2033.", "4A Games", "Sci-Fi Fiction", "Metro 2033", new DateTime(2010, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "In 2013 the world was devastated by an apocalyptic event, annihilating almost all mankind and turning the Earth's surface into a poisonous wasteland. A handful of survivors took refuge in the depths of the Moscow underground, and human civilization entered a new Dark Age. The year is 2033.", "4A Games", "Sci-Fi Fiction", "Metro: Last Light", new DateTime(2013, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Flee the shattered ruins of the Moscow Metro and embark on an epic, continent-spanning journey across the post-apocalyptic Russian wilderness. Explore vast, non-linear levels, lose yourself in an immersive, sandbox survival experience, and follow a thrilling story-line.", "4A Games", "Sci-Fi Fiction", "Metro Exodus", new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Dying Light 2 is an action role-playing survival horror video game featuring a zombie apocalyptic-themed open world. Set 22 years after Dying Light, it stars a new protagonist named Aiden Caldwell", "Techland", "action role-playing survival horror open world Zombies", "Dying Light 2 Stay Human", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Six Days in Fallujah is a realistic first-person tactical shooter based on true stories of Marines, Soldiers, and Iraqi civilians during the toughest urban battle since 1968.", "Highwire Games", "First Person Shooter", "Six Days In Fallujah", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Sent to find a missing billionaire on a remote island, you find yourself in a cannibal-infested hellscape. Craft, build, and struggle to survive, alone or with friends, in this terrifying new open-world survival horror simulator.", "EndLight Games Ltd", "Survival Horror Open World", "Sons Of The Forest", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Ride and fight into a deadly, post pandemic America. Play as Deacon St. John, a drifter and bounty hunter who rides the broken road, fighting to survive while searching for a reason to live in this open-world action-adventure game.", "Bend Studio", "Open World Zombies Survival", "Days Gone", new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "THE NEW FANTASY ACTION RPG. Rise, Tarnished, and be guided by grace to brandish the power of the Elden Ring and become an Elden Lord in the Lands Between.", "FromSoftware Inc", "Open World RPG Dark Fantasy", "Elden Ring", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
