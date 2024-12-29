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

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            
        }


        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdateOrderItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteOrderItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearchOrderItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewRestaurant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}