using LojaFatitForm1_39.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using LojaFatitForm1_39.Classes;

namespace LojaFatitForm1_39
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void PastroFushat()
        {
            txtEmri.Clear();
            txtMbiemri.Clear();
            txtMosha.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            rBtnAdmin.Checked = false;
            rBtnUser.Checked = false; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PastroFushat();
        }

        private bool Valdimi()
        {
            if (txtEmri.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni emrin.");
                return false;
            }
            if (txtMbiemri.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni mbiemrin.");
                return false;
            }
            if (txtMosha.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni mosha.");
                return false;
            }
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni username.");
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni password.");
                return false;
            }
            if(rBtnAdmin.Checked==false && rBtnUser.Checked==false)
            {
                MessageBox.Show("Ju lutem! Zgjedheni Statusin.");
                return false;
            }
            if (int.Parse(txtMosha.Text) < 18)
            {
                MessageBox.Show("Nuk lejohet te regjistroni lojtar me te vogel se 18 vjet");
                return false;
            }
            if (UserValidimi.CheckUsernameIfExist(txtUsername.Text))
            {
                MessageBox.Show("Ju lutem! Ndryshojeni username sepse egziston.");
                txtUsername.Clear();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            try
            {
                LojaContext context = new LojaContext();

                if (Valdimi())
                {
                    var lojtari = new Lojtari();
                    lojtari.Emri = txtEmri.Text;
                    lojtari.Mbiemri = txtMbiemri.Text;
                    lojtari.Mosha = int.Parse(txtMosha.Text);
                    lojtari.Username = txtUsername.Text;
                    lojtari.Password = Enkriptimi.Md5(txtPassword.Text);
                    lojtari.Statusi = rBtnAdmin.Checked ? 1 : 0;
                    context.Lojtaret.Add(lojtari);

                    context.SaveChanges();
                    MessageBox.Show("Te dhenat jane ruajtur me sukses");
                    PastroFushat();
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format i gabuar.");
                PastroFushat();
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult pergjigja = MessageBox.Show("A deshironi te dilni prej Aplikacioni ?", "Exit", MessageBoxButtons.YesNo);
            if (pergjigja == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //butoni ktheni ne main form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admForm = new Admin();
            admForm.ShowDialog();
        }

        //Load
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            PastroFushat();
        }
    }


}

