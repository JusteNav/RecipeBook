using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Data.Migrations.Recipe
{
    public partial class ChangedPropertyNullability2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0cc0caae-70d4-4952-bf8c-b422a96e29b1"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("17ac4db6-107c-4f37-b743-1f68ddd9efc3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2b2e2b09-de57-411c-876c-93aca0307716"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("37a3342d-4014-41b2-a401-858c3e939138"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("49068f5d-44a9-4396-be84-5e2dec478e95"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("65172120-a209-4b59-a646-f1985836ba77"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("66ef4d14-0a30-47c3-bc84-faea37394462"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6f1c62eb-ed66-4891-8305-bcab87c15125"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("70cf991b-1e5d-47be-97bf-a3a9878b8629"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("82145114-6cc8-4156-b0e9-8b9e370ad940"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8985262b-050d-4d97-a91e-426d3e22acfc"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a04c276b-0a78-4744-937f-42990e740645"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a64ecfc0-4fbf-447f-b0d8-1b3e508a0e1a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("fde888e8-02f3-482d-98b0-c323c374b01e"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("1e3bdda2-7058-4ab2-9ba3-9b4482e7773b"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("24eb6cba-be35-48b7-b45c-4bf8efcb50af"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("4f3d917f-7821-46f0-9d43-ca3a2ea5abd7"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("52fa2304-4fc4-4a4d-8a35-19b6b7f867ae"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("64d18392-e21c-4b76-a7e3-e152eb3ca642"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("67a1529a-f6bc-4fa9-9a98-74668f4debb6"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("71840ed9-f38e-45e5-b699-a0f58b96c4df"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("7b729dc2-4b4b-405f-8d6a-a5b49b298072"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("89bc644a-f280-44fd-8be0-8024ffc11000"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("8c8648cf-6bff-4075-ab7b-1fd26aeb7678"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("bdfba7e5-4356-4b79-adb9-3a97de5542b4"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("e5f450b5-aef6-4c04-933d-74a7e592c82f"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("eb21207d-c60e-4376-9db1-80612b5b1075"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a"));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Steps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "StepNumber",
                table: "Steps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "Steps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "FullTitle",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Ingredients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 2, "I always pour on the pancake batter using a measuring cup, so I end up with consistently-sized pancakes.", "1", "Thin Pancakes" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068"), 4, null, "6", "Carrot and Apple Juice" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"), 0, "If you won't immediately consume the salad, spray it with a little bit of lemon juice and leave it in the fridge. Consume the same day though.", "2", "Apple and Carrot Salad" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Category", "FullTitle", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("01b76963-6e0e-4765-adcc-c335e276a44c"), 1, "1 cup flour", new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354") },
                    { new Guid("0cd168b2-0a27-4559-ba94-ed9ea209891a"), 17, "4 apples", new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7") },
                    { new Guid("26bc0fee-8d45-4bb4-9d6f-2681e2e66802"), 0, "A pinch of salt (tip of the teaspoon)", new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354") },
                    { new Guid("5f11ea85-70f6-454d-b0ec-d0a1ad3c7fda"), 12, "2 tablespoons sour cream", new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7") },
                    { new Guid("68146913-6775-4331-95dc-e530953405e9"), 28, "1 teaspoon sugar", new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354") },
                    { new Guid("696996e4-013e-4433-8f6a-5e355bcae47b"), 0, "2 stalks celery (optional)", new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068") },
                    { new Guid("6d3857a7-4e01-411f-9af9-773b0e64a1fe"), 0, "2 teaspoons sugar (optional)", new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7") },
                    { new Guid("70bcf310-88cf-4c7b-ba41-ae624096f0d5"), 19, "4 carrots, trimmed", new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068") },
                    { new Guid("7574c4fd-cf7a-4d26-a0c2-4b449c30a2e3"), 11, "1 1/4 cups milk", new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354") },
                    { new Guid("a26b0c90-9cdc-42fd-8b6e-6ce906658315"), 6, "2 eggs", new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354") },
                    { new Guid("ba406563-d1e2-4b12-b45b-f6cf822340c8"), 19, "4 carrots", new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7") },
                    { new Guid("c0974234-ebdd-414b-b74f-eb38f8e70485"), 0, "1,5 cm piece of fresh ginger (optional)", new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068") },
                    { new Guid("d978e875-4c04-4c21-8def-cb525d765056"), 30, "Oil for frying", new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354") },
                    { new Guid("fc9b5e66-f2c6-4567-9399-e409bc0bbf98"), 17, "2 apples, quartered", new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068") }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "RecipeId", "StepNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("022fb291-ec19-4261-b7aa-933410d76069"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 2, "Crack in the eggs, add a bit of the milk." },
                    { new Guid("071f527d-cfcf-4445-94c1-309998365317"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 1, "Sift the flour, sugar and salt, make a well in it." },
                    { new Guid("0a1261db-a9cf-4981-9667-4a911ef127a2"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 8, "Serve with jam, sour cream, ice cream with berries and fruits - whatever you want!" },
                    { new Guid("0cc4f581-6810-47d9-a593-f651cb88b7d1"), new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068"), 2, "Add ginger to juicer and process (optional)." },
                    { new Guid("21f29c19-20bd-4fbc-aa6e-47e3c70e7d9a"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 6, "Then pour on the pancake batter and quickly swirl it around." },
                    { new Guid("2391ba7b-dcce-47b9-bd38-a8eab81d0a49"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 3, "Then start whisking it all together (you can use a mixer)." },
                    { new Guid("34c34a0b-3fc1-46f8-9c59-9948f508c923"), new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"), 2, "Add sugar and sour cream. Mix everything thoroughly so that the sugar melts to the maximum." },
                    { new Guid("5c5de2a1-fb50-4e85-b471-ab8735d46cc7"), new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"), 1, "Wash, peel and grate apples and carrots. Combine." },
                    { new Guid("5e47dee5-4d04-4e1e-84f3-db8c66c4f5b4"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 7, "Cook until the batter is no longer liquid." },
                    { new Guid("67c0da83-dd60-4228-aa91-b272e01d3fa0"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 5, "Add on a bit of oil, and quickly swirl it around the pan. Make sure your pan is evenly nice and hot before you start cooking the pancakes. If the pan isn't hot enough, the recipe won't work." },
                    { new Guid("a310b8c2-af8d-45d9-b2fd-83b5c3ffb9b5"), new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"), 4, "Next, whisk in the rest of the milk and until you have a pancake batter that resembles the consistency of whipping cream." },
                    { new Guid("af1e87cc-3591-433e-9534-d20374f68f32"), new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068"), 1, "Run carrots, apples, (celery) through a juicer, alternating carrot, apple, and, optionally, celery, according to manufacturer's instructions." },
                    { new Guid("b02e069e-8987-45d0-ab55-8f7cfad5caa3"), new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"), 3, "Serve the delicious salad to the table." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("01b76963-6e0e-4765-adcc-c335e276a44c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0cd168b2-0a27-4559-ba94-ed9ea209891a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("26bc0fee-8d45-4bb4-9d6f-2681e2e66802"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5f11ea85-70f6-454d-b0ec-d0a1ad3c7fda"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("68146913-6775-4331-95dc-e530953405e9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("696996e4-013e-4433-8f6a-5e355bcae47b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6d3857a7-4e01-411f-9af9-773b0e64a1fe"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("70bcf310-88cf-4c7b-ba41-ae624096f0d5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7574c4fd-cf7a-4d26-a0c2-4b449c30a2e3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a26b0c90-9cdc-42fd-8b6e-6ce906658315"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ba406563-d1e2-4b12-b45b-f6cf822340c8"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c0974234-ebdd-414b-b74f-eb38f8e70485"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d978e875-4c04-4c21-8def-cb525d765056"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("fc9b5e66-f2c6-4567-9399-e409bc0bbf98"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("022fb291-ec19-4261-b7aa-933410d76069"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("071f527d-cfcf-4445-94c1-309998365317"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("0a1261db-a9cf-4981-9667-4a911ef127a2"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("0cc4f581-6810-47d9-a593-f651cb88b7d1"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("21f29c19-20bd-4fbc-aa6e-47e3c70e7d9a"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("2391ba7b-dcce-47b9-bd38-a8eab81d0a49"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("34c34a0b-3fc1-46f8-9c59-9948f508c923"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("5c5de2a1-fb50-4e85-b471-ab8735d46cc7"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("5e47dee5-4d04-4e1e-84f3-db8c66c4f5b4"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("67c0da83-dd60-4228-aa91-b272e01d3fa0"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("a310b8c2-af8d-45d9-b2fd-83b5c3ffb9b5"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("af1e87cc-3591-433e-9534-d20374f68f32"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("b02e069e-8987-45d0-ab55-8f7cfad5caa3"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Steps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StepNumber",
                table: "Steps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "Steps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullTitle",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 2, "I always pour on the pancake batter using a measuring cup, so I end up with consistently-sized pancakes.", "1", "Thin Pancakes" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335"), 0, "If you won't immediately consume the salad, spray it with a little bit of lemon juice and leave it in the fridge. Consume the same day though.", "2", "Apple and Carrot Salad" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a"), 4, null, "6", "Carrot and Apple Juice" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Category", "FullTitle", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("0cc0caae-70d4-4952-bf8c-b422a96e29b1"), 0, "1,5 cm piece of fresh ginger (optional)", new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a") },
                    { new Guid("17ac4db6-107c-4f37-b743-1f68ddd9efc3"), 17, "2 apples, quartered", new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a") },
                    { new Guid("2b2e2b09-de57-411c-876c-93aca0307716"), 0, "2 stalks celery (optional)", new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a") },
                    { new Guid("37a3342d-4014-41b2-a401-858c3e939138"), 0, "A pinch of salt (tip of the teaspoon)", new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248") },
                    { new Guid("49068f5d-44a9-4396-be84-5e2dec478e95"), 11, "1 1/4 cups milk", new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248") },
                    { new Guid("65172120-a209-4b59-a646-f1985836ba77"), 0, "2 teaspoons sugar (optional)", new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335") },
                    { new Guid("66ef4d14-0a30-47c3-bc84-faea37394462"), 1, "1 cup flour", new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248") },
                    { new Guid("6f1c62eb-ed66-4891-8305-bcab87c15125"), 30, "Oil for frying", new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248") },
                    { new Guid("70cf991b-1e5d-47be-97bf-a3a9878b8629"), 19, "4 carrots", new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335") },
                    { new Guid("82145114-6cc8-4156-b0e9-8b9e370ad940"), 6, "2 eggs", new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248") },
                    { new Guid("8985262b-050d-4d97-a91e-426d3e22acfc"), 17, "4 apples", new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335") },
                    { new Guid("a04c276b-0a78-4744-937f-42990e740645"), 28, "1 teaspoon sugar", new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248") },
                    { new Guid("a64ecfc0-4fbf-447f-b0d8-1b3e508a0e1a"), 12, "2 tablespoons sour cream", new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335") },
                    { new Guid("fde888e8-02f3-482d-98b0-c323c374b01e"), 19, "4 carrots, trimmed", new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a") }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "RecipeId", "StepNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("1e3bdda2-7058-4ab2-9ba3-9b4482e7773b"), new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a"), 2, "Add ginger to juicer and process (optional)." },
                    { new Guid("24eb6cba-be35-48b7-b45c-4bf8efcb50af"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 5, "Add on a bit of oil, and quickly swirl it around the pan. Make sure your pan is evenly nice and hot before you start cooking the pancakes. If the pan isn't hot enough, the recipe won't work." },
                    { new Guid("4f3d917f-7821-46f0-9d43-ca3a2ea5abd7"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 6, "Then pour on the pancake batter and quickly swirl it around." },
                    { new Guid("52fa2304-4fc4-4a4d-8a35-19b6b7f867ae"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 7, "Cook until the batter is no longer liquid." },
                    { new Guid("64d18392-e21c-4b76-a7e3-e152eb3ca642"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 4, "Next, whisk in the rest of the milk and until you have a pancake batter that resembles the consistency of whipping cream." },
                    { new Guid("67a1529a-f6bc-4fa9-9a98-74668f4debb6"), new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335"), 2, "Add sugar and sour cream. Mix everything thoroughly so that the sugar melts to the maximum." },
                    { new Guid("71840ed9-f38e-45e5-b699-a0f58b96c4df"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 1, "Sift the flour, sugar and salt, make a well in it." },
                    { new Guid("7b729dc2-4b4b-405f-8d6a-a5b49b298072"), new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335"), 3, "Serve the delicious salad to the table." },
                    { new Guid("89bc644a-f280-44fd-8be0-8024ffc11000"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 8, "Serve with jam, sour cream, ice cream with berries and fruits - whatever you want!" },
                    { new Guid("8c8648cf-6bff-4075-ab7b-1fd26aeb7678"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 2, "Crack in the eggs, add a bit of the milk." },
                    { new Guid("bdfba7e5-4356-4b79-adb9-3a97de5542b4"), new Guid("f74b130c-cd2c-4f45-a4a6-c0db1e41c78a"), 1, "Run carrots, apples, (celery) through a juicer, alternating carrot, apple, and, optionally, celery, according to manufacturer's instructions." },
                    { new Guid("e5f450b5-aef6-4c04-933d-74a7e592c82f"), new Guid("e8e78870-226b-4dda-bda8-62ad8fe51335"), 1, "Wash, peel and grate apples and carrots. Combine." },
                    { new Guid("eb21207d-c60e-4376-9db1-80612b5b1075"), new Guid("56112c2e-19bb-4c90-8e15-3dd15ee45248"), 3, "Then start whisking it all together (you can use a mixer)." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
