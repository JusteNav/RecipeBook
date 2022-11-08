using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Data.Migrations.Recipe
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    PictureTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 2, "I always pour on the pancake batter using a measuring cup, so I end up with consistently-sized pancakes.", "1", "Thin Pancakes" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437"), 4, null, "6", "Carrot and Apple Juice" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace"), 0, "If you won't immediately consume the salad, spray it with a little bit of lemon juice and leave it in the fridge. Consume the same day though.", "2", "Apple and Carrot Salad" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Category", "FullTitle", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("12de0782-1326-4833-b880-2c78c227e865"), 11, "1 1/4 cups milk", new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e") },
                    { new Guid("184099bb-f53d-430e-af9b-4e958164648b"), 17, "2 apples, quartered", new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437") },
                    { new Guid("253dfe83-31f3-4c5e-b889-a5b040ba78dc"), 17, "4 apples", new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace") },
                    { new Guid("3207a492-7363-488c-8f00-5bdc7c9a1d06"), 1, "1 cup flour", new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e") },
                    { new Guid("32871c20-1f8b-4e07-a04f-5d8588622f3a"), 19, "4 carrots, trimmed", new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437") },
                    { new Guid("3c105878-3d07-4161-8e98-bbb7047dbc15"), 0, "2 stalks celery (optional)", new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437") },
                    { new Guid("40c1cabe-662e-4396-b427-438156414543"), 28, "1 teaspoon sugar", new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e") },
                    { new Guid("47e27257-2b20-4c14-abba-b31891a311f6"), 30, "Oil for frying", new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e") },
                    { new Guid("607b7d3c-b8a7-4f59-a8f5-b245eb32b1d3"), 12, "2 tablespoons sour cream", new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace") },
                    { new Guid("93922a19-a493-4890-8c67-03403eccd8bd"), 0, "A pinch of salt (tip of the teaspoon)", new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e") },
                    { new Guid("bc35dbf7-0d0a-4139-8d2d-7556ff27b99a"), 0, "1,5 cm piece of fresh ginger (optional)", new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437") },
                    { new Guid("bd22c6d0-2199-46b7-9557-8fb712eb6b6c"), 19, "4 carrots", new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace") },
                    { new Guid("d38cc040-485b-4d51-b8cf-66dbb5afc539"), 6, "2 eggs", new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e") },
                    { new Guid("d5cfeedd-bee5-4388-9052-83d358e19e41"), 0, "2 teaspoons sugar (optional)", new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace") }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "RecipeId", "StepNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("2bc1807a-7e4f-45c1-b8a9-430f268b4f68"), new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437"), 2, "Add ginger to juicer and process (optional)." },
                    { new Guid("4254593a-c9c9-4aec-8a63-30330fd0380b"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 8, "Serve with jam, sour cream, ice cream with berries and fruits - whatever you want!" },
                    { new Guid("66dfebf1-50cd-4e06-bc8d-e241ba44f698"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 1, "Sift the flour, sugar and salt, make a well in it." },
                    { new Guid("6d4a1581-6a1e-4df8-acfe-c4dffeb31957"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 3, "Then start whisking it all together (you can use a mixer)." },
                    { new Guid("a3b6b9d9-27af-4390-82ee-5f4f0adadca8"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 5, "Add on a bit of oil, and quickly swirl it around the pan. Make sure your pan is evenly nice and hot before you start cooking the pancakes. If the pan isn't hot enough, the recipe won't work." },
                    { new Guid("b2875423-e702-4b54-8146-6d1f7a99b3fe"), new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437"), 1, "Run carrots, apples, (celery) through a juicer, alternating carrot, apple, and, optionally, celery, according to manufacturer's instructions." },
                    { new Guid("c6f6a57f-9305-4682-a0bf-4808787ab3f6"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 2, "Crack in the eggs, add a bit of the milk." },
                    { new Guid("ccb229c5-3a20-4a66-b211-a1ce5355fcbd"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 6, "Then pour on the pancake batter and quickly swirl it around." },
                    { new Guid("d1cbf335-e0b8-4303-b4d5-4f3b5ac4d662"), new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace"), 1, "Wash, peel and grate apples and carrots. Combine." },
                    { new Guid("d47ac5c6-e742-41d6-9dae-d4ceeb05e5a6"), new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace"), 3, "Serve the delicious salad to the table." },
                    { new Guid("d588310a-5356-4917-9a42-5c90b2c19499"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 4, "Next, whisk in the rest of the milk and until you have a pancake batter that resembles the consistency of whipping cream." },
                    { new Guid("e3996a19-ba8f-4a45-8636-e6dc99d7f5bb"), new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace"), 2, "Add sugar and sour cream. Mix everything thoroughly so that the sugar melts to the maximum." },
                    { new Guid("f6487049-e109-41f3-a6b4-e3fa4470092e"), new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"), 7, "Cook until the batter is no longer liquid." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_RecipeId",
                table: "Steps",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
