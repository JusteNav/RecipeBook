using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Data.Migrations.Recipe
{
    public partial class ChangedPropertyNullability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("12de0782-1326-4833-b880-2c78c227e865"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("184099bb-f53d-430e-af9b-4e958164648b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("253dfe83-31f3-4c5e-b889-a5b040ba78dc"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3207a492-7363-488c-8f00-5bdc7c9a1d06"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("32871c20-1f8b-4e07-a04f-5d8588622f3a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3c105878-3d07-4161-8e98-bbb7047dbc15"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("40c1cabe-662e-4396-b427-438156414543"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("47e27257-2b20-4c14-abba-b31891a311f6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("607b7d3c-b8a7-4f59-a8f5-b245eb32b1d3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("93922a19-a493-4890-8c67-03403eccd8bd"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bc35dbf7-0d0a-4139-8d2d-7556ff27b99a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bd22c6d0-2199-46b7-9557-8fb712eb6b6c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d38cc040-485b-4d51-b8cf-66dbb5afc539"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d5cfeedd-bee5-4388-9052-83d358e19e41"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("2bc1807a-7e4f-45c1-b8a9-430f268b4f68"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("4254593a-c9c9-4aec-8a63-30330fd0380b"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("66dfebf1-50cd-4e06-bc8d-e241ba44f698"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("6d4a1581-6a1e-4df8-acfe-c4dffeb31957"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("a3b6b9d9-27af-4390-82ee-5f4f0adadca8"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("b2875423-e702-4b54-8146-6d1f7a99b3fe"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("c6f6a57f-9305-4682-a0bf-4808787ab3f6"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("ccb229c5-3a20-4a66-b211-a1ce5355fcbd"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("d1cbf335-e0b8-4303-b4d5-4f3b5ac4d662"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("d47ac5c6-e742-41d6-9dae-d4ceeb05e5a6"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("d588310a-5356-4917-9a42-5c90b2c19499"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("e3996a19-ba8f-4a45-8636-e6dc99d7f5bb"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("f6487049-e109-41f3-a6b4-e3fa4470092e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("281c116e-72cb-4f7f-99e9-f4abf386948e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("cd4a8f40-17ba-48b7-8239-b93dfaacb437"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("e56df0f6-269e-4863-9bcd-60f6ec941ace"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
