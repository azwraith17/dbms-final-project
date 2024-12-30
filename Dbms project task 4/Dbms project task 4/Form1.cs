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
            // TODO: This line of code loads data into the 'restaurantDataSet.MenuItem' table. You can move, or remove it, as needed.
            this.menuItemTableAdapter.Fill(this.restaurantDataSet.MenuItem);
            // TODO: This line of code loads data into the 'restaurantDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            // TODO: This line of code loads data into the 'restaurantDataSet.MenuItem' table. You can move, or remove it, as needed.
            this.menuItemTableAdapter.Fill(this.restaurantDataSet.MenuItem);
            // TODO: This line of code loads data into the 'restaurantDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            // TODO: This line of code loads data into the 'restaurantDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            // TODO: This line of code loads data into the 'restaurantDataSet.OrderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter.Fill(this.restaurantDataSet.OrderItem);
            // TODO: This line of code loads data into the 'restaurantDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.restaurantDataSet.Order);
            // TODO: This line of code loads data into the 'restaurantDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            // TODO: This line of code loads data into the 'restaurantDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.restaurantDataSet.Customer);
            // TODO: This line of code loads data into the 'restaurantDataSet.Restaurant' table. You can move, or remove it, as needed.
            this.restaurantTableAdapter.Fill(this.restaurantDataSet.Restaurant);
            // TODO: This line of code loads data into the 'foodOrderingSystemDataSet.Restaurant' table. You can move, or remove it, as needed.
        }
        
        private void clearCustomerText()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Insert(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text, txtAddress.Text);
            this.customerTableAdapter.Fill(this.restaurantDataSet.Customer);
            clearCustomerText();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int customerID;
            int.TryParse(cbCustomer.SelectedValue.ToString(), out customerID);
            this.customerTableAdapter.UpdateQuery(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text, txtAddress.Text, customerID);
            this.customerTableAdapter.Fill(this.restaurantDataSet.Customer);
            clearCustomerText();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerID;
            int.TryParse(cbCustomer.SelectedValue.ToString(), out customerID);
            this.customerTableAdapter.DeleteQuery(customerID);
            this.customerTableAdapter.Fill(this.restaurantDataSet.Customer);
            clearCustomerText();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            int found = 0;
            foreach (DataGridViewRow row in dataGridViewCustomer.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(txtFirstName.Text))
                {
                    dataGridViewCustomer.ClearSelection();
                    dataGridViewCustomer.Rows[row.Index].Selected = true;
                    found = 1;
                    break;
                }
            }
            if (found == 0) MessageBox.Show("Customer not found");
            else MessageBox.Show("Customer found");
            clearCustomerText();
        }

        //    RESTAURANT  //

        private void clearRestaurantText()
        {
            txtRestaurantName.Text = "";
            txtLocation.Text = "";
            txtContactNumber.Text = "";
            txtRestaurantEmail.Text = "";
        }
        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            this.restaurantTableAdapter.Insert(txtRestaurantName.Text, txtLocation.Text, txtContactNumber.Text, txtRestaurantEmail.Text);
            this.restaurantTableAdapter.Fill(this.restaurantDataSet.Restaurant);
            clearRestaurantText();
        }

        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            this.restaurantTableAdapter.DeleteQuery(int.Parse(cbRestaurant.SelectedValue.ToString()));
            this.restaurantTableAdapter.Fill(this.restaurantDataSet.Restaurant);
            clearRestaurantText();
        }

        private void btnUpdateRestaurant_Click(object sender, EventArgs e)
        {
            int restaurantID;
            int.TryParse(cbRestaurant.SelectedValue.ToString(), out restaurantID);
            this.restaurantTableAdapter.UpdateQuery(txtRestaurantName.Text, txtLocation.Text, txtContactNumber.Text, txtRestaurantEmail.Text, restaurantID);
            this.restaurantTableAdapter.Fill(this.restaurantDataSet.Restaurant);
            clearRestaurantText();
        }

        private void btnSearchRestaurant_Click(object sender, EventArgs e)
        {
            int found = 0;
            foreach (DataGridViewRow row in dataGridViewRestaurant.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(txtRestaurantName.Text))
                {
                    dataGridViewRestaurant.ClearSelection();
                    dataGridViewRestaurant.Rows[row.Index].Selected = true;
                    found = 1;
                    break;
                }
            }
            if (found == 0) MessageBox.Show("Restaurant not found");
            else MessageBox.Show("Restaurant found");
            clearRestaurantText();
        }

        //    MENU  //

        private void clearMenuText()
        {
            txtMenuName.Text = "";
            txtRestaurantIDinput.Text = "";
        }
        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            int restaurantID;
            int.TryParse(txtRestaurantIDinput.Text, out restaurantID);
            this.menuTableAdapter.Insert(restaurantID, txtMenuName.Text);
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            clearMenuText();
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            int menuID;
            int.TryParse(cbMenu.SelectedValue.ToString(), out menuID);
            this.menuTableAdapter.UpdateQuery(int.Parse(txtRestaurantIDinput.Text), txtMenuName.Text, menuID);
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            clearMenuText();
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            this.menuTableAdapter.DeleteQuery(int.Parse(cbMenu.SelectedValue.ToString()));
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            clearMenuText();
        }

        private void btnSearchMenu_Click(object sender, EventArgs e)
        {
            int found = 0;
            foreach (DataGridViewRow row in dataGridViewMenu.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(txtMenuName.Text))
                {
                    dataGridViewMenu.ClearSelection();
                    dataGridViewMenu.Rows[row.Index].Selected = true;
                    found = 1;
                    break;
                }
            }
            if (found == 0) MessageBox.Show("Menu not found");
            else MessageBox.Show("Menu found");
        }

        //    ORDER  //

        private void clearOrderText()
        {
            txtCustomerID.Text = "";
            txtOrderRestaurantID.Text = "";
            txtOrderDate.Text = "";
            txtTotalAmount.Text = "";
            txtOrderStatus.Text = "";
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int customerID, restaurantID;
            int.TryParse(txtCustomerID.Text, out customerID);
            int.TryParse(txtOrderRestaurantID.Text, out restaurantID);
            DateTime orderDate;
            DateTime.TryParse(txtOrderDate.Text, out orderDate);
            this.orderTableAdapter.Insert(customerID, restaurantID, orderDate, decimal.Parse(txtTotalAmount.Text), txtOrderStatus.Text);
            this.orderTableAdapter.Fill(this.restaurantDataSet.Order);
            clearOrderText();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            int orderID;
            int.TryParse(cbOrder.SelectedValue.ToString(), out orderID);
            DateTime orderDate;
            DateTime.TryParse(txtOrderDate.Text, out orderDate);
            this.orderTableAdapter.UpdateQuery(int.Parse(txtCustomerID.Text), int.Parse(txtOrderRestaurantID.Text), orderDate, decimal.Parse(txtTotalAmount.Text), txtOrderStatus.Text, orderID);
            this.orderTableAdapter.Fill(this.restaurantDataSet.Order);
            clearOrderText();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            this.orderTableAdapter.DeleteQuery(int.Parse(cbOrder.SelectedValue.ToString()));
            this.orderTableAdapter.Fill(this.restaurantDataSet.Order);
            clearOrderText();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            int found = 0;
            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(txtCustomerID.Text))
                {
                    dataGridViewOrder.ClearSelection();
                    dataGridViewOrder.Rows[row.Index].Selected = true;
                    found = 1;
                    break;
                }
            }
            if (found == 0) MessageBox.Show("Order not found");
            else MessageBox.Show("Order found");
            clearOrderText();
        }

        //    MENU ITEM  //

        private void clearMenuItemText()
        {
            txtMenuItemID.Text = "";
            txtItemName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            int menuID;
            int.TryParse(cbMenu.SelectedValue.ToString(), out menuID);
            this.menuItemTableAdapter.Insert(menuID, txtItemName.Text, txtDescription.Text, decimal.Parse(txtPrice.Text));
            this.menuItemTableAdapter.Fill(this.restaurantDataSet.MenuItem);
            clearMenuItemText();
        }

        private void btnUpdateMenuItem_Click(object sender, EventArgs e)
        {
            int menuItemID;
            int.TryParse(cbMenuItem.SelectedValue.ToString(), out menuItemID);
            this.menuItemTableAdapter.UpdateQuery(int.Parse(cbMenu.SelectedValue.ToString()), txtItemName.Text, txtDescription.Text, decimal.Parse(txtPrice.Text), menuItemID);
            this.menuItemTableAdapter.Fill(this.restaurantDataSet.MenuItem);
            clearMenuItemText();
        }

        private void btnDeleteMenuItem_Click(object sender, EventArgs e)
        {
            this.menuItemTableAdapter.DeleteQuery(int.Parse(cbMenuItem.SelectedValue.ToString()));
            this.menuItemTableAdapter.Fill(this.restaurantDataSet.MenuItem);
            clearMenuItemText();
        }

        private void btnSearchMenuItem_Click(object sender, EventArgs e)
        {
            int found = 0;
            foreach (DataGridViewRow row in dataGridViewMenuItem.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(txtItemName.Text))
                {
                    dataGridViewMenuItem.ClearSelection();
                    dataGridViewMenuItem.Rows[row.Index].Selected = true;
                    found = 1;
                    break;
                }
            }
            if (found == 0) MessageBox.Show("Menu Item not found");
            else MessageBox.Show("Menu Item found");
            clearMenuItemText();
        }


        //    ORDER ITEM  //

        private void clearOrderItemText()
        {
            txtOrderID.Text = "";
            txtMenuItemID.Text = "";
            txtQuantity.Text = "";
            txtItemPrice.Text = "";
        }

        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            int orderID, menuItemID;
            int.TryParse(txtOrderID.Text, out orderID);
            int.TryParse(txtMenuItemID.Text, out menuItemID);
            this.orderItemTableAdapter.Insert(orderID, menuItemID, int.Parse(txtQuantity.Text), decimal.Parse(txtItemPrice.Text));
            this.orderItemTableAdapter.Fill(this.restaurantDataSet.OrderItem);
            clearOrderItemText();
        }

        private void btnUpdateOrderItem_Click(object sender, EventArgs e)
        {
            int orderItemID;
            int.TryParse(cbOrderItem.SelectedValue.ToString(), out orderItemID);
            this.orderItemTableAdapter.UpdateQuery(int.Parse(txtOrderID.Text), int.Parse(txtMenuItemID.Text), int.Parse(txtQuantity.Text), decimal.Parse(txtItemPrice.Text), orderItemID);
            this.orderItemTableAdapter.Fill(this.restaurantDataSet.OrderItem);
            clearOrderItemText();
        }

        private void btnDeleteOrderItem_Click(object sender, EventArgs e)
        {
            this.orderItemTableAdapter.DeleteQuery(int.Parse(cbOrderItem.SelectedValue.ToString()));
            this.orderItemTableAdapter.Fill(this.restaurantDataSet.OrderItem);
            clearOrderItemText();
        }

        private void btnSearchOrderItem_Click(object sender, EventArgs e)
        {
            int found = 0;
            foreach (DataGridViewRow row in dataGridViewOrderItem.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(txtOrderID.Text))
                {
                    dataGridViewOrderItem.ClearSelection();
                    dataGridViewOrderItem.Rows[row.Index].Selected = true;
                    found = 1;
                    break;
                }
            }
            if (found == 0) MessageBox.Show("Order Item not found");
            else MessageBox.Show("Order Item found");
            clearOrderItemText();
        }

        //   not working //
        private void dataGridViewRestaurant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMenuName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRestaurantID_TextChanged(object sender, EventArgs e)
        {

        }


    }
}