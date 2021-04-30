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
    public partial class Songs : Form
    {
        private bool IsEditMode = false;
        public Songs()
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (IsEditMode == false)
            {
                string Sql = "Insert into Songs (SongsID,SongsTitle,SongsCategory,SingerID, RecordedYear,MarkedPrice,GroupType) Values  (" + txtsongsid.Text + ",'" + txtsongstitle.Text + "','" + cmbcategory.Text + "'," + cmbid.Text + ",'" + dateTime.Text + "'," + txtmarkedprice.Text + ",'" + txtchecked.Text + "')";
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
            string sql = "Select SongsID,SongsTitle,SongsCategory,SingerID,RecordedYear,MarkedPrice, GroupType from Songs";
            return dbconnection.GetTableByQuery(sql);
        }

        private void grdlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsongsid.Text = grdlist.CurrentRow.Cells["SongsID"].Value.ToString();
            txtsongstitle.Text = grdlist.CurrentRow.Cells["SongsTitle"].Value.ToString();
            cmbcategory.Text = grdlist.CurrentRow.Cells["SongsCategory"].Value.ToString();
             cmbid.Text = grdlist.CurrentRow.Cells["SingerID"].Value.ToString();
            dateTime.Text = grdlist.CurrentRow.Cells["RecordedYear"].Value.ToString();
            txtmarkedprice.Text = grdlist.CurrentRow.Cells["MarkedPrice"].Value.ToString();
            txtchecked.Text = grdlist.CurrentRow.Cells["GroupType"].Value.ToString();

        }

        private void Songs_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = GetData();
            LoadSingerID();
            LoadSongsCategory();
        }
        
        private void LoadSingerID()
        {
            string sql = "select SingerID From Artists";
            var data = dbconnection.GetTableByQuery(sql);
            cmbid.DataSource = data;
            cmbid.DisplayMember = "SingerID";
            cmbid.ValueMember = "SingerID";
        }
        private void LoadSongsCategory()
        {
            string sql = "select SingingStyle From Artists";
            var data = dbconnection.GetTableByQuery(sql);
            cmbcategory.DataSource = data;
            cmbcategory.DisplayMember = "SingingStyle";
            cmbcategory.ValueMember = "SingingStyle";
        }
        private int GetSongsID()// generate songs id
        {
            try
            {
                string Id = "SELECT max(SongsID)+1 as" + " Songs from Songs";
                var data = dbconnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtsongsid.Text = GetSongsID().ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delstr = "delete from Songs where Name = " + txtsongstitle.Text;
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

