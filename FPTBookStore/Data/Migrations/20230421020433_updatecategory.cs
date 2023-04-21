using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class updatecategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_WaitCategory_WaitCategoryId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "WaitCategory");

            migrationBuilder.DropIndex(
                name: "IX_Product_WaitCategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "WaitCategoryId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "0207cd67-48b8-4f78-8eda-5f6bcc673f45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "378f1a16-3824-4eb6-a4f0-3edc56064996");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "5de336a2-6fdf-4e42-983a-0d8d3363baf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4d43c4c-1fdf-4802-8b38-c4e0b1b7fd10", "AQAAAAEAACcQAAAAEC/X8xfhNGhO7hP0mUSHOE8Si1rNQUdQ8TEpvTgDf8fowNUR9BNZDLualjSq4fyG3Q==", "154bc8c4-e103-446e-ae90-0bcdfdf1eb44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bea39a7-b154-4445-84ae-e3234d5eafb5", "AQAAAAEAACcQAAAAEN3vqVOgN9POOw4XfV7rr3rEUMJ6MefK1ITmCb34AisruqQ2qUTHF8wUd8h04HQ2LA==", "d87d7aaa-ef7d-4e2d-acba-50251d5fc12c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a60dcfb-4f92-426f-bdc9-5e9d206715e1", "AQAAAAEAACcQAAAAEBNBj9tWteVl/YVTpw/ffOYtiH/ES28BLqQ0ziNsfBtVetErAeW1HI8s9lkcGUp55Q==", "099f765e-f504-4bc9-9f22-c73f275e53e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebebd14c-3d97-4e09-ad90-72409353fa15", "AQAAAAEAACcQAAAAEPkLaqdT1q6t31ebsh4Oh9+DTVJEjhxZzHkzm2RRaATbBN2vLxeWuv2f7+aEo5E8zw==", "7d5f41f6-c5c8-4d0e-956f-2638f45afd5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29a01316-e155-492e-9e37-6d4b782ae62f", "AQAAAAEAACcQAAAAEA2Ckn3s+cQ5QoBpC1vRDn98PuWVXkM+6AMD38lXwPVs6auOQ2STkspU089iGMx7Xw==", "51ff66ce-a909-4c5c-a161-b5fe0d705e3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f7aaac-8a6d-4841-bd37-0f9b5e84ef9f", "AQAAAAEAACcQAAAAEH/eIG2z7DT8O5JtqBjZ5m2/YhU8BlaV2TP3tuVpM7wj975ifBUfw8ceViMkUo2OOA==", "c859e9e3-2553-468a-ab92-1cc09bb060ed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WaitCategoryId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WaitCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaitCategory", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "ee51d64c-7cbb-44d2-8bfe-e7f36e38e82b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "985f1bcf-8a4d-4c5e-b6bc-341f540b063b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "11878a01-dcc7-41fd-a9a5-04f3ec448437");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2230ac1b-87b6-479d-a9bb-0e234f192853", "AQAAAAEAACcQAAAAEC8k8+Fnmj2qTJsm7O2b94yxDFYBUb5I8l67rO7GmLuD4dYWmM44RdAWsMsVU+aItA==", "9e815fab-d0b3-4e07-adf6-8133472c4313" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c41a950-af22-46c1-acad-c7de84faabde", "AQAAAAEAACcQAAAAEH50KiSh7z98fa6Wr1Vny6n+OcqsT+ilC8jdC1yB2ZUPhFBgcrpPcrNJl6r5HBqJNA==", "feeff58d-4ce0-46c7-91c3-7edfeebfe89a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f13f1559-03f1-4566-b4b5-5e85f7343d68", "AQAAAAEAACcQAAAAEOCV0QCVP61ucoap+B6AgjPi/sG65e82j0YrxQ4f8uhFZ7MI06EOXz7Nbdp9TM7sTg==", "7dc4f1ce-1a63-45b8-9364-e116dd34ccbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d042a13d-58c2-41f5-a39f-5de771014ba8", "AQAAAAEAACcQAAAAELFshC8y+xXR5IUG6KA6f/d+oOoZg2KgUGG9w2OjpPTPuYqzrr8t2LDAbZ1msFCoQA==", "4a8440fc-1f4c-42b4-81e2-e2f3ced27e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88994ab1-154f-4ed3-aca5-e1da7f669483", "AQAAAAEAACcQAAAAED3nrMNVMIdlyx+PUIn88wT94MNCDzogbdmRfNM1UL6RbGM5X88f+0bX9orkyExSIQ==", "3ddb6976-9703-4f33-a86b-7e7658195910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b1acd53-7039-4408-ac73-b42c4fea121d", "AQAAAAEAACcQAAAAEM5lQFf+4cMQ/rW3JDVYibopg3PoZ34oW/FcdqH14L3cA3XC4KrRvFKoR/57vAu4mA==", "f6ff2d0f-dee9-45fa-a6a3-58886d1ae331" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_WaitCategoryId",
                table: "Product",
                column: "WaitCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_WaitCategory_WaitCategoryId",
                table: "Product",
                column: "WaitCategoryId",
                principalTable: "WaitCategory",
                principalColumn: "Id");
        }
    }
}
