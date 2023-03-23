using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickQuestion.Domain.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    metaTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    superId = table.Column<int>(type: "int", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                    table.ForeignKey(
                        name: "FK_Category_Category_superId",
                        column: x => x.superId,
                        principalTable: "Category",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    email = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    password = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AssetCategory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    assetType = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetCategory", x => x.id);
                    table.ForeignKey(
                        name: "FK_AssetCategory_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_AssetCategory_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetUser",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    blogId = table.Column<int>(type: "int", nullable: false),
                    assetType = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetUser", x => x.id);
                    table.ForeignKey(
                        name: "FK_AssetUser_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    index = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    metaTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.id);
                    table.ForeignKey(
                        name: "FK_Blog_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blog_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_roleId",
                        column: x => x.roleId,
                        principalTable: "Role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetBlog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    blogId = table.Column<int>(type: "int", nullable: false),
                    assetType = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetBlog", x => x.id);
                    table.ForeignKey(
                        name: "FK_AssetBlog_Blog_blogId",
                        column: x => x.blogId,
                        principalTable: "Blog",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetBlog_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blogId = table.Column<int>(type: "int", nullable: false),
                    tagId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlogTags_Blog_blogId",
                        column: x => x.blogId,
                        principalTable: "Blog",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_BlogTags_Tag_tagId",
                        column: x => x.tagId,
                        principalTable: "Tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blogId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    description = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comment_Blog_blogId",
                        column: x => x.blogId,
                        principalTable: "Blog",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commetnId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.id);
                    table.ForeignKey(
                        name: "FK_Answer_Comment_commetnId",
                        column: x => x.commetnId,
                        principalTable: "Comment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answer_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetComment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    commentId = table.Column<int>(type: "int", nullable: false),
                    answerId = table.Column<int>(type: "int", nullable: false),
                    assetType = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetComment", x => x.id);
                    table.ForeignKey(
                        name: "FK_AssetComment_Answer_answerId",
                        column: x => x.answerId,
                        principalTable: "Answer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetComment_Comment_commentId",
                        column: x => x.commentId,
                        principalTable: "Comment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommenTags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comentId = table.Column<int>(type: "int", nullable: false),
                    answerId = table.Column<int>(type: "int", nullable: false),
                    tagId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    commentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommenTags", x => x.id);
                    table.ForeignKey(
                        name: "FK_CommenTags_Answer_answerId",
                        column: x => x.answerId,
                        principalTable: "Answer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommenTags_Comment_commentId",
                        column: x => x.commentId,
                        principalTable: "Comment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommenTags_Tag_tagId",
                        column: x => x.tagId,
                        principalTable: "Tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommenTags_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_commetnId",
                table: "Answer",
                column: "commetnId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_userId",
                table: "Answer",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetBlog_blogId",
                table: "AssetBlog",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetBlog_userId",
                table: "AssetBlog",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategory_categoryId",
                table: "AssetCategory",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategory_userId",
                table: "AssetCategory",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetComment_answerId",
                table: "AssetComment",
                column: "answerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetComment_commentId",
                table: "AssetComment",
                column: "commentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetUser_userId",
                table: "AssetUser",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_categoryId",
                table: "Blog",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_userId",
                table: "Blog",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_blogId",
                table: "BlogTags",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_tagId",
                table: "BlogTags",
                column: "tagId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_superId",
                table: "Category",
                column: "superId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_blogId",
                table: "Comment",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_userId",
                table: "Comment",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_CommenTags_answerId",
                table: "CommenTags",
                column: "answerId");

            migrationBuilder.CreateIndex(
                name: "IX_CommenTags_commentId",
                table: "CommenTags",
                column: "commentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommenTags_tagId",
                table: "CommenTags",
                column: "tagId");

            migrationBuilder.CreateIndex(
                name: "IX_CommenTags_userId",
                table: "CommenTags",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_title",
                table: "Role",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_title",
                table: "Tag",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_email",
                table: "User",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_roleId",
                table: "UserRole",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_userId",
                table: "UserRole",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetBlog");

            migrationBuilder.DropTable(
                name: "AssetCategory");

            migrationBuilder.DropTable(
                name: "AssetComment");

            migrationBuilder.DropTable(
                name: "AssetUser");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "CommenTags");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
