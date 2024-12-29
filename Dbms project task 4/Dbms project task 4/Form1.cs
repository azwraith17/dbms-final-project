using System;
using System.Data;
using System.Windows.Forms;

namespace Dbms_project_task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data into the tables
            this.customerTableAdapter.Fill(this.restaurantDataSet.Customer);
            this.restaurantTableAdapter.Fill(this.restaurantDataSet1.Restaurant);
            this.menuTableAdapter.Fill(this.restaurantDataSet2.Menu);
            this.orderTableAdapter.Fill(this.restaurantDataSet2.Order);
            this.orderItemTableAdapter.Fill(this.restaurantDataSet2.OrderItem);
        }

        // Customer CRUD operations
        private void LoadCustomerData()
        {
            this.customerTableAdapter.Fill(this.restaurantDataSet.Customer);
            dataGridViewCustomer.DataSource = this.restaurantDataSet.Customer;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var newRow = restaurantDataSet.Customer.NewCustomerRow();
                newRow.FirstName = txtFirstName.Text;
                newRow.LastName = txtLastName.Text;
                newRow.Email = txtEmail.Text;
                newRow.PhoneNumber = txtPhoneNumber.Text;
                newRow.Address = txtAddress.Text;

                restaurantDataSet.Customer.Rows.Add(newRow);
                customerTableAdapter.Update(restaurantDataSet.Customer);
                LoadCustomerData();
                MessageBox.Show("Customer added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCustomer.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewCustomer.CurrentRow.DataBoundItem;
                    selectedRow["FirstName"] = txtFirstName.Text;
                    selectedRow["LastName"] = txtLastName.Text;
                    selectedRow["Email"] = txtEmail.Text;
                    selectedRow["PhoneNumber"] = txtPhoneNumber.Text;
                    selectedRow["Address"] = txtAddress.Text;

                    customerTableAdapter.Update(restaurantDataSet.Customer);
                    LoadCustomerData();
                    MessageBox.Show("Customer updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCustomer.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewCustomer.CurrentRow.DataBoundItem;
                    selectedRow.Delete();

                    customerTableAdapter.Update(restaurantDataSet.Customer);
                    LoadCustomerData();
                    MessageBox.Show("Customer deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = $"FirstName LIKE '%{txtFirstName.Text}%'";
                var rows = restaurantDataSet.Customer.Select(filter);
                if (rows.Length > 0)
                {
                    dataGridViewCustomer.DataSource = rows.CopyToDataTable();
                }
                else
                {
                    dataGridViewCustomer.DataSource = null;
                }
                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching customer: " + ex.Message);
            }
        }

        // Restaurant CRUD operations
        private void LoadRestaurantData()
        {
            this.restaurantTableAdapter.Fill(this.restaurantDataSet1.Restaurant);
            dataGridViewRestaurant.DataSource = this.restaurantDataSet1.Restaurant;
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                var newRow = restaurantDataSet1.Restaurant.NewRestaurantRow();
                newRow.RestaurantName = txtRestaurantName.Text;
                newRow.Location = txtLocation.Text;
                newRow.ContactNumber = txtContactNumber.Text;
                newRow.Email = txtRestaurantEmail.Text;

                restaurantDataSet1.Restaurant.Rows.Add(newRow);
                restaurantTableAdapter.Update(restaurantDataSet1.Restaurant);
                LoadRestaurantData();
                MessageBox.Show("Restaurant added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding restaurant: " + ex.Message);
            }
        }

        private void btnUpdateRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRestaurant.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewRestaurant.CurrentRow.DataBoundItem;
                    selectedRow["RestaurantName"] = txtRestaurantName.Text;
                    selectedRow["Location"] = txtLocation.Text;
                    selectedRow["ContactNumber"] = txtContactNumber.Text;
                    selectedRow["Email"] = txtRestaurantEmail.Text;

                    restaurantTableAdapter.Update(restaurantDataSet1.Restaurant);
                    LoadRestaurantData();
                    MessageBox.Show("Restaurant updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating restaurant: " + ex.Message);
            }
        }

        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRestaurant.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewRestaurant.CurrentRow.DataBoundItem;
                    selectedRow.Delete();

                    restaurantTableAdapter.Update(restaurantDataSet1.Restaurant);
                    LoadRestaurantData();
                    MessageBox.Show("Restaurant deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting restaurant: " + ex.Message);
            }
        }

        private void btnSearchRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = $"RestaurantName LIKE '%{txtRestaurantName.Text}%'";
                var rows = restaurantDataSet1.Restaurant.Select(filter);
                if (rows.Length > 0)
                {
                    dataGridViewRestaurant.DataSource = rows.CopyToDataTable();
                }
                else
                {
                    dataGridViewRestaurant.DataSource = null;
                }
                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching restaurant: " + ex.Message);
            }
        }

        // Menu CRUD operations
        private void LoadMenuData()
        {
            this.menuTableAdapter.Fill(this.restaurantDataSet2.Menu);
            dataGridViewMenu.DataSource = this.restaurantDataSet2.Menu;
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var newRow = restaurantDataSet2.Menu.NewMenuRow();
                newRow.RestaurantID = int.Parse(txtRestaurantID.Text);
                newRow.MenuName = txtMenuName.Text;

                restaurantDataSet2.Menu.Rows.Add(newRow);
                menuTableAdapter.Update(restaurantDataSet2.Menu);
                LoadMenuData();
                MessageBox.Show("Menu added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding menu: " + ex.Message);
            }
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMenu.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewMenu.CurrentRow.DataBoundItem;
                    selectedRow["RestaurantID"] = int.Parse(txtRestaurantID.Text);
                    selectedRow["MenuName"] = txtMenuName.Text;

                    menuTableAdapter.Update(restaurantDataSet2.Menu);
                    LoadMenuData();
                    MessageBox.Show("Menu updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating menu: " + ex.Message);
            }
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMenu.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewMenu.CurrentRow.DataBoundItem;
                    selectedRow.Delete();

                    menuTableAdapter.Update(restaurantDataSet2.Menu);
                    LoadMenuData();
                    MessageBox.Show("Menu deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting menu: " + ex.Message);
            }
        }

        private void btnSearchMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = $"MenuName LIKE '%{txtMenuName.Text}%'";
                var rows = restaurantDataSet2.Menu.Select(filter);
                if (rows.Length > 0)
                {
                    dataGridViewMenu.DataSource = rows.CopyToDataTable();
                }
                else
                {
                    dataGridViewMenu.DataSource = null;
                }
                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching menu: " + ex.Message);
            }
        }

        // Order CRUD operations
        private void LoadOrderData()
        {
            this.orderTableAdapter.Fill(this.restaurantDataSet2.Order);
            dataGridViewOrder.DataSource = this.restaurantDataSet2.Order;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var newRow = restaurantDataSet2.Order.NewOrderRow();
                newRow.CustomerID = int.Parse(txtCustomerID.Text);
                newRow.RestaurantID = int.Parse(txtOrderRestaurantID.Text);
                newRow.OrderDate = DateTime.Parse(txtOrderDate.Text);
                newRow.TotalAmount = decimal.Parse(txtTotalAmount.Text);
                newRow.OrderStatus = txtOrderStatus.Text;

                restaurantDataSet2.Order.Rows.Add(newRow);
                orderTableAdapter.Update(restaurantDataSet2.Order);
                LoadOrderData();
                MessageBox.Show("Order added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message);
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrder.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewOrder.CurrentRow.DataBoundItem;
                    selectedRow["CustomerID"] = int.Parse(txtCustomerID.Text);
                    selectedRow["RestaurantID"] = int.Parse(txtOrderRestaurantID.Text);
                    selectedRow["OrderDate"] = DateTime.Parse(txtOrderDate.Text);
                    selectedRow["TotalAmount"] = decimal.Parse(txtTotalAmount.Text);
                    selectedRow["OrderStatus"] = txtOrderStatus.Text;

                    orderTableAdapter.Update(restaurantDataSet2.Order);
                    LoadOrderData();
                    MessageBox.Show("Order updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrder.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewOrder.CurrentRow.DataBoundItem;
                    selectedRow.Delete();

                    orderTableAdapter.Update(restaurantDataSet2.Order);
                    LoadOrderData();
                    MessageBox.Show("Order deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting order: " + ex.Message);
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = $"OrderStatus LIKE '%{txtOrderStatus.Text}%'";
                var rows = restaurantDataSet2.Order.Select(filter);
                if (rows.Length > 0)
                {
                    dataGridViewOrder.DataSource = rows.CopyToDataTable();
                }
                else
                {
                    dataGridViewOrder.DataSource = null;
                }
                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching order: " + ex.Message);
            }
        }

        // OrderItem CRUD operations
        private void LoadOrderItemData()
        {
            this.orderItemTableAdapter.Fill(this.restaurantDataSet2.OrderItem);
            dataGridViewOrderItem.DataSource = this.restaurantDataSet2.OrderItem;
        }

        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                var newRow = restaurantDataSet2.OrderItem.NewOrderItemRow();
                newRow.OrderID = int.Parse(txtOrderID.Text);
                newRow.MenuItemID = int.Parse(txtMenuItemID.Text);
                newRow.Quantity = int.Parse(txtQuantity.Text);
                newRow.ItemPrice = decimal.Parse(txtItemPrice.Text);

                restaurantDataSet2.OrderItem.Rows.Add(newRow);
                orderItemTableAdapter.Update(restaurantDataSet2.OrderItem);
                LoadOrderItemData();
                MessageBox.Show("Order item added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order item: " + ex.Message);
            }
        }

        private void btnUpdateOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrderItem.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewOrderItem.CurrentRow.DataBoundItem;
                    selectedRow["OrderID"] = int.Parse(txtOrderID.Text);
                    selectedRow["MenuItemID"] = int.Parse(txtMenuItemID.Text);
                    selectedRow["Quantity"] = int.Parse(txtQuantity.Text);
                    selectedRow["ItemPrice"] = decimal.Parse(txtItemPrice.Text);

                    orderItemTableAdapter.Update(restaurantDataSet2.OrderItem);
                    LoadOrderItemData();
                    MessageBox.Show("Order item updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order item: " + ex.Message);
            }
        }

        private void btnDeleteOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrderItem.CurrentRow != null)
                {
                    var selectedRow = (DataRowView)dataGridViewOrderItem.CurrentRow.DataBoundItem;
                    selectedRow.Delete();

                    orderItemTableAdapter.Update(restaurantDataSet2.OrderItem);
                    LoadOrderItemData();
                    MessageBox.Show("Order item deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting order item: " + ex.Message);
            }
        }

        private void btnSearchOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = $"OrderID = {txtOrderID.Text}";
                var rows = restaurantDataSet2.OrderItem.Select(filter);
                if (rows.Length > 0)
                {
                    dataGridViewOrderItem.DataSource = rows.CopyToDataTable();
                }
                else
                {
                    dataGridViewOrderItem.DataSource = null;
                }
                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching order item: " + ex.Message);
            }
        }
    }
}