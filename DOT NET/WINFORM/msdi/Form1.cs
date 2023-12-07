using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform rn= new registerform();
            rn.MdiParent = this;
            rn.Show();

        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform ac= new accountform();
            ac.MdiParent = this;
            ac.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform r= new registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform accountform = new accountform();
            accountform.MdiParent = this;
            accountform.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            registerform rc= new registerform();
            rc.MdiParent = this;
            rc.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            accountform ac= new accountform();
            ac.MdiParent = this;
            ac.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
