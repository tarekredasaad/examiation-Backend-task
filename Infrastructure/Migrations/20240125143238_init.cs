using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assessment_questions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_id = table.Column<long>(type: "bigint", nullable: true),
                    level = table.Column<int>(type: "int", nullable: true),
                    order = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_questions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "assessments",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    short_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    category_id = table.Column<long>(type: "bigint", nullable: true),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    published = table.Column<byte>(type: "tinyint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    api_key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_banned = table.Column<byte>(type: "tinyint", nullable: true),
                    is_verified = table.Column<byte>(type: "tinyint", nullable: true),
                    confirm_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    confirmed_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    password_changed_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    display_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_ldap = table.Column<byte>(type: "tinyint", nullable: true),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    remember_token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    otp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otp_created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    profile_picture_id = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "assessment_match",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    answer_id_key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    question_id_key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    order = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_match", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_match_assessment_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "assessment_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_options",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    option = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    correct = table.Column<byte>(type: "tinyint", nullable: true),
                    order = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_options", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_options_assessment_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "assessment_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_text",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    order = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_text", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_text_assessment_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "assessment_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_true_false",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    is_true = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_true_false", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_true_false_assessment_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "assessment_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_data",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assessment_id = table.Column<long>(type: "bigint", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_data", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_data_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_department",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_id = table.Column<long>(type: "bigint", nullable: true),
                    assessment_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_department", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_department_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_meta",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assessment_id = table.Column<long>(type: "bigint", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_meta", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_meta_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_questions_relation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    assessment_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_questions_relation", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_questions_relation_assessment_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "assessment_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_assessment_questions_relation_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_sections",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    assessment_id = table.Column<long>(type: "bigint", nullable: false),
                    order = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_sections", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_sections_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_answers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assessment_id = table.Column<long>(type: "bigint", nullable: false),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    score = table.Column<byte>(type: "tinyint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_answers_assessment_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "assessment_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_assessment_answers_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_assessment_answers_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "assessment_enrols",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assessment_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    result = table.Column<int>(type: "int", nullable: true),
                    score = table.Column<byte>(type: "tinyint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assessment_enrols", x => x.id);
                    table.ForeignKey(
                        name: "FK_assessment_enrols_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_assessment_enrols_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_assessment_answers_assessment_id",
                table: "assessment_answers",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_answers_question_id",
                table: "assessment_answers",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_answers_user_id",
                table: "assessment_answers",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_data_assessment_id",
                table: "assessment_data",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_department_assessment_id",
                table: "assessment_department",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_enrols_assessment_id",
                table: "assessment_enrols",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_enrols_user_id",
                table: "assessment_enrols",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_match_question_id",
                table: "assessment_match",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_meta_assessment_id",
                table: "assessment_meta",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_options_question_id",
                table: "assessment_options",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_questions_relation_assessment_id",
                table: "assessment_questions_relation",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_questions_relation_question_id",
                table: "assessment_questions_relation",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_sections_assessment_id",
                table: "assessment_sections",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_text_question_id",
                table: "assessment_text",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_assessment_true_false_question_id",
                table: "assessment_true_false",
                column: "question_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "assessment_answers");

            migrationBuilder.DropTable(
                name: "assessment_data");

            migrationBuilder.DropTable(
                name: "assessment_department");

            migrationBuilder.DropTable(
                name: "assessment_enrols");

            migrationBuilder.DropTable(
                name: "assessment_match");

            migrationBuilder.DropTable(
                name: "assessment_meta");

            migrationBuilder.DropTable(
                name: "assessment_options");

            migrationBuilder.DropTable(
                name: "assessment_questions_relation");

            migrationBuilder.DropTable(
                name: "assessment_sections");

            migrationBuilder.DropTable(
                name: "assessment_text");

            migrationBuilder.DropTable(
                name: "assessment_true_false");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "assessments");

            migrationBuilder.DropTable(
                name: "assessment_questions");
        }
    }
}
