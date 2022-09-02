using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ASP_Identity.Migrations
{
    public partial class RegistroUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "tb_r_usuario_llave");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "tb_usuario");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "tb_r_usuario_rol");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "tb_r_usuario_sesion");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "tb_r_usuario_claim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "tb_rol");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "tb_r_rol_claim");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "tb_r_usuario_llave",
                newName: "txt_valor");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_r_usuario_llave",
                newName: "ln_nombre");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "tb_r_usuario_llave",
                newName: "id_ln_usuario_sesion");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tb_r_usuario_llave",
                newName: "id_usuario");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "tb_usuario",
                newName: "ln_usuario");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "tb_usuario",
                newName: "ind_two_factor_enabled");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "tb_usuario",
                newName: "ln_security_stamp");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "tb_usuario",
                newName: "ln_tel_laboral");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "tb_usuario",
                newName: "ln_hash_contrasenia");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "tb_usuario",
                newName: "ln_usuario_normalizado");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "tb_usuario",
                newName: "ln_c_normalizado");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tb_usuario",
                newName: "ln_nombre_usuario");

            migrationBuilder.RenameColumn(
                name: "LockoutEnabled",
                table: "tb_usuario",
                newName: "ind_bloqueo_habilitado");

            migrationBuilder.RenameColumn(
                name: "EmailConfirmed",
                table: "tb_usuario",
                newName: "ind_correo_confirmado");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tb_usuario",
                newName: "ln_correo_laboral");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "tb_usuario",
                newName: "ln_concurrency_stamp");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "tb_usuario",
                newName: "nu_num_acceso_fallido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_usuario",
                newName: "id_ln_usuario");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "tb_r_usuario_rol",
                newName: "id_ln_rol");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tb_r_usuario_rol",
                newName: "id_ln_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "tb_r_usuario_rol",
                newName: "idx01_usuario_rol");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tb_r_usuario_sesion",
                newName: "id_usuario");

            migrationBuilder.RenameColumn(
                name: "ProviderDisplayName",
                table: "tb_r_usuario_sesion",
                newName: "txt_nombre_proveedor");

            migrationBuilder.RenameColumn(
                name: "ProviderKey",
                table: "tb_r_usuario_sesion",
                newName: "ln_llave_proveedor");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "tb_r_usuario_sesion",
                newName: "id_ln_usuario_sesion");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "tb_r_usuario_sesion",
                newName: "idx01_usuario_sesion");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tb_r_usuario_claim",
                newName: "id_ln_usuario");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "tb_r_usuario_claim",
                newName: "ln_valor_claim");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "tb_r_usuario_claim",
                newName: "ln_tipo_claim");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "tb_r_usuario_claim",
                newName: "idx01_usuario_claim");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "tb_rol",
                newName: "ln_n_nivel_normalizado");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_rol",
                newName: "ln_nombre_nivel_resp");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_rol",
                newName: "id_ln_nivel_respon");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "tb_r_rol_claim",
                newName: "id_ln_rol");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "tb_r_rol_claim",
                newName: "ln_valor_claim");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "tb_r_rol_claim",
                newName: "ln_tipo_claim");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "tb_r_rol_claim",
                newName: "idx01_rol_claim");

            migrationBuilder.AlterColumn<string>(
                name: "txt_valor",
                table: "tb_r_usuario_llave",
                type: "varchar",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ln_nombre",
                table: "tb_r_usuario_llave",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "id_ln_usuario_sesion",
                table: "tb_r_usuario_llave",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ln_usuario",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<bool>(
                name: "ind_two_factor_enabled",
                table: "tb_usuario",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean")
                .Annotation("Relational:ColumnOrder", 22);

            migrationBuilder.AlterColumn<string>(
                name: "ln_security_stamp",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 20);

            migrationBuilder.AlterColumn<string>(
                name: "ln_tel_laboral",
                table: "tb_usuario",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<string>(
                name: "ln_hash_contrasenia",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 19);

            migrationBuilder.AlterColumn<string>(
                name: "ln_usuario_normalizado",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "ln_c_normalizado",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "ln_nombre_usuario",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<bool>(
                name: "ind_bloqueo_habilitado",
                table: "tb_usuario",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean")
                .Annotation("Relational:ColumnOrder", 23);

            migrationBuilder.AlterColumn<bool>(
                name: "ind_correo_confirmado",
                table: "tb_usuario",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean")
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "ln_correo_laboral",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "ln_concurrency_stamp",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 21);

            migrationBuilder.AlterColumn<int>(
                name: "nu_num_acceso_fallido",
                table: "tb_usuario",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Relational:ColumnOrder", 24);

            migrationBuilder.AlterColumn<string>(
                name: "id_ln_usuario",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<string>(
                name: "ln_cargo_laboral",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 16);

            migrationBuilder.AddColumn<string>(
                name: "ln_correo_personal",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AddColumn<string>(
                name: "ln_curp",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<string>(
                name: "ln_nombre_institucion",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 15);

            migrationBuilder.AddColumn<string>(
                name: "ln_primer_apellido",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<string>(
                name: "ln_segundo_apellido",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<string>(
                name: "ln_tel_personal",
                table: "tb_usuario",
                type: "varchar",
                maxLength: 256,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 13);

            migrationBuilder.AddColumn<int>(
                name: "n_nivel_responsabilidad",
                table: "tb_usuario",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 18);

            migrationBuilder.AddColumn<int>(
                name: "n_nivel_seguimiento",
                table: "tb_usuario",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 17);

            migrationBuilder.AddColumn<int>(
                name: "n_tipo_institucion",
                table: "tb_usuario",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 14);

            migrationBuilder.AlterColumn<string>(
                name: "id_ln_rol",
                table: "tb_r_usuario_rol",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "txt_nombre_proveedor",
                table: "tb_r_usuario_sesion",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ln_llave_proveedor",
                table: "tb_r_usuario_sesion",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "id_ln_usuario_sesion",
                table: "tb_r_usuario_sesion",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ln_valor_claim",
                table: "tb_r_usuario_claim",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ln_tipo_claim",
                table: "tb_r_usuario_claim",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "tb_rol",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ln_n_nivel_normalizado",
                table: "tb_rol",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ln_nombre_nivel_resp",
                table: "tb_rol",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id_ln_nivel_respon",
                table: "tb_rol",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "id_ln_rol",
                table: "tb_r_rol_claim",
                type: "varchar",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ln_valor_claim",
                table: "tb_r_rol_claim",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ln_tipo_claim",
                table: "tb_r_rol_claim",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "id_ln_usuario_llave",
                table: "tb_r_usuario_llave",
                columns: new[] { "id_usuario", "id_ln_usuario_sesion", "ln_nombre" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_usuario",
                table: "tb_usuario",
                column: "id_ln_usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_r_usuario_rol",
                table: "tb_r_usuario_rol",
                columns: new[] { "id_ln_usuario", "id_ln_rol" });

            migrationBuilder.AddPrimaryKey(
                name: "id_ln_usuario_sesion",
                table: "tb_r_usuario_sesion",
                columns: new[] { "id_ln_usuario_sesion", "ln_llave_proveedor" });

            migrationBuilder.AddPrimaryKey(
                name: "id_ln_usuario_claim",
                table: "tb_r_usuario_claim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "id_ln_nivel_respon",
                table: "tb_rol",
                column: "id_ln_nivel_respon");

            migrationBuilder.AddPrimaryKey(
                name: "id_ln_rol",
                table: "tb_r_rol_claim",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb_cat_nivel_resp",
                columns: table => new
                {
                    id_n_nivel_respon = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ln_nombre = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id_n_nivel_respon", x => x.id_n_nivel_respon);
                });

            migrationBuilder.CreateTable(
                name: "tb_cat_nivel_seguimiento",
                columns: table => new
                {
                    id_n_nivel_seguimiento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ln_nivel = table.Column<string>(type: "varchar", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id_n_nivel_seguimiento", x => x.id_n_nivel_seguimiento);
                });

            migrationBuilder.CreateTable(
                name: "tb_cat_politica",
                columns: table => new
                {
                    id_n_politica = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ln_politica = table.Column<string>(type: "varchar", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id_n_politica", x => x.id_n_politica);
                });

            migrationBuilder.CreateTable(
                name: "tb_cat_tipo_institucion",
                columns: table => new
                {
                    id_n_tipo_institucion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ln_institucion = table.Column<string>(type: "varchar", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id_n_tipo_institucion", x => x.id_n_tipo_institucion);
                });

            migrationBuilder.CreateIndex(
                name: "idx01_usuario_llave",
                table: "tb_r_usuario_llave",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_usuario_n_nivel_responsabilidad",
                table: "tb_usuario",
                column: "n_nivel_responsabilidad");

            migrationBuilder.CreateIndex(
                name: "IX_tb_usuario_n_nivel_seguimiento",
                table: "tb_usuario",
                column: "n_nivel_seguimiento");

            migrationBuilder.CreateIndex(
                name: "IX_tb_usuario_n_tipo_institucion",
                table: "tb_usuario",
                column: "n_tipo_institucion");

            migrationBuilder.CreateIndex(
                name: "idx01_rol",
                table: "tb_rol",
                column: "ln_nombre_nivel_resp");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_r_rol_claim_tb_rol_id_ln_rol",
                table: "tb_r_rol_claim",
                column: "id_ln_rol",
                principalTable: "tb_rol",
                principalColumn: "id_ln_nivel_respon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_r_usuario_claim_tb_usuario_id_ln_usuario",
                table: "tb_r_usuario_claim",
                column: "id_ln_usuario",
                principalTable: "tb_usuario",
                principalColumn: "id_ln_usuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_r_usuario_llave_tb_usuario_id_usuario",
                table: "tb_r_usuario_llave",
                column: "id_usuario",
                principalTable: "tb_usuario",
                principalColumn: "id_ln_usuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_r_usuario_rol_tb_rol_id_ln_rol",
                table: "tb_r_usuario_rol",
                column: "id_ln_rol",
                principalTable: "tb_rol",
                principalColumn: "id_ln_nivel_respon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_r_usuario_rol_tb_usuario_id_ln_usuario",
                table: "tb_r_usuario_rol",
                column: "id_ln_usuario",
                principalTable: "tb_usuario",
                principalColumn: "id_ln_usuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_r_usuario_sesion_tb_usuario_id_usuario",
                table: "tb_r_usuario_sesion",
                column: "id_usuario",
                principalTable: "tb_usuario",
                principalColumn: "id_ln_usuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_usuario_tb_cat_nivel_resp_n_nivel_responsabilidad",
                table: "tb_usuario",
                column: "n_nivel_responsabilidad",
                principalTable: "tb_cat_nivel_resp",
                principalColumn: "id_n_nivel_respon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_usuario_tb_cat_nivel_seguimiento_n_nivel_seguimiento",
                table: "tb_usuario",
                column: "n_nivel_seguimiento",
                principalTable: "tb_cat_nivel_seguimiento",
                principalColumn: "id_n_nivel_seguimiento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_usuario_tb_cat_tipo_institucion_n_tipo_institucion",
                table: "tb_usuario",
                column: "n_tipo_institucion",
                principalTable: "tb_cat_tipo_institucion",
                principalColumn: "id_n_tipo_institucion",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_r_rol_claim_tb_rol_id_ln_rol",
                table: "tb_r_rol_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_r_usuario_claim_tb_usuario_id_ln_usuario",
                table: "tb_r_usuario_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_r_usuario_llave_tb_usuario_id_usuario",
                table: "tb_r_usuario_llave");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_r_usuario_rol_tb_rol_id_ln_rol",
                table: "tb_r_usuario_rol");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_r_usuario_rol_tb_usuario_id_ln_usuario",
                table: "tb_r_usuario_rol");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_r_usuario_sesion_tb_usuario_id_usuario",
                table: "tb_r_usuario_sesion");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_usuario_tb_cat_nivel_resp_n_nivel_responsabilidad",
                table: "tb_usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_usuario_tb_cat_nivel_seguimiento_n_nivel_seguimiento",
                table: "tb_usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_usuario_tb_cat_tipo_institucion_n_tipo_institucion",
                table: "tb_usuario");

            migrationBuilder.DropTable(
                name: "tb_cat_nivel_resp");

            migrationBuilder.DropTable(
                name: "tb_cat_nivel_seguimiento");

            migrationBuilder.DropTable(
                name: "tb_cat_politica");

            migrationBuilder.DropTable(
                name: "tb_cat_tipo_institucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_usuario",
                table: "tb_usuario");

            migrationBuilder.DropIndex(
                name: "IX_tb_usuario_n_nivel_responsabilidad",
                table: "tb_usuario");

            migrationBuilder.DropIndex(
                name: "IX_tb_usuario_n_nivel_seguimiento",
                table: "tb_usuario");

            migrationBuilder.DropIndex(
                name: "IX_tb_usuario_n_tipo_institucion",
                table: "tb_usuario");

            migrationBuilder.DropPrimaryKey(
                name: "id_ln_nivel_respon",
                table: "tb_rol");

            migrationBuilder.DropIndex(
                name: "idx01_rol",
                table: "tb_rol");

            migrationBuilder.DropPrimaryKey(
                name: "id_ln_usuario_sesion",
                table: "tb_r_usuario_sesion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_r_usuario_rol",
                table: "tb_r_usuario_rol");

            migrationBuilder.DropPrimaryKey(
                name: "id_ln_usuario_llave",
                table: "tb_r_usuario_llave");

            migrationBuilder.DropIndex(
                name: "idx01_usuario_llave",
                table: "tb_r_usuario_llave");

            migrationBuilder.DropPrimaryKey(
                name: "id_ln_usuario_claim",
                table: "tb_r_usuario_claim");

            migrationBuilder.DropPrimaryKey(
                name: "id_ln_rol",
                table: "tb_r_rol_claim");

            migrationBuilder.DropColumn(
                name: "ln_cargo_laboral",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "ln_correo_personal",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "ln_curp",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "ln_nombre_institucion",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "ln_primer_apellido",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "ln_segundo_apellido",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "ln_tel_personal",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "n_nivel_responsabilidad",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "n_nivel_seguimiento",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "n_tipo_institucion",
                table: "tb_usuario");

            migrationBuilder.RenameTable(
                name: "tb_usuario",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "tb_rol",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "tb_r_usuario_sesion",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "tb_r_usuario_rol",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "tb_r_usuario_llave",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "tb_r_usuario_claim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "tb_r_rol_claim",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameColumn(
                name: "nu_num_acceso_fallido",
                table: "AspNetUsers",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "ln_usuario_normalizado",
                table: "AspNetUsers",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "ln_usuario",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "ln_tel_laboral",
                table: "AspNetUsers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ln_security_stamp",
                table: "AspNetUsers",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "ln_nombre_usuario",
                table: "AspNetUsers",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "ln_hash_contrasenia",
                table: "AspNetUsers",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "ln_correo_laboral",
                table: "AspNetUsers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ln_concurrency_stamp",
                table: "AspNetUsers",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "ln_c_normalizado",
                table: "AspNetUsers",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "ind_two_factor_enabled",
                table: "AspNetUsers",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "ind_correo_confirmado",
                table: "AspNetUsers",
                newName: "EmailConfirmed");

            migrationBuilder.RenameColumn(
                name: "ind_bloqueo_habilitado",
                table: "AspNetUsers",
                newName: "LockoutEnabled");

            migrationBuilder.RenameColumn(
                name: "id_ln_usuario",
                table: "AspNetUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ln_nombre_nivel_resp",
                table: "AspNetRoles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ln_n_nivel_normalizado",
                table: "AspNetRoles",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "id_ln_nivel_respon",
                table: "AspNetRoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "txt_nombre_proveedor",
                table: "AspNetUserLogins",
                newName: "ProviderDisplayName");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "AspNetUserLogins",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ln_llave_proveedor",
                table: "AspNetUserLogins",
                newName: "ProviderKey");

            migrationBuilder.RenameColumn(
                name: "id_ln_usuario_sesion",
                table: "AspNetUserLogins",
                newName: "LoginProvider");

            migrationBuilder.RenameIndex(
                name: "idx01_usuario_sesion",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameColumn(
                name: "id_ln_rol",
                table: "AspNetUserRoles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "id_ln_usuario",
                table: "AspNetUserRoles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "idx01_usuario_rol",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameColumn(
                name: "txt_valor",
                table: "AspNetUserTokens",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "ln_nombre",
                table: "AspNetUserTokens",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id_ln_usuario_sesion",
                table: "AspNetUserTokens",
                newName: "LoginProvider");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "AspNetUserTokens",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ln_valor_claim",
                table: "AspNetUserClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "ln_tipo_claim",
                table: "AspNetUserClaims",
                newName: "ClaimType");

            migrationBuilder.RenameColumn(
                name: "id_ln_usuario",
                table: "AspNetUserClaims",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "idx01_usuario_claim",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameColumn(
                name: "ln_valor_claim",
                table: "AspNetRoleClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "ln_tipo_claim",
                table: "AspNetRoleClaims",
                newName: "ClaimType");

            migrationBuilder.RenameColumn(
                name: "id_ln_rol",
                table: "AspNetRoleClaims",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "idx01_rol_claim",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Relational:ColumnOrder", 24);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "AspNetUsers",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 19);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 21);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "varchar",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean")
                .OldAnnotation("Relational:ColumnOrder", 22);

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean")
                .OldAnnotation("Relational:ColumnOrder", 23);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetUsers",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "AspNetUsers",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetRoles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetRoles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderDisplayName",
                table: "AspNetUserLogins",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetUserRoles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AspNetUserTokens",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimValue",
                table: "AspNetUserClaims",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AspNetUserClaims",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimValue",
                table: "AspNetRoleClaims",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AspNetRoleClaims",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 256);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
