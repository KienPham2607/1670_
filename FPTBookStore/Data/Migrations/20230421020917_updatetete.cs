using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class updatetete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "O", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "O", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "3c3ea4ff-307c-4e75-875e-2719a19a3032");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "9a664521-7b40-4dd1-904d-097295b28b94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "S", "32ea3021-43e1-42a9-8fa9-fca0ca5e24b4", "Staff", "Staff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Address", "ConcurrencyStamp", "DoB", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Hà Nội", "abd66226-1130-4b1b-9dee-ba78b0584eee", "2000/08/03", "thuanddgch200729@fpt.edu.vn", "Đặng Đức Thuần", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "thuanddgch200729@fpt.edu.vn", "AQAAAAEAACcQAAAAENdmuXDEase1GnobA60saDEeGHZyWAIxLxd4+uSbX4aB/uK4JOUM9fDYa1xOEmrYLw==", "b6131e11-27ca-4501-9941-75c243ff974b", "thuanddgch200729@fpt.edu.vn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Quảng Ninh", "05c46b17-bb1e-49ad-840e-13e93e83471c", "phamtrungkien@gmail.com", "Phạm Trung Kiên", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "phamtrungkien@gmail.com", "AQAAAAEAACcQAAAAEBCA/LqaGvwakCyg42uEPaM/1sZqznaq+RiP/VLYQnP7erPlRHVpoRP8i7aBZf/bIg==", "4d6bc3ba-06ee-4e12-be8f-e7ac21f372b0", "phamtrungkien@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "FullName", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfac6d1b-f600-4e44-8e81-234dd2590564", "Nguyen Van A", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "AQAAAAEAACcQAAAAEIZFrY7yZgA1nnVKp+8DXQd1OS58Z8QtHhsNtKrhEK6BV9omt3MY9+PE/BHjGAe58g==", "5c67926c-8893-47a9-afad-f124b29bad7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Hà Nội", "2ad2a46f-f677-44cc-a970-88e288123823", "staff1@gmail.com", "Dang Duc Thuan", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "staff1@gmail.com", "AQAAAAEAACcQAAAAENXXY6NlClGa71DY0+iYnFmbDS+9gfUYKkCPPeAr8kA/D7UkTc2b+xJX9Ct0Lm7sBw==", "2301e4b6-513e-4575-8478-92c289c36899", "staff1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Quang Ninh", "fefa7906-4551-42cd-a8d5-b5e1567cc658", "staff2@gmail.com", "Pham Trung Kien", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "staff2@gmail.com", "AQAAAAEAACcQAAAAEH/v/nLgBXmliDXiFKIlE7Twb+YoHHhHkmxUa6FP3pMIFxEqlDaVfaitsJH9rFBPeQ==", "958dd3b1-efb3-4804-82c1-201a71a84f29", "staff2@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "S", "5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "S", "6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "S", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "S", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "O", "5de336a2-6fdf-4e42-983a-0d8d3363baf2", "Owner", "Owner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Address", "ConcurrencyStamp", "DoB", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Vĩnh Phúc", "c4d43c4c-1fdf-4802-8b38-c4e0b1b7fd10", "2000/02/22", "quanghuy01@gmail.com", "Nguyễn Quang Huy", "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg", "quanghuy01@gmail.com", "AQAAAAEAACcQAAAAEC/X8xfhNGhO7hP0mUSHOE8Si1rNQUdQ8TEpvTgDf8fowNUR9BNZDLualjSq4fyG3Q==", "154bc8c4-e103-446e-ae90-0bcdfdf1eb44", "quanghuy01@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Hà Nội", "3bea39a7-b154-4445-84ae-e3234d5eafb5", "admin@gmail.com", "Văn Minh", "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg", "admin@gmail.com", "AQAAAAEAACcQAAAAEN3vqVOgN9POOw4XfV7rr3rEUMJ6MefK1ITmCb34AisruqQ2qUTHF8wUd8h04HQ2LA==", "d87d7aaa-ef7d-4e2d-acba-50251d5fc12c", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "FullName", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a60dcfb-4f92-426f-bdc9-5e9d206715e1", "Trần Minh Nghĩa", "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg", "AQAAAAEAACcQAAAAEBNBj9tWteVl/YVTpw/ffOYtiH/ES28BLqQ0ziNsfBtVetErAeW1HI8s9lkcGUp55Q==", "099f765e-f504-4bc9-9f22-c73f275e53e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "New York", "29a01316-e155-492e-9e37-6d4b782ae62f", "owner1@gmail.com", "Tom Holand", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png", "owner1@gmail.com", "AQAAAAEAACcQAAAAEA2Ckn3s+cQ5QoBpC1vRDn98PuWVXkM+6AMD38lXwPVs6auOQ2STkspU089iGMx7Xw==", "51ff66ce-a909-4c5c-a161-b5fe0d705e3d", "owner1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "Image", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "London", "b9f7aaac-8a6d-4841-bd37-0f9b5e84ef9f", "owner2@gmail.com", "Harry Kane", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png", "owner2@gmail.com", "AQAAAAEAACcQAAAAEH/eIG2z7DT8O5JtqBjZ5m2/YhU8BlaV2TP3tuVpM7wj975ifBUfw8ceViMkUo2OOA==", "c859e9e3-2553-468a-ab92-1cc09bb060ed", "owner2@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FullName", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4", 0, "Hà Nội", "ebebd14c-3d97-4e09-ad90-72409353fa15", "ApplicationUser", "2002/02/18", "quanghuy67@gmail.com", false, "Quang Huy Nguyễn", "https://www.alotintuc.com/wp-content/uploads/2021/07/Untitled-Capture2244-scaled-e1626766063525.jpg", false, null, null, "quanghuy67@gmail.com", "AQAAAAEAACcQAAAAEPkLaqdT1q6t31ebsh4Oh9+DTVJEjhxZzHkzm2RRaATbBN2vLxeWuv2f7+aEo5E8zw==", null, false, "7d5f41f6-c5c8-4d0e-956f-2638f45afd5d", false, "quanghuy67@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "O", "5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "O", "6" });
        }
    }
}
