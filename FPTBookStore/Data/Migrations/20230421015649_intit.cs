using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class intit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "b928dda7-2bba-40a1-91df-85fa5febd18d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "ff7b6271-de4e-4c59-8c51-0e6730fdef56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "106feaee-7ece-4751-aa47-99d7adb8b7d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8391a69-f91c-46d3-b575-42c992313c9e", "AQAAAAEAACcQAAAAEKTeRNsxckiBShT1p9RlQfy1cDmg9FB+o/08FxMGkD5wwmMkuvIoCrsaxTq5AKKwMw==", "56f48c51-f94d-4357-bd0b-2d70b9a5ed09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "567d7f3c-3151-4ed9-a6e5-51ec1cbbd0a8", "AQAAAAEAACcQAAAAEM+WtYRVgrwjnvoU1bWiKTR8fpZKVOYAQr0Sd8EypkZspcuAbeXy7qaUn65rdBLPFA==", "22f87684-7153-486a-ad02-b33123e30121" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70000aae-e48c-463b-859f-1e3e0cb85e34", "AQAAAAEAACcQAAAAECTO00EgR6dLIcL5kyw7o3HBjPnsLHxQUjqdsKFlzsT1gjs06OYXRNypJafYQEiL/g==", "66529560-67c6-4224-a23c-05742eb9c697" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e609817-9871-4742-9114-46140c3ab410", "AQAAAAEAACcQAAAAEB6BMzGk6lBmPvam4ej6xBFMDybYWV6WwvWHmntkeO8w6+zmVNq27BAJSTTmc+BxPA==", "aa4865eb-837c-4dee-8a1e-e34c7a4ff3ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1c4d75c-3629-4560-8ee4-50f2465804d4", "AQAAAAEAACcQAAAAENuszzHRy3Su3efmHBVL1Smk3p8rR8pYSyUHKVQWtMOPNWBtr5F6bhPSVId8eJRAWw==", "07ee1adc-e65d-427a-b0f5-6fe1a1d37b3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b24f6da6-8699-43c8-a72b-735e6ecb971d", "AQAAAAEAACcQAAAAEJeqkjaMsYLnBgjtPvGl/7EnstKeVEiuDJJQ1HgNJpxtg6zyNyMYSx6SL1FT3v9wTQ==", "e9162e3f-99d0-4c43-aaff-8ad23c790a17" });
        }
    }
}
