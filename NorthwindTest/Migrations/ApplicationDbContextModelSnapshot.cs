﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NorthwindTest.Entities;

namespace NorthwindTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NorthwindTest.Entities.Customers", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Address1")
                        .HasColumnName("address1")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Address2")
                        .HasColumnName("address2")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Company")
                        .HasColumnName("company")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("PostalCode")
                        .HasColumnName("postal_code")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("NorthwindTest.Entities.Employees", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Address1")
                        .HasColumnName("address1")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Address2")
                        .HasColumnName("address2")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Avatar")
                        .HasColumnName("avatar")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Department")
                        .HasColumnName("department")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("JobTitle")
                        .HasColumnName("job_title")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("ManagerId")
                        .HasColumnName("manager_id")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("PostalCode")
                        .HasColumnName("postal_code")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("NorthwindTest.Entities.OrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("order_id")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateAllocated")
                        .HasColumnName("date_allocated")
                        .HasColumnType("datetime");

                    b.Property<double>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("discount")
                        .HasColumnType("float")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("OrderDetailStatus")
                        .HasColumnName("order_detail_status")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<decimal>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("quantity")
                        .HasColumnType("decimal(18, 4)")
                        .HasDefaultValueSql("('0.0000')");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("unit_price")
                        .HasColumnType("decimal(19, 4)")
                        .HasDefaultValueSql("('0.0000')");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PK__order_de__022945F69EE5D9C9");

                    b.HasIndex("ProductId");

                    b.ToTable("order_details");
                });

            modelBuilder.Entity("NorthwindTest.Entities.Orders", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnName("employee_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnName("order_date")
                        .HasColumnType("datetime");

                    b.Property<string>("OrderStatus")
                        .HasColumnName("order_status")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<DateTime?>("PaidDate")
                        .HasColumnName("paid_date")
                        .HasColumnType("datetime");

                    b.Property<string>("PaymentType")
                        .HasColumnName("payment_type")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipAddress1")
                        .HasColumnName("ship_address1")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("ShipAddress2")
                        .HasColumnName("ship_address2")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("ShipCity")
                        .HasColumnName("ship_city")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipCountry")
                        .HasColumnName("ship_country")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipName")
                        .HasColumnName("ship_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipPostalCode")
                        .HasColumnName("ship_postal_code")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipState")
                        .HasColumnName("ship_state")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnName("shipped_date")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("ShippingFee")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("shipping_fee")
                        .HasColumnType("decimal(19, 4)")
                        .HasDefaultValueSql("('0.0000')");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("NorthwindTest.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnName("category")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<byte>("Discontinued")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("discontinued")
                        .HasColumnType("tinyint")
                        .HasDefaultValueSql("('0')");

                    b.Property<decimal>("ListPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("list_price")
                        .HasColumnType("decimal(19, 4)")
                        .HasDefaultValueSql("('0.0000')");

                    b.Property<int?>("MinimumReorderQuantity")
                        .HasColumnName("minimum_reorder_quantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnName("product_code")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("ProductName")
                        .HasColumnName("product_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("QuantityPerUnit")
                        .HasColumnName("quantity_per_unit")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("ReorderLevel")
                        .HasColumnName("reorder_level")
                        .HasColumnType("int");

                    b.Property<decimal?>("StandardCost")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("standard_cost")
                        .HasColumnType("decimal(19, 4)")
                        .HasDefaultValueSql("('0.0000')");

                    b.Property<int?>("TargetLevel")
                        .HasColumnName("target_level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("NorthwindTest.Entities.OrderDetails", b =>
                {
                    b.HasOne("NorthwindTest.Entities.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("fk_order_details__orders")
                        .IsRequired();

                    b.HasOne("NorthwindTest.Entities.Products", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_order_details__products")
                        .IsRequired();
                });

            modelBuilder.Entity("NorthwindTest.Entities.Orders", b =>
                {
                    b.HasOne("NorthwindTest.Entities.Customers", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_orders__customers");

                    b.HasOne("NorthwindTest.Entities.Employees", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("fk_orders__employees");
                });
#pragma warning restore 612, 618
        }
    }
}