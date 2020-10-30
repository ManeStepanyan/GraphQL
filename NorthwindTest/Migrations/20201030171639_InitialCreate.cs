using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    first_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    company = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    address1 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    address2 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    postal_code = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    country = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    first_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    avatar = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    job_title = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    department = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    manager_id = table.Column<int>(nullable: true),
                    phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    address1 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    address2 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    postal_code = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    country = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    product_code = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    product_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    description = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    standard_cost = table.Column<decimal>(type: "decimal(19, 4)", nullable: true, defaultValueSql: "('0.0000')"),
                    list_price = table.Column<decimal>(type: "decimal(19, 4)", nullable: false, defaultValueSql: "('0.0000')"),
                    target_level = table.Column<int>(nullable: true),
                    reorder_level = table.Column<int>(nullable: true),
                    minimum_reorder_quantity = table.Column<int>(nullable: true),
                    quantity_per_unit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    discontinued = table.Column<byte>(nullable: false, defaultValueSql: "('0')"),
                    category = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    employee_id = table.Column<int>(nullable: true),
                    customer_id = table.Column<int>(nullable: true),
                    order_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    shipped_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    ship_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ship_address1 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    ship_address2 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    ship_city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ship_state = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ship_postal_code = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ship_country = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    shipping_fee = table.Column<decimal>(type: "decimal(19, 4)", nullable: true, defaultValueSql: "('0.0000')"),
                    payment_type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    paid_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    order_status = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                    table.ForeignKey(
                        name: "fk_orders__customers",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orders__employees",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "order_details",
                columns: table => new
                {
                    order_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18, 4)", nullable: false, defaultValueSql: "('0.0000')"),
                    unit_price = table.Column<decimal>(type: "decimal(19, 4)", nullable: true, defaultValueSql: "('0.0000')"),
                    discount = table.Column<double>(nullable: false, defaultValueSql: "('0')"),
                    order_detail_status = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    date_allocated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__order_de__022945F69EE5D9C9", x => new { x.order_id, x.product_id });
                    table.ForeignKey(
                        name: "fk_order_details__orders",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_order_details__products",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_details_product_id",
                table: "order_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_customer_id",
                table: "orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_employee_id",
                table: "orders",
                column: "employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_details");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
