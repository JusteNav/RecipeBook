﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBook.Data;

#nullable disable

namespace RecipeBook.Data.Migrations.Recipe
{
    [DbContext(typeof(RecipeContext))]
    partial class RecipeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RecipeBook.Data.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Category")
                        .HasColumnType("int");

                    b.Property<string>("FullTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("01b76963-6e0e-4765-adcc-c335e276a44c"),
                            Category = 1,
                            FullTitle = "1 cup flour",
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354")
                        },
                        new
                        {
                            Id = new Guid("a26b0c90-9cdc-42fd-8b6e-6ce906658315"),
                            Category = 6,
                            FullTitle = "2 eggs",
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354")
                        },
                        new
                        {
                            Id = new Guid("7574c4fd-cf7a-4d26-a0c2-4b449c30a2e3"),
                            Category = 11,
                            FullTitle = "1 1/4 cups milk",
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354")
                        },
                        new
                        {
                            Id = new Guid("68146913-6775-4331-95dc-e530953405e9"),
                            Category = 28,
                            FullTitle = "1 teaspoon sugar",
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354")
                        },
                        new
                        {
                            Id = new Guid("26bc0fee-8d45-4bb4-9d6f-2681e2e66802"),
                            Category = 0,
                            FullTitle = "A pinch of salt (tip of the teaspoon)",
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354")
                        },
                        new
                        {
                            Id = new Guid("d978e875-4c04-4c21-8def-cb525d765056"),
                            Category = 30,
                            FullTitle = "Oil for frying",
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354")
                        },
                        new
                        {
                            Id = new Guid("0cd168b2-0a27-4559-ba94-ed9ea209891a"),
                            Category = 17,
                            FullTitle = "4 apples",
                            RecipeId = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7")
                        },
                        new
                        {
                            Id = new Guid("ba406563-d1e2-4b12-b45b-f6cf822340c8"),
                            Category = 19,
                            FullTitle = "4 carrots",
                            RecipeId = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7")
                        },
                        new
                        {
                            Id = new Guid("5f11ea85-70f6-454d-b0ec-d0a1ad3c7fda"),
                            Category = 12,
                            FullTitle = "2 tablespoons sour cream",
                            RecipeId = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7")
                        },
                        new
                        {
                            Id = new Guid("6d3857a7-4e01-411f-9af9-773b0e64a1fe"),
                            Category = 0,
                            FullTitle = "2 teaspoons sugar (optional)",
                            RecipeId = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7")
                        },
                        new
                        {
                            Id = new Guid("70bcf310-88cf-4c7b-ba41-ae624096f0d5"),
                            Category = 19,
                            FullTitle = "4 carrots, trimmed",
                            RecipeId = new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068")
                        },
                        new
                        {
                            Id = new Guid("fc9b5e66-f2c6-4567-9399-e409bc0bbf98"),
                            Category = 17,
                            FullTitle = "2 apples, quartered",
                            RecipeId = new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068")
                        },
                        new
                        {
                            Id = new Guid("696996e4-013e-4433-8f6a-5e355bcae47b"),
                            Category = 0,
                            FullTitle = "2 stalks celery (optional)",
                            RecipeId = new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068")
                        },
                        new
                        {
                            Id = new Guid("c0974234-ebdd-414b-b74f-eb38f8e70485"),
                            Category = 0,
                            FullTitle = "1,5 cm piece of fresh ginger (optional)",
                            RecipeId = new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068")
                        });
                });

            modelBuilder.Entity("RecipeBook.Data.Models.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            Category = 2,
                            Note = "I always pour on the pancake batter using a measuring cup, so I end up with consistently-sized pancakes.",
                            PictureTitle = "1",
                            Title = "Thin Pancakes"
                        },
                        new
                        {
                            Id = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"),
                            Category = 0,
                            Note = "If you won't immediately consume the salad, spray it with a little bit of lemon juice and leave it in the fridge. Consume the same day though.",
                            PictureTitle = "2",
                            Title = "Apple and Carrot Salad"
                        },
                        new
                        {
                            Id = new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068"),
                            Category = 4,
                            PictureTitle = "6",
                            Title = "Carrot and Apple Juice"
                        });
                });

            modelBuilder.Entity("RecipeBook.Data.Models.Step", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StepNumber")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Steps");

                    b.HasData(
                        new
                        {
                            Id = new Guid("071f527d-cfcf-4445-94c1-309998365317"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 1,
                            Text = "Sift the flour, sugar and salt, make a well in it."
                        },
                        new
                        {
                            Id = new Guid("022fb291-ec19-4261-b7aa-933410d76069"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 2,
                            Text = "Crack in the eggs, add a bit of the milk."
                        },
                        new
                        {
                            Id = new Guid("2391ba7b-dcce-47b9-bd38-a8eab81d0a49"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 3,
                            Text = "Then start whisking it all together (you can use a mixer)."
                        },
                        new
                        {
                            Id = new Guid("a310b8c2-af8d-45d9-b2fd-83b5c3ffb9b5"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 4,
                            Text = "Next, whisk in the rest of the milk and until you have a pancake batter that resembles the consistency of whipping cream."
                        },
                        new
                        {
                            Id = new Guid("67c0da83-dd60-4228-aa91-b272e01d3fa0"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 5,
                            Text = "Add on a bit of oil, and quickly swirl it around the pan. Make sure your pan is evenly nice and hot before you start cooking the pancakes. If the pan isn't hot enough, the recipe won't work."
                        },
                        new
                        {
                            Id = new Guid("21f29c19-20bd-4fbc-aa6e-47e3c70e7d9a"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 6,
                            Text = "Then pour on the pancake batter and quickly swirl it around."
                        },
                        new
                        {
                            Id = new Guid("5e47dee5-4d04-4e1e-84f3-db8c66c4f5b4"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 7,
                            Text = "Cook until the batter is no longer liquid."
                        },
                        new
                        {
                            Id = new Guid("0a1261db-a9cf-4981-9667-4a911ef127a2"),
                            RecipeId = new Guid("79cd9fae-8d92-455b-aef7-f5f52d013354"),
                            StepNumber = 8,
                            Text = "Serve with jam, sour cream, ice cream with berries and fruits - whatever you want!"
                        },
                        new
                        {
                            Id = new Guid("5c5de2a1-fb50-4e85-b471-ab8735d46cc7"),
                            RecipeId = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"),
                            StepNumber = 1,
                            Text = "Wash, peel and grate apples and carrots. Combine."
                        },
                        new
                        {
                            Id = new Guid("34c34a0b-3fc1-46f8-9c59-9948f508c923"),
                            RecipeId = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"),
                            StepNumber = 2,
                            Text = "Add sugar and sour cream. Mix everything thoroughly so that the sugar melts to the maximum."
                        },
                        new
                        {
                            Id = new Guid("b02e069e-8987-45d0-ab55-8f7cfad5caa3"),
                            RecipeId = new Guid("c0b7d8c2-7e8e-4e4b-906f-b132250cd9c7"),
                            StepNumber = 3,
                            Text = "Serve the delicious salad to the table."
                        },
                        new
                        {
                            Id = new Guid("af1e87cc-3591-433e-9534-d20374f68f32"),
                            RecipeId = new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068"),
                            StepNumber = 1,
                            Text = "Run carrots, apples, (celery) through a juicer, alternating carrot, apple, and, optionally, celery, according to manufacturer's instructions."
                        },
                        new
                        {
                            Id = new Guid("0cc4f581-6810-47d9-a593-f651cb88b7d1"),
                            RecipeId = new Guid("7f61bf9f-677b-49df-8327-a61b11eb9068"),
                            StepNumber = 2,
                            Text = "Add ginger to juicer and process (optional)."
                        });
                });

            modelBuilder.Entity("RecipeBook.Data.Models.Ingredient", b =>
                {
                    b.HasOne("RecipeBook.Data.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBook.Data.Models.Step", b =>
                {
                    b.HasOne("RecipeBook.Data.Models.Recipe", "Recipe")
                        .WithMany("Steps")
                        .HasForeignKey("RecipeId");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBook.Data.Models.Recipe", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Steps");
                });
#pragma warning restore 612, 618
        }
    }
}
