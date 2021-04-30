namespace Music_Nepal
{
    partial class Songs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtmarkedprice = new System.Windows.Forms.TextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.txtsongstitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsongsid = new System.Windows.Forms.TextBox();
            this.txtchecked = new System.Windows.Forms.CheckedListBox();
            this.SongsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongsTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongsCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdlist);
            this.panel3.Location = new System.Drawing.Point(388, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 343);
            this.panel3.TabIndex = 5;
            // 
            // grdlist
            // 
            this.grdlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongsID,
            this.SongsTitle,
            this.SongsCategory,
            this.SingerID,
            this.RecordedYear,
            this.MarkedPrice,
            this.GroupType});
            this.grdlist.Location = new System.Drawing.Point(8, 3);
            this.grdlist.Name = "grdlist";
            this.grdlist.Size = new System.Drawing.Size(395, 337);
            this.grdlist.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtchecked);
            this.panel2.Controls.Add(this.txtsongsid);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.dateTime);
            this.panel2.Controls.Add(this.txtmarkedprice);
            this.panel2.Controls.Add(this.cmbcategory);
            this.panel2.Controls.Add(this.cmbid);
            this.panel2.Controls.Add(this.txtsongstitle);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 346);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Group Type:";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(272, 308);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(191, 308);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(193, 159);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(133, 20);
            this.dateTime.TabIndex = 16;
            // 
            // txtmarkedprice
            // 
            this.txtmarkedprice.Location = new System.Drawing.Point(193, 193);
            this.txtmarkedprice.Name = "txtmarkedprice";
            this.txtmarkedprice.Size = new System.Drawing.Size(133, 20);
            this.txtmarkedprice.TabIndex = 15;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(193, 82);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(133, 21);
            this.cmbcategory.TabIndex = 14;
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(193, 119);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(133, 21);
            this.cmbid.TabIndex = 13;
            // 
            // txtsongstitle
            // 
            this.txtsongstitle.Location = new System.Drawing.Point(193, 46);
            this.txtsongstitle.Name = "txtsongstitle";
            this.txtsongstitle.Size = new System.Drawing.Size(133, 20);
            this.txtsongstitle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Singer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Songs Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recorded Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marked Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Songs Title:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 72);
            this.panel1.TabIndex = 3;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(686, 25);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 7;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(591, 25);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(488, 25);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(379, 25);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Songs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Songs ID:";
            // 
            // txtsongsid
            // 
            this.txtsongsid.Location = new System.Drawing.Point(193, 12);
            this.txtsongsid.Name = "txtsongsid";
            this.txtsongsid.Size = new System.Drawing.Size(133, 20);
            this.txtsongsid.TabIndex = 22;
            // 
            // txtchecked
            // 
            this.txtchecked.CheckOnClick = true;
            this.txtchecked.FormattingEnabled = true;
            this.txtchecked.Items.AddRange(new object[] {
            "Guitar Based",
            "Drum Based",
            "Flute Based",
            "Solo"});
            this.txtchecked.Location = new System.Drawing.Point(193, 219);
            this.txtchecked.Name = "txtchecked";
            this.txtchecked.Size = new System.Drawing.Size(120, 64);
            this.txtchecked.TabIndex = 28;
            // 
            // SongsID
            // 
            this.SongsID.DataPropertyName = "SongsID";
            this.SongsID.HeaderText = "ID";
            this.SongsID.Name = "SongsID";
            // 
            // SongsTitle
            // 
            this.SongsTitle.DataPropertyName = "SongsTitle";
            this.SongsTitle.HeaderText = "Songs Title";
            this.SongsTitle.Name = "SongsTitle";
            // 
            // SongsCategory
            // 
            this.SongsCategory.DataPropertyName = "SongsCategory";
            this.SongsCategory.HeaderText = "Songs Category";
            this.SongsCategory.Name = "SongsCategory";
            // 
            // SingerID
            // 
            this.SingerID.DataPropertyName = "SingerID";
            this.SingerID.HeaderText = "Singer ID";
            this.SingerID.Name = "SingerID";
            // 
            // RecordedYear
            // 
            this.RecordedYear.DataPropertyName = "RecordedYear";
            this.RecordedYear.HeaderText = "Recorded Year";
            this.RecordedYear.Name = "RecordedYear";
            // 
            // MarkedPrice
            // 
            this.MarkedPrice.DataPropertyName = "MarkedPrice";
            this.MarkedPrice.HeaderText = "Marked Price";
            this.MarkedPrice.Name = "MarkedPrice";
            // 
            // GroupType
            // 
            this.GroupType.DataPropertyName = "GroupType";
            this.GroupType.HeaderText = "Group Type";
            this.GroupType.Name = "GroupType";
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Songs";
            this.Text = "Songs";
            this.Load += new System.EventHandler(this.Songs_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txtmarkedprice;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.TextBox txtsongstitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsongsid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox txtchecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongsTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongsCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupType;
    }
}