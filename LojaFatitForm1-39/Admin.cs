using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaFatitForm1_39
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void shtoLojtarëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount createForm = new CreateAccount();
            this.Hide();
            createForm.ShowDialog();
        }

        private void editoLojtarëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccount editForm = new EditAccount();
            this.Hide();
            editForm.ShowDialog();

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hapeGjironToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hapjaForm = new OpenGjiro();
            this.Hide();
            hapjaForm.ShowDialog();
        }

        private void luajGjironToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var luajForm = new PlayGjiro();
            this.Hide();
            luajForm.ShowDialog();
        }

        private void tiketatELuajturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tiketaLuajturaForm = new PlayedTickets();
            this.Hide();
            tiketaLuajturaForm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logInForm = new Login();
            this.Hide();
            logInForm.ShowDialog();
        }

        private void fituesitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var winnersForm = new Winners();
            this.Hide();
            winnersForm.ShowDialog();
        }
    }
}
