using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Nepal
{
    public partial class Buyers : Form
    {
        private bool IsEditMode = false;
        public Buyers()
        {
            InitializeComponent();
        }
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    btnnew.Enabled = true;
                    btndelete.Enabled = false;
                    btnedit.Enabled = true;
                    btnsave.Enabled = false;


                    break;
                case "New"://setting when new is click
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;

                    break;
                case "Edit":
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;

                    break;

            }
        }
        private int GetCustomerID()// generate customer id
        {
            try
            {
                string Id = "SELECT max(CustomerID)+1 as" + " Buyers from Buyers";
                var data = dbconnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }
        private void LoadSingerID()
        {
            string sql = "select SingerID From Artists";
            var data = dbconnection.GetTableByQuery(sql);
            cmbid.DataSource = data;
           // cmbsupplierid.DisplayMember = "SupplierName";
            cmbid.ValueMember = "SingerID";
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            if (IsEditMode == false)
            {
                string Sql = "Insert into Buyers (CustomerID, CustomerName, SingerID, CustomerAddress, Amount, GroupType) Values  (" + txtcustomerid.Text + ", '" + txtcustomername.Text + "'," + cmbid.Text + ",'" + txtcustomeraddress.Text + "'," + txtamount.Text + ",'" + txtchecked.Text + "')";
                dbconnection.ExecuteNonQuery(Sql);
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            grdlist.DataSource = GetData();
        }
        private DataTable GetData()
        {
            string sql = "Select CustomerID, CustomerName,SingerID,CustomerAddress,Amount,GroupType from Buyers";
            return dbconnection.GetTableByQuery(sql);
        }

        private void Buyers_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = GetData();
            LoadSingerID();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtcustomerid.Text = GetCustomerID().ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delstr = "delete from Buyers where Name = " + txtcustomerid.Text;
            var a = MessageBox.Show("do you confirm to delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                dbconnection.ExecuteNonQuery(delstr);
                MessageBox.Show("delete successfully");
                grdlist.DataSource = GetData();
            }
        }

       

        private void grdlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustomerid.Text = grdlist.CurrentRow.Cells["CustomerID"].Value.ToString();
            txtcustomername.Text = grdlist.CurrentRow.Cells["Customer Name"].Value.ToString();
            cmbid.Text = grdlist.CurrentRow.Cells["SingerID"].Value.ToString();
            txtcustomeraddress.Text = grdlist.CurrentRow.Cells["CustomerAddress"].Value.ToString();
            txtamount.Text = grdlist.CurrentRow.Cells["Amount"].Value.ToString();
            txtchecked.Text = grdlist.CurrentRow.Cells["GroupType"].Value.ToString();

        }
    }
}
