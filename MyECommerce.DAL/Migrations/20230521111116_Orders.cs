using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyECommerce.DAL.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 21, 14, 11, 15, 794, DateTimeKind.Local).AddTicks(783), new Guid("4738e712-c609-43dc-9d89-3d57989b34e1") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 21, 14, 11, 15, 794, DateTimeKind.Local).AddTicks(1107), new Guid("2e9bfaa1-34d2-402c-86e3-4b4b3afd6361") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 21, 14, 11, 15, 794, DateTimeKind.Local).AddTicks(1110), new Guid("c5f04364-abe7-4c43-8bdb-f8db88d55645") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 21, 14, 11, 15, 791, DateTimeKind.Local).AddTicks(6525), new Guid("bd1c0697-6adb-460a-8c5d-b69f152f5517") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 21, 14, 11, 15, 793, DateTimeKind.Local).AddTicks(2158), new Guid("aab05b56-d05e-4132-8456-c42af33b3e4e") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 21, 14, 11, 15, 793, DateTimeKind.Local).AddTicks(2171), new Guid("5569f239-42fe-47e3-b19f-49220fb9a285") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 20, 23, 5, 46, 143, DateTimeKind.Local).AddTicks(3393), new Guid("c51d6de4-76f2-47ca-bf16-8ef61d1ae49d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 20, 23, 5, 46, 143, DateTimeKind.Local).AddTicks(3748), new Guid("eafa287c-0584-4984-b8e5-37fcc5e4db74") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 20, 23, 5, 46, 143, DateTimeKind.Local).AddTicks(3762), new Guid("06a9723e-b292-49be-a62f-741c0449e2d0") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 20, 23, 5, 46, 141, DateTimeKind.Local).AddTicks(6872), new Guid("7dccb166-8c7e-472c-88f2-3925e2892766") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 20, 23, 5, 46, 142, DateTimeKind.Local).AddTicks(6515), new Guid("10696482-2798-4318-8314-ca96098d3fed") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 20, 23, 5, 46, 142, DateTimeKind.Local).AddTicks(6528), new Guid("807567a4-2ebc-4587-b718-47d5c545330a") });
        }
    }
}
