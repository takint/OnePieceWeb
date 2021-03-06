﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnePiece.Web.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "AnimeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeCategories_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaSeasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaSeasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangaSeasons_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusicVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlternativeLink = table.Column<string>(nullable: true),
                    AspectRatio = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    VideoQuality = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicVideos_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewsFeeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActived = table.Column<bool>(nullable: false),
                    LinkToId = table.Column<int>(nullable: true),
                    LinkToTarget = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsFeeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsFeeds_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspectRatio = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Poster = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimeSeasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnimeCategoryId = table.Column<int>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeSeasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeSeasons_AnimeCategories_AnimeCategoryId",
                        column: x => x.AnimeCategoryId,
                        principalTable: "AnimeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimeSeasons_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleCategoryId = table.Column<int>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActived = table.Column<bool>(nullable: false),
                    PublishedDate = table.Column<DateTime>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalTable: "ArticleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaChapters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MangaSeasonId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    PublishedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaChapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangaChapters_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaChapters_MangaSeasons_MangaSeasonId",
                        column: x => x.MangaSeasonId,
                        principalTable: "MangaSeasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlternativeGifLink = table.Column<string>(nullable: true),
                    AlternativeLink = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GifLink = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    ImageType = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NewsFeedId = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_NewsFeeds_NewsFeedId",
                        column: x => x.NewsFeedId,
                        principalTable: "NewsFeeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimeEpisodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnimeSeasonId = table.Column<int>(nullable: false),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    PublishedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeEpisodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeEpisodes_AnimeSeasons_AnimeSeasonId",
                        column: x => x.AnimeSeasonId,
                        principalTable: "AnimeSeasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeEpisodes_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangaImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlternativeLink = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    MangaChapterId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangaImages_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangaImages_MangaChapters_MangaChapterId",
                        column: x => x.MangaChapterId,
                        principalTable: "MangaChapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlternativeLink = table.Column<string>(nullable: true),
                    AnimeEpisodeId = table.Column<int>(nullable: false),
                    AspectRatio = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Poster = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    VideoQuality = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeVideos_AnimeEpisodes_AnimeEpisodeId",
                        column: x => x.AnimeEpisodeId,
                        principalTable: "AnimeEpisodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeVideos_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnimeVideoId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    IsMainLink = table.Column<bool>(nullable: false),
                    LinkType = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    VideoId = table.Column<int>(nullable: true),
                    VideoQuality = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoLinks_AnimeVideos_AnimeVideoId",
                        column: x => x.AnimeVideoId,
                        principalTable: "AnimeVideos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VideoLinks_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VideoLinks_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnimeCategories_CreatedUserId",
                table: "AnimeCategories",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeEpisodes_AnimeSeasonId",
                table: "AnimeEpisodes",
                column: "AnimeSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeEpisodes_CreatedUserId",
                table: "AnimeEpisodes",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeSeasons_AnimeCategoryId",
                table: "AnimeSeasons",
                column: "AnimeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeSeasons_CreatedUserId",
                table: "AnimeSeasons",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeVideos_AnimeEpisodeId",
                table: "AnimeVideos",
                column: "AnimeEpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeVideos_CreatedUserId",
                table: "AnimeVideos",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CreatedUserId",
                table: "Articles",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_CreatedUserId",
                table: "ArticleCategories",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CreatedUserId",
                table: "Images",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_NewsFeedId",
                table: "Images",
                column: "NewsFeedId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapters_CreatedUserId",
                table: "MangaChapters",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapters_MangaSeasonId",
                table: "MangaChapters",
                column: "MangaSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaImages_CreatedUserId",
                table: "MangaImages",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaImages_MangaChapterId",
                table: "MangaImages",
                column: "MangaChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_MangaSeasons_CreatedUserId",
                table: "MangaSeasons",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicVideos_CreatedUserId",
                table: "MusicVideos",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsFeeds_CreatedUserId",
                table: "NewsFeeds",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_CreatedUserId",
                table: "Videos",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoLinks_AnimeVideoId",
                table: "VideoLinks",
                column: "AnimeVideoId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoLinks_CreatedUserId",
                table: "VideoLinks",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoLinks_VideoId",
                table: "VideoLinks",
                column: "VideoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "MangaImages");

            migrationBuilder.DropTable(
                name: "MusicVideos");

            migrationBuilder.DropTable(
                name: "VideoLinks");

            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "NewsFeeds");

            migrationBuilder.DropTable(
                name: "MangaChapters");

            migrationBuilder.DropTable(
                name: "AnimeVideos");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "MangaSeasons");

            migrationBuilder.DropTable(
                name: "AnimeEpisodes");

            migrationBuilder.DropTable(
                name: "AnimeSeasons");

            migrationBuilder.DropTable(
                name: "AnimeCategories");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
