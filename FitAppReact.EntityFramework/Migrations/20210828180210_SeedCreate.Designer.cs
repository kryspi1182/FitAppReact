// <auto-generated />
using FitAppReact.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitAppReact.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210828180210_SeedCreate")]
    partial class SeedCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.Hazard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hazards");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MealCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recipe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MealCategoryId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MealCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MealCategories");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MealProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.HasIndex("ProductId");

                    b.ToTable("MealProducts");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MedicalCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalConditions");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MedicalConditionHazard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HazardId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalConditionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HazardId");

                    b.HasIndex("MedicalConditionId");

                    b.ToTable("MedicalConditionHazards");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Carbohydrates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Fat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Fibre")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Protein")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Salt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Sugar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 583m,
                            Carbohydrates = 6m,
                            Fat = 52m,
                            Fibre = 11m,
                            Name = "Almond",
                            Protein = 20m,
                            Salt = 0m,
                            Sugar = 3m
                        },
                        new
                        {
                            Id = 2,
                            Calories = 54m,
                            Carbohydrates = 12m,
                            Fat = 0m,
                            Fibre = 2m,
                            Name = "Apple",
                            Protein = 0m,
                            Salt = 0m,
                            Sugar = 12m
                        },
                        new
                        {
                            Id = 3,
                            Calories = 60m,
                            Carbohydrates = 12m,
                            Fat = 0m,
                            Fibre = 2m,
                            Name = "Apricot",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 8m
                        },
                        new
                        {
                            Id = 4,
                            Calories = 17m,
                            Carbohydrates = 1m,
                            Fat = 0m,
                            Fibre = 2m,
                            Name = "Aspargus",
                            Protein = 2m,
                            Salt = 0m,
                            Sugar = 1m
                        },
                        new
                        {
                            Id = 5,
                            Calories = 188m,
                            Carbohydrates = 2m,
                            Fat = 18m,
                            Fibre = 6m,
                            Name = "Avocado",
                            Protein = 3m,
                            Salt = 0m,
                            Sugar = 1m
                        },
                        new
                        {
                            Id = 6,
                            Calories = 86m,
                            Carbohydrates = 19m,
                            Fat = 0m,
                            Fibre = 2m,
                            Name = "Banana",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 18m
                        },
                        new
                        {
                            Id = 7,
                            Calories = 114m,
                            Carbohydrates = 15m,
                            Fat = 1m,
                            Fibre = 11m,
                            Name = "Beans(white)",
                            Protein = 8m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 8,
                            Calories = 198m,
                            Carbohydrates = 1m,
                            Fat = 9m,
                            Fibre = 0m,
                            Name = "Beef",
                            Protein = 30m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 9,
                            Calories = 58m,
                            Carbohydrates = 9m,
                            Fat = 1m,
                            Fibre = 5m,
                            Name = "Blackberry",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 7m
                        },
                        new
                        {
                            Id = 10,
                            Calories = 75m,
                            Carbohydrates = 15m,
                            Fat = 0m,
                            Fibre = 7m,
                            Name = "Berry",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 14m
                        },
                        new
                        {
                            Id = 11,
                            Calories = 283m,
                            Carbohydrates = 58m,
                            Fat = 2m,
                            Fibre = 4m,
                            Name = "Bread(white)",
                            Protein = 8m,
                            Salt = 0m,
                            Sugar = 2m
                        },
                        new
                        {
                            Id = 12,
                            Calories = 262m,
                            Carbohydrates = 45m,
                            Fat = 3m,
                            Fibre = 6m,
                            Name = "Bread(whole wheat)",
                            Protein = 10m,
                            Salt = 0m,
                            Sugar = 2m
                        },
                        new
                        {
                            Id = 13,
                            Calories = 29m,
                            Carbohydrates = 2m,
                            Fat = 0m,
                            Fibre = 4m,
                            Name = "Broccoli",
                            Protein = 3m,
                            Salt = 0m,
                            Sugar = 2m
                        },
                        new
                        {
                            Id = 14,
                            Calories = 25m,
                            Carbohydrates = 3m,
                            Fat = 0m,
                            Fibre = 5m,
                            Name = "Brussels",
                            Protein = 3m,
                            Salt = 0m,
                            Sugar = 3m
                        },
                        new
                        {
                            Id = 15,
                            Calories = 375m,
                            Carbohydrates = 80m,
                            Fat = 1m,
                            Fibre = 2m,
                            Name = "Bulgur groats",
                            Protein = 10m,
                            Salt = 0m,
                            Sugar = 2m
                        },
                        new
                        {
                            Id = 16,
                            Calories = 735m,
                            Carbohydrates = 1m,
                            Fat = 83m,
                            Fibre = 0m,
                            Name = "Butter",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 1m
                        },
                        new
                        {
                            Id = 17,
                            Calories = 27m,
                            Carbohydrates = 5m,
                            Fat = 0m,
                            Fibre = 3m,
                            Name = "Carrot",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 4m
                        },
                        new
                        {
                            Id = 18,
                            Calories = 20m,
                            Carbohydrates = 2m,
                            Fat = 0m,
                            Fibre = 2m,
                            Name = "Califlower",
                            Protein = 2m,
                            Salt = 0m,
                            Sugar = 2m
                        },
                        new
                        {
                            Id = 19,
                            Calories = 157m,
                            Carbohydrates = 0m,
                            Fat = 4m,
                            Fibre = 0m,
                            Name = "Chicken breast",
                            Protein = 30m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 20,
                            Calories = 103m,
                            Carbohydrates = 0m,
                            Fat = 2m,
                            Fibre = 0m,
                            Name = "Chicken leg",
                            Protein = 21m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 21,
                            Calories = 354m,
                            Carbohydrates = 66m,
                            Fat = 4m,
                            Fibre = 9m,
                            Name = "Corn",
                            Protein = 9m,
                            Salt = 0m,
                            Sugar = 2m
                        },
                        new
                        {
                            Id = 22,
                            Calories = 225m,
                            Carbohydrates = 0m,
                            Fat = 17m,
                            Fibre = 0m,
                            Name = "Duck",
                            Protein = 18m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 23,
                            Calories = 235m,
                            Carbohydrates = 1m,
                            Fat = 20m,
                            Fibre = 0m,
                            Name = "Eggs",
                            Protein = 14m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 24,
                            Calories = 247m,
                            Carbohydrates = 18m,
                            Fat = 12m,
                            Fibre = 2m,
                            Name = "Fish sticks",
                            Protein = 15m,
                            Salt = 0m,
                            Sugar = 1m
                        },
                        new
                        {
                            Id = 25,
                            Calories = 307m,
                            Carbohydrates = 46m,
                            Fat = 11m,
                            Fibre = 3m,
                            Name = "French fries",
                            Protein = 6m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 26,
                            Calories = 57m,
                            Carbohydrates = 14m,
                            Fat = 0m,
                            Fibre = 1m,
                            Name = "Grapes",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 13m
                        },
                        new
                        {
                            Id = 27,
                            Calories = 201m,
                            Carbohydrates = 1m,
                            Fat = 13m,
                            Fibre = 0m,
                            Name = "Ham",
                            Protein = 22m,
                            Salt = 0m,
                            Sugar = 1m
                        },
                        new
                        {
                            Id = 28,
                            Calories = 667m,
                            Carbohydrates = 11m,
                            Fat = 63m,
                            Fibre = 8m,
                            Name = "Hazelnut",
                            Protein = 14m,
                            Salt = 0m,
                            Sugar = 9m
                        },
                        new
                        {
                            Id = 29,
                            Calories = 308m,
                            Carbohydrates = 76m,
                            Fat = 0m,
                            Fibre = 0m,
                            Name = "Honey",
                            Protein = 0m,
                            Salt = 0m,
                            Sugar = 75m
                        },
                        new
                        {
                            Id = 30,
                            Calories = 247m,
                            Carbohydrates = 60m,
                            Fat = 0m,
                            Fibre = 2m,
                            Name = "Jam",
                            Protein = 0m,
                            Salt = 0m,
                            Sugar = 59m
                        },
                        new
                        {
                            Id = 31,
                            Calories = 116m,
                            Carbohydrates = 1m,
                            Fat = 5m,
                            Fibre = 0m,
                            Name = "Kidneys(pork)",
                            Protein = 17m,
                            Salt = 0m,
                            Sugar = 0m
                        },
                        new
                        {
                            Id = 32,
                            Calories = 48m,
                            Carbohydrates = 10m,
                            Fat = 0m,
                            Fibre = 1m,
                            Name = "Kiwi",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 8m
                        },
                        new
                        {
                            Id = 33,
                            Calories = 11m,
                            Carbohydrates = 1m,
                            Fat = 0m,
                            Fibre = 1m,
                            Name = "Lettuce",
                            Protein = 1m,
                            Salt = 0m,
                            Sugar = 1m
                        },
                        new
                        {
                            Id = 34,
                            Calories = 132m,
                            Carbohydrates = 2m,
                            Fat = 4m,
                            Fibre = 0m,
                            Name = "Liver(pork)",
                            Protein = 22m,
                            Salt = 0m,
                            Sugar = 2m
                        },
                        new
                        {
                            Id = 35,
                            Calories = 741m,
                            Carbohydrates = 3m,
                            Fat = 82m,
                            Fibre = 0m,
                            Name = "Mayonese",
                            Protein = 2m,
                            Salt = 0m,
                            Sugar = 3m
                        },
                        new
                        {
                            Id = 36,
                            Calories = 62m,
                            Carbohydrates = 4m,
                            Fat = 3m,
                            Fibre = 0m,
                            Name = "Milk",
                            Protein = 4m,
                            Salt = 0m,
                            Sugar = 4m
                        },
                        new
                        {
                            Id = 37,
                            Calories = 359m,
                            Carbohydrates = 80m,
                            Fat = 1m,
                            Fibre = 0m,
                            Name = "Rice",
                            Protein = 8m,
                            Salt = 0m,
                            Sugar = 0m
                        });
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.ProductHazard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HazardId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HazardId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductHazards");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.Meal", b =>
                {
                    b.HasOne("FitAppReact.EntityFramework.Models.MealCategory", "MealCategory")
                        .WithMany("Meals")
                        .HasForeignKey("MealCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MealCategory");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MealProduct", b =>
                {
                    b.HasOne("FitAppReact.EntityFramework.Models.Meal", "Meal")
                        .WithMany("MealProducts")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitAppReact.EntityFramework.Models.Product", "Product")
                        .WithMany("MealProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MedicalConditionHazard", b =>
                {
                    b.HasOne("FitAppReact.EntityFramework.Models.Hazard", "Hazard")
                        .WithMany("MedicalConditionHazards")
                        .HasForeignKey("HazardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitAppReact.EntityFramework.Models.MedicalCondition", "MedicalCondition")
                        .WithMany("MedicalConditionHazards")
                        .HasForeignKey("MedicalConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hazard");

                    b.Navigation("MedicalCondition");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.ProductHazard", b =>
                {
                    b.HasOne("FitAppReact.EntityFramework.Models.Hazard", "Hazard")
                        .WithMany()
                        .HasForeignKey("HazardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitAppReact.EntityFramework.Models.Product", "Product")
                        .WithMany("ProductHazards")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hazard");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.Hazard", b =>
                {
                    b.Navigation("MedicalConditionHazards");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.Meal", b =>
                {
                    b.Navigation("MealProducts");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MealCategory", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.MedicalCondition", b =>
                {
                    b.Navigation("MedicalConditionHazards");
                });

            modelBuilder.Entity("FitAppReact.EntityFramework.Models.Product", b =>
                {
                    b.Navigation("MealProducts");

                    b.Navigation("ProductHazards");
                });
#pragma warning restore 612, 618
        }
    }
}
