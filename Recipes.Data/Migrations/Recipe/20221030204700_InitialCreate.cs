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
                    Category = table.Column<int>(type: "int", nullable: true),
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
                values: new object[] { new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8"), 4, null, "6", "Carrot and Apple Juice" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), 2, "I always pour on the pancake batter using a measuring cup, so I end up with consistently-sized pancakes.", "1", "Thin Pancakes" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd"), 0, "If you won't immediately consume the salad, spray it with a little bit of lemon juice and leave it in the fridge. Consume the same day though.", "2", "Apple and Carrot Salad" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Category", "FullTitle", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("2284c4bb-77e7-4b96-856d-464436d0a60d"), null, "2 teaspoons sugar (optional)", new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd") },
                    { new Guid("27ae292b-5e9e-46a2-b6a0-f3ecd3092490"), 10, "1 1/4 cups milk", new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7") },
                    { new Guid("2d6e2d77-1209-4466-ab77-f9333b834127"), 5, "2 eggs", new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7") },
                    { new Guid("356670d6-955b-461c-b5cb-7f0ab02e64a5"), 29, "Oil for frying", new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7") },
                    { new Guid("38cadab8-9b22-45e7-a5bb-cc92511cb496"), 27, "1 teaspoon sugar", new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7") },
                    { new Guid("47875b40-697e-4712-98d7-185a65c6846d"), null, "2 stalks celery (optional)", new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8") },
                    { new Guid("50570067-1919-42c0-b491-599be9777fd8"), null, "A pinch of salt (tip of the teaspoon)", new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7") },
                    { new Guid("7daa1a94-a628-4bb0-9386-68c9eef52bc9"), null, "1,5 cm piece of fresh ginger (optional)", new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8") },
                    { new Guid("945ae8dd-e224-4611-87e9-bcc069ef5f23"), 16, "4 apples", new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd") },
                    { new Guid("a9f9e974-3da7-458c-a235-afc0e2e3ae8d"), 0, "1 cup flour", new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7") },
                    { new Guid("af56e05b-6d4e-409a-81ae-ef68faede5b2"), 18, "4 carrots", new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd") },
                    { new Guid("bd6cc4a4-589d-44ad-bd91-3718fa4366b6"), 18, "4 carrots, trimmed", new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8") },
                    { new Guid("c4ff9018-5cb0-4087-9ddb-9189c772f9a9"), 16, "2 apples, quartered", new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8") },
                    { new Guid("c8406077-5d94-487d-97ab-f0eb82f38d28"), 11, "2 tablespoons sour cream", new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd") }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "RecipeId", "Text" },
                values: new object[,]
                {
                    { new Guid("27bc1fc2-ed4d-4ab7-87ae-ce765d88f696"), new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd"), "Wash, peel and grate apples and carrots. Combine." },
                    { new Guid("2facd95d-e737-4e0a-a6fc-b154b3f857a7"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Serve with jam, sour cream, ice cream with berries and fruits - whatever you want!" },
                    { new Guid("302f0eb5-e1be-46dd-9f71-e4e16a5aa722"), new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8"), "Add ginger to juicer and process (optional)." },
                    { new Guid("43f505fd-d2b0-4ff8-9510-448eaa611f5f"), new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd"), "Serve the delicious salad to the table." },
                    { new Guid("45db259b-24b8-41e1-8d23-860afc523dc7"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Cook until the batter is no longer liquid." },
                    { new Guid("46f6cc9f-d991-4d5f-8793-3c6dcdde3fca"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Sift the flour, sugar and salt, make a well in it." },
                    { new Guid("64a13b87-72d2-498f-afe8-6e210513580c"), new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8"), "Run carrots, apples, (celery) through a juicer, alternating carrot, apple, and, optionally, celery, according to manufacturer's instructions." },
                    { new Guid("70f71220-b6fc-4552-be5a-3c489b3c83d2"), new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd"), "Add sugar and sour cream. Mix everything thoroughly so that the sugar melts to the maximum." },
                    { new Guid("73c2b0b3-195e-405c-a653-ebf4c99fec43"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Next, whisk in the rest of the milk and until you have a pancake batter that resembles the consistency of whipping cream." },
                    { new Guid("74a3befc-0939-4bcd-bf19-7cbe5b8b50ee"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Then start whisking it all together (you can use a mixer)." },
                    { new Guid("c8aa9118-429e-44f3-9bcb-6202600dc264"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Add on a bit of oil, and quickly swirl it around the pan. Make sure your pan is evenly nice and hot before you start cooking the pancakes. If the pan isn't hot enough, the recipe won't work." },
                    { new Guid("ca008e8d-bf63-4b8a-8f49-16bcd852f1f6"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Then pour on the pancake batter and quickly swirl it around." },
                    { new Guid("de4f3533-957e-444a-908a-993c767cd9b5"), new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"), "Crack in the eggs, add a bit of the milk." }
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
