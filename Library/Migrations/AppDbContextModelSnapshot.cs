﻿// <auto-generated />
using Library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "James",
                            LastName = "Bond"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Jackie",
                            LastName = "Chan"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Sylvester",
                            LastName = "Stallone"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Van",
                            LastName = "Damme"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Jet",
                            LastName = "Lee"
                        });
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Title = "Spectre"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Title = "Casino Royal"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Title = "007"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Title = "The spy who loved me"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            Title = "From russia with love"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            Title = "Die another day"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            Title = "Rush Hour"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 2,
                            Title = "Police story"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 2,
                            Title = "Who am I?"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 2,
                            Title = "The karate kid"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 2,
                            Title = "Drunken Master"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 3,
                            Title = "Rambo"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 3,
                            Title = "First Blood"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 3,
                            Title = "The expendables"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 3,
                            Title = "Escape plan"
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 3,
                            Title = "Judgment Day"
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = 4,
                            Title = "Hard Target"
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = 4,
                            Title = "Double Impact"
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = 4,
                            Title = "Universal Soldier"
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = 4,
                            Title = "Hard Way"
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = 4,
                            Title = "Street Fighter"
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = 4,
                            Title = "Bullet in the head"
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = 5,
                            Title = "The Black Mask"
                        },
                        new
                        {
                            Id = 24,
                            AuthorId = 5,
                            Title = "Romeo Must Die"
                        },
                        new
                        {
                            Id = 25,
                            AuthorId = 5,
                            Title = "Cradle to the grave"
                        },
                        new
                        {
                            Id = 26,
                            AuthorId = 5,
                            Title = "Once upon a time in China"
                        },
                        new
                        {
                            Id = 27,
                            AuthorId = 5,
                            Title = "Hero"
                        },
                        new
                        {
                            Id = 28,
                            AuthorId = 5,
                            Title = "Fearless"
                        },
                        new
                        {
                            Id = 29,
                            AuthorId = 5,
                            Title = "Fist of legend"
                        },
                        new
                        {
                            Id = 30,
                            AuthorId = 5,
                            Title = "The one"
                        },
                        new
                        {
                            Id = 31,
                            AuthorId = 5,
                            Title = "Unleashed"
                        });
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.HasOne("Library.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}