﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickQuestion.Domain;

#nullable disable

namespace QuickQuestion.Domain.Migrations
{
    [DbContext(typeof(QuickQuestionContext))]
    partial class QuickQuestionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuickQuestion.Domain.Model.Answer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("commetnId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("commetnId");

                    b.HasIndex("userId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetBlog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("assetType")
                        .HasColumnType("int");

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("blogId");

                    b.HasIndex("userId");

                    b.ToTable("AssetBlog");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("assetType")
                        .HasColumnType("int");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.HasIndex("userId");

                    b.ToTable("AssetCategory");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetComment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("answerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("assetType")
                        .HasColumnType("int");

                    b.Property<int>("commentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("answerId");

                    b.HasIndex("commentId");

                    b.ToTable("AssetComment");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("assetType")
                        .HasColumnType("int");

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("AssetUser");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Blog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("index")
                        .HasColumnType("int");

                    b.Property<string>("metaTags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.HasIndex("userId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.BlogTags", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("tagId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("blogId");

                    b.HasIndex("tagId");

                    b.ToTable("BlogTags");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("metaTags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("superId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("superId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.CommenTags", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("answerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("comentId")
                        .HasColumnType("int");

                    b.Property<int>("commentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("tagId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("answerId");

                    b.HasIndex("commentId");

                    b.HasIndex("tagId");

                    b.HasIndex("userId");

                    b.ToTable("CommenTags");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("blogId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("blogId");

                    b.HasIndex("userId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("id");

                    b.HasIndex("title")
                        .IsUnique();

                    b.ToTable("Role");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Tag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("title")
                        .IsUnique();

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("id");

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.UserRole", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.HasIndex("userId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Answer", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Comment", "comment")
                        .WithMany("answers")
                        .HasForeignKey("commetnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany("answers")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("comment");

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetBlog", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Blog", "blog")
                        .WithMany("assets")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blog");

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetCategory", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Category", "category")
                        .WithMany("assets")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetComment", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Answer", "answer")
                        .WithMany()
                        .HasForeignKey("answerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.Comment", "comment")
                        .WithMany("assetComments")
                        .HasForeignKey("commentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("answer");

                    b.Navigation("comment");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.AssetUser", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany("assets")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Blog", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.BlogTags", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Blog", "blog")
                        .WithMany("blogTags")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.Tag", "tag")
                        .WithMany("blogTags")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blog");

                    b.Navigation("tag");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Category", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Category", "super")
                        .WithMany("subs")
                        .HasForeignKey("superId");

                    b.Navigation("super");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.CommenTags", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Answer", "answer")
                        .WithMany("commenTsags")
                        .HasForeignKey("answerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.Comment", "comment")
                        .WithMany("commenTsags")
                        .HasForeignKey("commentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.Tag", "tag")
                        .WithMany("commenTsags")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("answer");

                    b.Navigation("comment");

                    b.Navigation("tag");

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Comment", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Blog", "blog")
                        .WithMany("comments")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany("comments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("blog");

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.UserRole", b =>
                {
                    b.HasOne("QuickQuestion.Domain.Model.Role", "role")
                        .WithMany("userRoles")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickQuestion.Domain.Model.User", "user")
                        .WithMany("userRoles")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Answer", b =>
                {
                    b.Navigation("commenTsags");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Blog", b =>
                {
                    b.Navigation("assets");

                    b.Navigation("blogTags");

                    b.Navigation("comments");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Category", b =>
                {
                    b.Navigation("assets");

                    b.Navigation("subs");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Comment", b =>
                {
                    b.Navigation("answers");

                    b.Navigation("assetComments");

                    b.Navigation("commenTsags");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Role", b =>
                {
                    b.Navigation("userRoles");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.Tag", b =>
                {
                    b.Navigation("blogTags");

                    b.Navigation("commenTsags");
                });

            modelBuilder.Entity("QuickQuestion.Domain.Model.User", b =>
                {
                    b.Navigation("answers");

                    b.Navigation("assets");

                    b.Navigation("comments");

                    b.Navigation("userRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
