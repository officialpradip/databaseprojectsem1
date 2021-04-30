namespace Music_Nepal
{
    partial class Artists
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbstyle = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtbirthplace = new System.Windows.Forms.TextBox();
            this.txtsingername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsingerid = new System.Windows.Forms.TextBox();
            this.Singerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singingstyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 104);
            this.panel1.TabIndex = 0;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(560, 37);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(661, 37);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 3;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(453, 37);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(333, 37);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artists";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdlist);
            this.panel2.Location = new System.Drawing.Point(386, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 324);
            this.panel2.TabIndex = 1;
            // 
            // grdlist
            // 
            this.grdlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Singerid,
            this.SingerName,
            this.BirthPlace,
            this.Age,
            this.Singingstyle});
            this.grdlist.Location = new System.Drawing.Point(3, 14);
            this.grdlist.Name = "grdlist";
            this.grdlist.Size = new System.Drawing.Size(399, 294);
            this.grdlist.TabIndex = 0;
            this.grdlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdlist_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtsingerid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbstyle);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.txtage);
            this.panel3.Controls.Add(this.txtbirthplace);
            this.panel3.Controls.Add(this.txtsingername);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(10, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 318);
            this.panel3.TabIndex = 2;
            // 
            // cmbstyle
            // 
            this.cmbstyle.FormattingEnabled = true;
            this.cmbstyle.Items.AddRange(new object[] {
            "Classic Style",
            "Jazz Style",
            "Pop Style",
            "Rock Style"});
            this.cmbstyle.Location = new System.Drawing.Point(155, 176);
            this.cmbstyle.Name = "cmbstyle";
            this.cmbstyle.Size = new System.Drawing.Size(133, 21);
            this.cmbstyle.TabIndex = 13;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(155, 232);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(20, 232);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(155, 145);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(133, 20);
            this.txtage.TabIndex = 6;
            // 
            // txtbirthplace
            // 
            this.txtbirthplace.Location = new System.Drawing.Point(155, 115);
            this.txtbirthplace.Name = "txtbirthplace";
            this.txtbirthplace.Size = new System.Drawing.Size(133, 20);
            this.txtbirthplace.TabIndex = 5;
            // 
            // txtsingername
            // 
            this.txtsingername.Location = new System.Drawing.Point(155, 73);
            this.txtsingername.Name = "txtsingername";
            this.txtsingername.Size = new System.Drawing.Size(133, 20);
            this.txtsingername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Singing Style:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birth Place:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Singer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Singer ID:";
            // 
            // txtsingerid
            // 
            this.txtsingerid.Location = new System.Drawing.Point(155, 46);
            this.txtsingerid.Name = "txtsingerid";
            this.txtsingerid.Size = new System.Drawing.Size(133, 20);
            this.txtsingerid.TabIndex = 15;
            // 
            // Singerid
            // 
            this.Singerid.DataPropertyName = "Singerid";
            this.Singerid.HeaderText = "ID";
            this.Singerid.Name = "Singerid";
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "SingerName";
            this.SingerName.Name = "SingerName";
            // 
            // BirthPlace
            // 
            this.BirthPlace.DataPropertyName = "BirthPlace";
            this.BirthPlace.HeaderText = "BirthPlace";
            this.BirthPlace.Name = "BirthPlace";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Singingstyle
            // 
            this.Singingstyle.DataPropertyName = "Singingstyle";
            this.Singingstyle.HeaderText = "SingingStyle";
            this.Singingstyle.Name = "Singingstyle";
            // 
            // Artists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Artists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artists";
            this.Load += new System.EventHandler(this.Artists_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtbirthplace;
        private System.Windows.Forms.TextBox txtsingername;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.ComboBox cmbstyle;
        private System.Windows.Forms.TextBox txtsingerid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singingstyle;
    }
}