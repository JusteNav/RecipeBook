using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Data.Migrations.Recipe
{
    public partial class ChangedNullability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2284c4bb-77e7-4b96-856d-464436d0a60d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("27ae292b-5e9e-46a2-b6a0-f3ecd3092490"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2d6e2d77-1209-4466-ab77-f9333b834127"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("356670d6-955b-461c-b5cb-7f0ab02e64a5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("38cadab8-9b22-45e7-a5bb-cc92511cb496"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("47875b40-697e-4712-98d7-185a65c6846d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("50570067-1919-42c0-b491-599be9777fd8"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7daa1a94-a628-4bb0-9386-68c9eef52bc9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("945ae8dd-e224-4611-87e9-bcc069ef5f23"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a9f9e974-3da7-458c-a235-afc0e2e3ae8d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("af56e05b-6d4e-409a-81ae-ef68faede5b2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bd6cc4a4-589d-44ad-bd91-3718fa4366b6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c4ff9018-5cb0-4087-9ddb-9189c772f9a9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c8406077-5d94-487d-97ab-f0eb82f38d28"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("27bc1fc2-ed4d-4ab7-87ae-ce765d88f696"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("2facd95d-e737-4e0a-a6fc-b154b3f857a7"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("302f0eb5-e1be-46dd-9f71-e4e16a5aa722"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("43f505fd-d2b0-4ff8-9510-448eaa611f5f"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("45db259b-24b8-41e1-8d23-860afc523dc7"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("46f6cc9f-d991-4d5f-8793-3c6dcdde3fca"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("64a13b87-72d2-498f-afe8-6e210513580c"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("70f71220-b6fc-4552-be5a-3c489b3c83d2"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("73c2b0b3-195e-405c-a653-ebf4c99fec43"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("74a3befc-0939-4bcd-bf19-7cbe5b8b50ee"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("c8aa9118-429e-44f3-9bcb-6202600dc264"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("ca008e8d-bf63-4b8a-8f49-16bcd852f1f6"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("de4f3533-957e-444a-908a-993c767cd9b5"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ac0bd784-95de-4693-ad01-1553dd8606f8"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c8e54483-9580-4e68-8f1a-b3da6c34f4b7"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f6d3eecc-c5d6-4daf-9fae-5e940e1f2cdd"));

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
                values: new object[] { new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1"), 4, null, "6", "Carrot and Apple Juice" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), 2, "I always pour on the pancake batter using a measuring cup, so I end up with consistently-sized pancakes.", "1", "Thin Pancakes" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Note", "PictureTitle", "Title" },
                values: new object[] { new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4"), 0, "If you won't immediately consume the salad, spray it with a little bit of lemon juice and leave it in the fridge. Consume the same day though.", "2", "Apple and Carrot Salad" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Category", "FullTitle", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("18e5133c-84ac-498c-9924-ed5e08c01a44"), 19, "4 carrots, trimmed", new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1") },
                    { new Guid("1d8595c6-da01-4e73-9ebf-3ccf42a3c1ea"), 6, "2 eggs", new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa") },
                    { new Guid("2c7d1a2a-b690-4efb-86aa-87a7bdf87ff7"), 1, "1 cup flour", new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa") },
                    { new Guid("2d6d02aa-c040-49c2-8aec-669483276dd5"), 0, "1,5 cm piece of fresh ginger (optional)", new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1") },
                    { new Guid("31533188-2287-4470-adac-f4fb44636652"), 28, "1 teaspoon sugar", new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa") },
                    { new Guid("366808ed-257d-4f2f-a9bd-9f1ee89634f7"), 17, "2 apples, quartered", new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1") },
                    { new Guid("6c6c2cc1-ca8d-421b-950e-eb1da4360723"), 19, "4 carrots", new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4") },
                    { new Guid("89f89bfc-4c0d-47a3-b906-3e6b20dab6da"), 30, "Oil for frying", new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa") },
                    { new Guid("988b3a09-78ce-4aaf-b8ce-adacbb924d85"), 12, "2 tablespoons sour cream", new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4") },
                    { new Guid("9ad78cda-3195-4c4c-99ae-ff137136e286"), 11, "1 1/4 cups milk", new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa") },
                    { new Guid("b6bd2f51-7112-45ce-8262-13d5726179f2"), 0, "2 teaspoons sugar (optional)", new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4") },
                    { new Guid("b7b0a5e0-e12c-45a9-a178-9f0438d272de"), 0, "A pinch of salt (tip of the teaspoon)", new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa") },
                    { new Guid("d9b8b7cb-07ae-4c7c-9eaf-65486ff43f87"), 17, "4 apples", new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4") },
                    { new Guid("e59827db-08e7-4689-99c5-d26ce518ee52"), 0, "2 stalks celery (optional)", new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1") }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "RecipeId", "Text" },
                values: new object[,]
                {
                    { new Guid("274fcb72-0725-49e8-b775-0c001372d482"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Sift the flour, sugar and salt, make a well in it." },
                    { new Guid("5c13ba4b-6300-4d34-b84b-8300721b2dcf"), new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4"), "Add sugar and sour cream. Mix everything thoroughly so that the sugar melts to the maximum." },
                    { new Guid("5ec3752b-4f7d-45b9-8f0c-989dd758be82"), new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4"), "Wash, peel and grate apples and carrots. Combine." },
                    { new Guid("77640578-7968-4721-a774-c79bcd1e1e40"), new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1"), "Add ginger to juicer and process (optional)." },
                    { new Guid("7f39378a-7755-4ad1-b701-2727920c5052"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Next, whisk in the rest of the milk and until you have a pancake batter that resembles the consistency of whipping cream." },
                    { new Guid("826cd39b-edcd-4769-b9cd-9d4680c308bf"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Serve with jam, sour cream, ice cream with berries and fruits - whatever you want!" },
                    { new Guid("8a321b24-7b13-4807-a299-04e60ada415a"), new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4"), "Serve the delicious salad to the table." },
                    { new Guid("a5da8c68-403b-40cd-8325-424009b6cc06"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Cook until the batter is no longer liquid." },
                    { new Guid("ad8d6900-badb-4746-8dc3-7b03ce619f9a"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Then pour on the pancake batter and quickly swirl it around." },
                    { new Guid("d5791a24-4d84-4262-af22-635043049c9c"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Add on a bit of oil, and quickly swirl it around the pan. Make sure your pan is evenly nice and hot before you start cooking the pancakes. If the pan isn't hot enough, the recipe won't work." },
                    { new Guid("dd5816ec-bc12-4228-8138-082ac70c55c3"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Then start whisking it all together (you can use a mixer)." },
                    { new Guid("e456b288-4e46-41dd-8b6e-07eea9cbd09e"), new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1"), "Run carrots, apples, (celery) through a juicer, alternating carrot, apple, and, optionally, celery, according to manufacturer's instructions." },
                    { new Guid("e9a4c056-3d48-4b6b-9070-abc81d7f0a9a"), new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"), "Crack in the eggs, add a bit of the milk." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("18e5133c-84ac-498c-9924-ed5e08c01a44"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1d8595c6-da01-4e73-9ebf-3ccf42a3c1ea"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2c7d1a2a-b690-4efb-86aa-87a7bdf87ff7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2d6d02aa-c040-49c2-8aec-669483276dd5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("31533188-2287-4470-adac-f4fb44636652"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("366808ed-257d-4f2f-a9bd-9f1ee89634f7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6c6c2cc1-ca8d-421b-950e-eb1da4360723"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("89f89bfc-4c0d-47a3-b906-3e6b20dab6da"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("988b3a09-78ce-4aaf-b8ce-adacbb924d85"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9ad78cda-3195-4c4c-99ae-ff137136e286"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b6bd2f51-7112-45ce-8262-13d5726179f2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b7b0a5e0-e12c-45a9-a178-9f0438d272de"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d9b8b7cb-07ae-4c7c-9eaf-65486ff43f87"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e59827db-08e7-4689-99c5-d26ce518ee52"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("274fcb72-0725-49e8-b775-0c001372d482"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("5c13ba4b-6300-4d34-b84b-8300721b2dcf"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("5ec3752b-4f7d-45b9-8f0c-989dd758be82"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("77640578-7968-4721-a774-c79bcd1e1e40"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("7f39378a-7755-4ad1-b701-2727920c5052"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("826cd39b-edcd-4769-b9cd-9d4680c308bf"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("8a321b24-7b13-4807-a299-04e60ada415a"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("a5da8c68-403b-40cd-8325-424009b6cc06"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("ad8d6900-badb-4746-8dc3-7b03ce619f9a"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("d5791a24-4d84-4262-af22-635043049c9c"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("dd5816ec-bc12-4228-8138-082ac70c55c3"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("e456b288-4e46-41dd-8b6e-07eea9cbd09e"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("e9a4c056-3d48-4b6b-9070-abc81d7f0a9a"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2d7d7bcb-3f3d-4919-9819-f5e22c6208d1"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba814dd8-3fd2-418c-8a79-153efbf866fa"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ed6cb38d-ac62-4a4f-936f-68a6bd750df4"));

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
        }
    }
}
