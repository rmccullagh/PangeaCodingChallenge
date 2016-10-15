using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pangea.Coding.Challenge.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GitHubOwner",
                columns: table => new
                {
                    GitHubOwnerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    avatar_url = table.Column<string>(nullable: true),
                    events_url = table.Column<string>(nullable: true),
                    followers_url = table.Column<string>(nullable: true),
                    following_url = table.Column<string>(nullable: true),
                    gists_url = table.Column<string>(nullable: true),
                    gravatar_id = table.Column<string>(nullable: true),
                    html_url = table.Column<string>(nullable: true),
                    id = table.Column<int>(nullable: false),
                    login = table.Column<string>(nullable: true),
                    organizations_url = table.Column<string>(nullable: true),
                    received_events_url = table.Column<string>(nullable: true),
                    repos_url = table.Column<string>(nullable: true),
                    site_admin = table.Column<bool>(nullable: false),
                    starred_url = table.Column<string>(nullable: true),
                    subscriptions_url = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitHubOwner", x => x.GitHubOwnerId);
                });

            migrationBuilder.CreateTable(
                name: "GitHubPermissions",
                columns: table => new
                {
                    GitHubPermissionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    admin = table.Column<bool>(nullable: false),
                    pull = table.Column<bool>(nullable: false),
                    push = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitHubPermissions", x => x.GitHubPermissionsId);
                });

            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    GitHubRepositoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    archive_url = table.Column<string>(nullable: true),
                    assignees_url = table.Column<string>(nullable: true),
                    blobs_url = table.Column<string>(nullable: true),
                    branches_url = table.Column<string>(nullable: true),
                    clone_url = table.Column<string>(nullable: true),
                    collaborators_url = table.Column<string>(nullable: true),
                    comments_url = table.Column<string>(nullable: true),
                    commits_url = table.Column<string>(nullable: true),
                    compare_url = table.Column<string>(nullable: true),
                    contents_url = table.Column<string>(nullable: true),
                    contributors_url = table.Column<string>(nullable: true),
                    created_at = table.Column<string>(nullable: true),
                    default_branch = table.Column<string>(nullable: true),
                    deployments_url = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    downloads_url = table.Column<string>(nullable: true),
                    events_url = table.Column<string>(nullable: true),
                    fork = table.Column<bool>(nullable: false),
                    forks = table.Column<int>(nullable: false),
                    forks_count = table.Column<int>(nullable: false),
                    forks_url = table.Column<string>(nullable: true),
                    full_name = table.Column<string>(nullable: true),
                    git_commits_url = table.Column<string>(nullable: true),
                    git_refs_url = table.Column<string>(nullable: true),
                    git_tags_url = table.Column<string>(nullable: true),
                    git_url = table.Column<string>(nullable: true),
                    has_downloads = table.Column<bool>(nullable: false),
                    has_issues = table.Column<bool>(nullable: false),
                    has_pages = table.Column<bool>(nullable: false),
                    has_wiki = table.Column<bool>(nullable: false),
                    homepage = table.Column<string>(nullable: true),
                    hooks_url = table.Column<string>(nullable: true),
                    html_url = table.Column<string>(nullable: true),
                    id = table.Column<int>(nullable: false),
                    issue_comment_url = table.Column<string>(nullable: true),
                    issue_events_url = table.Column<string>(nullable: true),
                    issues_url = table.Column<string>(nullable: true),
                    keys_url = table.Column<string>(nullable: true),
                    labels_url = table.Column<string>(nullable: true),
                    language = table.Column<string>(nullable: true),
                    languages_url = table.Column<string>(nullable: true),
                    merges_url = table.Column<string>(nullable: true),
                    milestones_url = table.Column<string>(nullable: true),
                    mirror_url = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    notifications_url = table.Column<string>(nullable: true),
                    open_issues = table.Column<int>(nullable: false),
                    open_issues_count = table.Column<int>(nullable: false),
                    ownerGitHubOwnerId = table.Column<int>(nullable: true),
                    pulls_url = table.Column<string>(nullable: true),
                    pushed_at = table.Column<string>(nullable: true),
                    releases_url = table.Column<string>(nullable: true),
                    size = table.Column<int>(nullable: false),
                    ssh_url = table.Column<string>(nullable: true),
                    stargazers_count = table.Column<int>(nullable: false),
                    stargazers_url = table.Column<string>(nullable: true),
                    statuses_url = table.Column<string>(nullable: true),
                    subscribers_url = table.Column<string>(nullable: true),
                    subscription_url = table.Column<string>(nullable: true),
                    svn_url = table.Column<string>(nullable: true),
                    tags_url = table.Column<string>(nullable: true),
                    teams_url = table.Column<string>(nullable: true),
                    trees_url = table.Column<string>(nullable: true),
                    updated_at = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    watchers = table.Column<int>(nullable: false),
                    watchers_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.GitHubRepositoryId);
                    table.ForeignKey(
                        name: "FK_Repositories_GitHubPermissions_id",
                        column: x => x.id,
                        principalTable: "GitHubPermissions",
                        principalColumn: "GitHubPermissionsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repositories_GitHubOwner_ownerGitHubOwnerId",
                        column: x => x.ownerGitHubOwnerId,
                        principalTable: "GitHubOwner",
                        principalColumn: "GitHubOwnerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_id",
                table: "Repositories",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_ownerGitHubOwnerId",
                table: "Repositories",
                column: "ownerGitHubOwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "GitHubPermissions");

            migrationBuilder.DropTable(
                name: "GitHubOwner");
        }
    }
}
