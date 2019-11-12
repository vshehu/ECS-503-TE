using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hm02.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReactionType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TypeName = table.Column<string>(maxLength: 20, nullable: true),
                    IconUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FriendWith",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChatId = table.Column<Guid>(nullable: false),
                    Friendaversary = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: true),
                    PersonId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendWith", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FriendWithId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chat_FriendWith_FriendWithId",
                        column: x => x.FriendWithId,
                        principalTable: "FriendWith",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MessageContent = table.Column<string>(maxLength: 255, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    MessageCreated = table.Column<DateTime>(nullable: false),
                    ChatId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    StoryId = table.Column<Guid>(nullable: false),
                    PostImageId = table.Column<Guid>(nullable: false),
                    CommentId = table.Column<Guid>(nullable: false),
                    ReactionTypeId = table.Column<Guid>(nullable: false),
                    ReactionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reaction_ReactionType_ReactionTypeId",
                        column: x => x.ReactionTypeId,
                        principalTable: "ReactionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    PostedById = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false),
                    PostContent = table.Column<string>(nullable: false),
                    PostedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<int>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 255, nullable: false),
                    ProfileId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false),
                    ImageName = table.Column<string>(maxLength: 30, nullable: false),
                    PostTime = table.Column<DateTime>(nullable: false),
                    ExpireTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Story_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chat_FriendWithId",
                table: "Chat",
                column: "FriendWithId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentId",
                table: "Comments",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostedById",
                table: "Comments",
                column: "PostedById");

            migrationBuilder.CreateIndex(
                name: "IX_FriendWith_ChatId",
                table: "FriendWith",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendWith_PersonId",
                table: "FriendWith",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendWith_PersonId1",
                table: "FriendWith",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                table: "Message",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ProfileId",
                table: "Person",
                column: "ProfileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_PersonId",
                table: "Post",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PostId",
                table: "PostImages",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_PersonId",
                table: "Profile",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_CommentId",
                table: "Reaction",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_PostId",
                table: "Reaction",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_PostImageId",
                table: "Reaction",
                column: "PostImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_ReactionTypeId",
                table: "Reaction",
                column: "ReactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_StoryId",
                table: "Reaction",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_PersonId",
                table: "Story",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendWith_Person_PersonId",
                table: "FriendWith",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendWith_Person_PersonId1",
                table: "FriendWith",
                column: "PersonId1",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendWith_Chat_ChatId",
                table: "FriendWith",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_Post_PostId",
                table: "Reaction",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_Comments_CommentId",
                table: "Reaction",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_PostImages_PostImageId",
                table: "Reaction",
                column: "PostImageId",
                principalTable: "PostImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_Story_StoryId",
                table: "Reaction",
                column: "StoryId",
                principalTable: "Story",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Post_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Person_PostedById",
                table: "Comments",
                column: "PostedById",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Person_PersonId",
                table: "Post",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Person_PersonId",
                table: "Profile",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chat_FriendWith_FriendWithId",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Person_PersonId",
                table: "Profile");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Reaction");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "ReactionType");

            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "FriendWith");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
