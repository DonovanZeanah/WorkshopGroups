﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkshopGroup.Data;

#nullable disable

namespace WorkshopGroup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactWebModels.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ContactWebModels.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplyOwnerOwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplyOwnerSupplyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("SupplyOwnerSupplyId", "SupplyOwnerOwnerId");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("ContactWebModels.Supply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplyCategoryCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplyCategorySupplyId")
                        .HasColumnType("int");

                    b.Property<int>("SupplyId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplyOwnerOwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplyOwnerSupplyId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SupplyCategorySupplyId", "SupplyCategoryCategoryId");

                    b.HasIndex("SupplyOwnerSupplyId", "SupplyOwnerOwnerId");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("ContactWebModels.SupplyCategory", b =>
                {
                    b.Property<int>("SupplyId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("SupplyCategoryId")
                        .HasColumnType("int");

                    b.HasKey("SupplyId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SupplyCategories");
                });

            modelBuilder.Entity("ContactWebModels.SupplyOwner", b =>
                {
                    b.Property<int>("SupplyId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("SupplyOwnerId")
                        .HasColumnType("int");

                    b.HasKey("SupplyId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("SupplyOwners");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginProvider", "ProviderKey", "UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("ProjectTool", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.Property<int>("ToolsId")
                        .HasColumnType("int");

                    b.HasKey("ProjectsId", "ToolsId");

                    b.HasIndex("ToolsId");

                    b.ToTable("ProjectTool");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("WorkshopGroup.Models.AppUser", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<double?>("Points")
                        .HasColumnType("float");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("AddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplyCategoryCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplyCategorySupplyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SupplyCategorySupplyId", "SupplyCategoryCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WorkshopGroup.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClubCategory")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ToolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToolId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InitialCost")
                        .HasColumnType("int");

                    b.Property<int>("ProjectCategory")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<int>("SupplyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("SupplyId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Reviewers");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("WorkshopGroup.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Tool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("ContactWebModels.Owner", b =>
                {
                    b.HasOne("ContactWebModels.Country", "Country")
                        .WithMany("Owners")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContactWebModels.SupplyOwner", null)
                        .WithMany("Owners")
                        .HasForeignKey("SupplyOwnerSupplyId", "SupplyOwnerOwnerId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ContactWebModels.Supply", b =>
                {
                    b.HasOne("ContactWebModels.SupplyCategory", null)
                        .WithMany("Supplies")
                        .HasForeignKey("SupplyCategorySupplyId", "SupplyCategoryCategoryId");

                    b.HasOne("ContactWebModels.SupplyOwner", null)
                        .WithMany("Supplies")
                        .HasForeignKey("SupplyOwnerSupplyId", "SupplyOwnerOwnerId");
                });

            modelBuilder.Entity("ContactWebModels.SupplyCategory", b =>
                {
                    b.HasOne("WorkshopGroup.Models.Category", "Category")
                        .WithMany("SupplyCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContactWebModels.Supply", "Supply")
                        .WithMany("SupplyCategories")
                        .HasForeignKey("SupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("ContactWebModels.SupplyOwner", b =>
                {
                    b.HasOne("ContactWebModels.Owner", "Owner")
                        .WithMany("SupplyOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContactWebModels.Supply", "Supply")
                        .WithMany("SupplyOwners")
                        .HasForeignKey("SupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("ProjectTool", b =>
                {
                    b.HasOne("WorkshopGroup.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkshopGroup.Models.Tool", null)
                        .WithMany()
                        .HasForeignKey("ToolsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkshopGroup.Models.AppUser", b =>
                {
                    b.HasOne("WorkshopGroup.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Category", b =>
                {
                    b.HasOne("ContactWebModels.SupplyCategory", null)
                        .WithMany("Categories")
                        .HasForeignKey("SupplyCategorySupplyId", "SupplyCategoryCategoryId");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Club", b =>
                {
                    b.HasOne("WorkshopGroup.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("WorkshopGroup.Models.AppUser", "AppUser")
                        .WithMany("Clubs")
                        .HasForeignKey("AppUserId");

                    b.Navigation("Address");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Material", b =>
                {
                    b.HasOne("WorkshopGroup.Models.Tool", null)
                        .WithMany("Materials")
                        .HasForeignKey("ToolId");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Project", b =>
                {
                    b.HasOne("WorkshopGroup.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkshopGroup.Models.AppUser", "AppUser")
                        .WithMany("Projects")
                        .HasForeignKey("AppUserId");

                    b.Navigation("Address");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Rating", b =>
                {
                    b.HasOne("WorkshopGroup.Models.Skill", "Skill")
                        .WithMany("Ratings")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Review", b =>
                {
                    b.HasOne("WorkshopGroup.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("WorkshopGroup.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId");

                    b.HasOne("ContactWebModels.Supply", "Supply")
                        .WithMany("Reviews")
                        .HasForeignKey("SupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Reviewer");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Reviewer", b =>
                {
                    b.HasOne("WorkshopGroup.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("WorkshopGroup.Models.Review", null)
                        .WithMany("Reviewers")
                        .HasForeignKey("ReviewId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Skill", b =>
                {
                    b.HasOne("WorkshopGroup.Models.AppUser", "AppUser")
                        .WithMany("Skills")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Tool", b =>
                {
                    b.HasOne("WorkshopGroup.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("ContactWebModels.Country", b =>
                {
                    b.Navigation("Owners");
                });

            modelBuilder.Entity("ContactWebModels.Owner", b =>
                {
                    b.Navigation("SupplyOwners");
                });

            modelBuilder.Entity("ContactWebModels.Supply", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("SupplyCategories");

                    b.Navigation("SupplyOwners");
                });

            modelBuilder.Entity("ContactWebModels.SupplyCategory", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("ContactWebModels.SupplyOwner", b =>
                {
                    b.Navigation("Owners");

                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("WorkshopGroup.Models.AppUser", b =>
                {
                    b.Navigation("Clubs");

                    b.Navigation("Projects");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Category", b =>
                {
                    b.Navigation("SupplyCategories");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Review", b =>
                {
                    b.Navigation("Reviewers");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Skill", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("WorkshopGroup.Models.Tool", b =>
                {
                    b.Navigation("Materials");
                });
#pragma warning restore 612, 618
        }
    }
}
