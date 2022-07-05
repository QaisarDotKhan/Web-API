using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAPI2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customerID);
                });

            migrationBuilder.CreateTable(
                name: "dishes",
                columns: table => new
                {
                    dishID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dishIngredient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dishPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orderID = table.Column<int>(type: "int", nullable: false),
                    branchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishes", x => x.dishID);
                });

            migrationBuilder.CreateTable(
                name: "owner",
                columns: table => new
                {
                    ownerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ownerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ownerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner", x => x.ownerID);
                });

            migrationBuilder.CreateTable(
                name: "restaurants",
                columns: table => new
                {
                    restaurantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    restaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    restaurantType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    restaurationLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.restaurantID);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderPrice = table.Column<int>(type: "int", nullable: false),
                    orderDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orderTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dishID = table.Column<int>(type: "int", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.orderID);
                    table.ForeignKey(
                        name: "FK_orders_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "customerID");
                });

            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    branchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branchCityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchTelephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchTotalEmployees = table.Column<int>(type: "int", nullable: false),
                    ownerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.branchID);
                    table.ForeignKey(
                        name: "FK_branches_owner_ownerID",
                        column: x => x.ownerID,
                        principalTable: "owner",
                        principalColumn: "ownerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishOrder",
                columns: table => new
                {
                    dishesdishID = table.Column<int>(type: "int", nullable: false),
                    ordersorderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishOrder", x => new { x.dishesdishID, x.ordersorderID });
                    table.ForeignKey(
                        name: "FK_DishOrder_dishes_dishesdishID",
                        column: x => x.dishesdishID,
                        principalTable: "dishes",
                        principalColumn: "dishID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishOrder_orders_ordersorderID",
                        column: x => x.ordersorderID,
                        principalTable: "orders",
                        principalColumn: "orderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchDish",
                columns: table => new
                {
                    branchesbranchID = table.Column<int>(type: "int", nullable: false),
                    dishesdishID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchDish", x => new { x.branchesbranchID, x.dishesdishID });
                    table.ForeignKey(
                        name: "FK_BranchDish_branches_branchesbranchID",
                        column: x => x.branchesbranchID,
                        principalTable: "branches",
                        principalColumn: "branchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchDish_dishes_dishesdishID",
                        column: x => x.dishesdishID,
                        principalTable: "dishes",
                        principalColumn: "dishID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    empID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empRoll = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.empID);
                    table.ForeignKey(
                        name: "FK_employees_branches_branchID",
                        column: x => x.branchID,
                        principalTable: "branches",
                        principalColumn: "branchID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchDish_dishesdishID",
                table: "BranchDish",
                column: "dishesdishID");

            migrationBuilder.CreateIndex(
                name: "IX_branches_ownerID",
                table: "branches",
                column: "ownerID");

            migrationBuilder.CreateIndex(
                name: "IX_DishOrder_ordersorderID",
                table: "DishOrder",
                column: "ordersorderID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_branchID",
                table: "employees",
                column: "branchID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_customerID",
                table: "orders",
                column: "customerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchDish");

            migrationBuilder.DropTable(
                name: "DishOrder");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "restaurants");

            migrationBuilder.DropTable(
                name: "dishes");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "branches");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "owner");
        }
    }
}
