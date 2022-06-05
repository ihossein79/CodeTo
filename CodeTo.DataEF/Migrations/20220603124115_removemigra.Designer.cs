﻿// <auto-generated />
using System;
using CodeTo.DataEF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeTo.DataEF.Migrations
{
    [DbContext(typeof(CodeToContext))]
    [Migration("20220603124115_removemigra")]
    partial class removemigra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeTo.Domain.Entities.Articles.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ArticleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleTitle")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Writer")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Articles.ArticleComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<long?>("ArticleId1")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("ReaedAdmin")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId1");

                    b.HasIndex("UserId");

                    b.ToTable("ArticleComments");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Courses.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseImageName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("CoursePrice")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("CourseTitle")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tags")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Courses.CourseGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CourseGroups");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Permissions.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermissionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Users.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AvatarImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EmailActiveCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Wallets")
                        .HasColumnType("float");

                    b.Property<long>("WalletsId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Users.UserRole", b =>
                {
                    b.Property<int>("UR")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UR"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UR");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Wallet.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Ispay")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WalletTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WalletTypeId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Wallet.WalletType", b =>
                {
                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("TypeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("WalletTypes");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Articles.ArticleComment", b =>
                {
                    b.HasOne("CodeTo.Domain.Entities.Articles.Article", "Article")
                        .WithMany("ArticleComment")
                        .HasForeignKey("ArticleId1");

                    b.HasOne("CodeTo.Domain.Entities.Users.User", "User")
                        .WithMany("ArticleComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Courses.Course", b =>
                {
                    b.HasOne("CodeTo.Domain.Entities.Courses.CourseGroup", "CourseGroup")
                        .WithMany("Courses")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeTo.Domain.Entities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Permissions.RolePermission", b =>
                {
                    b.HasOne("CodeTo.Domain.Entities.Permissions.RolePermission", null)
                        .WithMany("Permissions")
                        .HasForeignKey("ParentId");

                    b.HasOne("CodeTo.Domain.Entities.Users.Role", "Roles")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Users.UserRole", b =>
                {
                    b.HasOne("CodeTo.Domain.Entities.Users.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeTo.Domain.Entities.Users.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Wallet.Wallet", b =>
                {
                    b.HasOne("CodeTo.Domain.Entities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeTo.Domain.Entities.Wallet.WalletType", "WalletType")
                        .WithMany("Wallets")
                        .HasForeignKey("WalletTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("WalletType");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Articles.Article", b =>
                {
                    b.Navigation("ArticleComment");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Courses.CourseGroup", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Permissions.RolePermission", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Users.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("ArticleComments");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CodeTo.Domain.Entities.Wallet.WalletType", b =>
                {
                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
