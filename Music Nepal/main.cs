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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void artistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artists f = new Artists();
            f.MdiParent = this;
            f.Show();
        }

        private void songsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Songs f = new Songs();
            f.MdiParent = this;
            f.Show();
        }

        private void buyersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buyers f = new Buyers();
            f.MdiParent = this;
            f.Show();
        }
    }
    }

