﻿// <auto-generated />
using BlazorEcomerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcomerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230214190736_FeaturedProducts")]
    partial class FeaturedProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcomerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Games",
                            Url = "games"
                        });
                });

            modelBuilder.Entity("BlazorEcomerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Birds of America (1998) is a collection of short stories by American writer Lorrie Moore. The stories in this collection originally appeared in The New Yorker, Elle, The New York Times, and The Paris Review. The story \"People Like That Are the Only People Here\" won an O. Henry Award in 1998. The book became a New York Times bestseller, a rarity for a short story collection. The book was included in the New York Times Book Review books of the year list in 1998.[1] Winner of the Irish Times international fiction prize. A Village Voice book of the year (1998). Winner of the Salon Book Award.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg",
                            Title = "Birds of America"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "The eight stories of this collection (one of which was originally published in Saturday Night; five others were originally published in The New Yorker) deal with Munro's typical themes: secrets, love, betrayal, and the stuff of ordinary lives.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8c/TheLoveOfAGoodWoman.jpg",
                            Title = "The Love of a Good Woman"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Its principal characters are married zoologists Joseph and Celice and their daughter Syl. The story tells of how Joseph and Celice, on a day trip to the dunes where they met as students, are murdered by an opportunistic thief. Their bodies lie undiscovered for several days, during the course of which their estranged daughter is made aware of their disappearance and, eventually, discovery. The novel dwells heavily on the themes of bodily decomposition and filial bereavement.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg",
                            Title = "Being Dead"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Title = "Back to the Future"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Title = "Toy Story"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Title = "Diablo II"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Title = "Day of the Tentacle"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Title = "Xbox"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Title = "Super Nintendo Entertainment System"
                        });
                });

            modelBuilder.Entity("BlazorEcomerce.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Stream"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Blu-ray"
                        },
                        new
                        {
                            Id = 7,
                            Name = "VHS"
                        },
                        new
                        {
                            Id = 8,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 9,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("BlazorEcomerce.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 6,
                            OriginalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 7,
                            OriginalPrice = 0m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 2.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 8,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 9,
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 10,
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 8,
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 8,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 10,
                            ProductTypeId = 1,
                            OriginalPrice = 299m,
                            Price = 159.99m
                        },
                        new
                        {
                            ProductId = 11,
                            ProductTypeId = 1,
                            OriginalPrice = 399m,
                            Price = 79.99m
                        });
                });

            modelBuilder.Entity("BlazorEcomerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcomerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorEcomerce.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazorEcomerce.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcomerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorEcomerce.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
