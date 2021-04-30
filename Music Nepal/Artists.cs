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
    public partial class Artists : Form
    {
        private bool IsEditMode = false;
        public Artists()
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
        private int GetSingerID()// generate singer id
        {
            try
            {
                string Id = "SELECT max(SingerID)+1 as" + " Artists from Artists";
                var data = dbconnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (IsEditMode == false)
            {
                string Sql = "Insert into Artists(SingerID,SingerName,BirthPlace,Age,Singingstyle) Values  ("+ txtsingerid.Text +",'" + txtsingername.Text + "','" + txtbirthplace.Text + "'," + txtage.Text + ",'" + cmbstyle.Text + "')";
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
            string sql = "Select SingerID,SingerName,BirthPlace,Age,Singingstyle from Artists";
            return dbconnection.GetTableByQuery(sql);
        }

        private void grdlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsingerid.Text = grdlist.CurrentRow.Cells["ID"].Value.ToString();
            txtsingername.Text = grdlist.CurrentRow.Cells["SingerName"].Value.ToString();
            txtbirthplace.Text = grdlist.CurrentRow.Cells["BirthPlace"].Value.ToString();
            txtage.Text = grdlist.CurrentRow.Cells["Age"].Value.ToString();
            cmbstyle.Text = grdlist.CurrentRow.Cells["Singingstyle"].Value.ToString();
            
        }

        private void Artists_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = GetData();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtsingerid.Text = GetSingerID().ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delstr = "delete from Artists where Name = " + txtsingername.Text;
            var a = MessageBox.Show("do you confirm to delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                dbconnection.ExecuteNonQuery(delstr);
                MessageBox.Show("delete successfully");
                grdlist.DataSource = GetData();
            }
        }
    }
}
