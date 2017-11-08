using LojaFatitForm1_39.Classes;
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

namespace LojaFatitForm1_39
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private bool Validimi()
        {
            if (txtOldPassword.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni fushen OldPassword .");
                return false;
            }
            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Ju lutem!Plotesojeni fushen NewPassword");
                return false;
            }
            if (txtConfigrimPassword.Text == "")
            {
                MessageBox.Show("Ju lutem!Plotesojeni fushen ConfirmPassword");
                return false;
            }
            return true;
        }

        private void PastroFushat()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfigrimPassword.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult pergjigja = MessageBox.Show("A deshironi te dilni prej Aplikacioni ?", "Exit", MessageBoxButtons.YesNo);
            if (pergjigja == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            PastroFushat();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(Validimi())
            {
                string oldPassword = Enkriptimi.Md5(txtOldPassword.Text);

                using (var contex = new LojaContext())
                {
                    var lojtari = (from l in contex.Lojtaret
                                   where l.Username == UserValidimi.username
                                   select l).FirstOrDefault();
                    if(oldPassword==lojtari.Password)
                    {
                       if(txtNewPassword.Text==txtConfigrimPassword.Text)
                        {
                            lojtari.Password = Enkriptimi.Md5(txtNewPassword.Text);
                            contex.SaveChanges();
                            MessageBox.Show("Fjalekalimi u ndrrua me sukses");

                            this.Hide();
                            var logForm = new Login();
                            logForm.ShowDialog();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Nuk perputhet oldPassword me ate qe eshte ne databaze");
                    }
                }
            }
        }

        //kthehet ne formen LogIn
        private void button1_Click(object sender, EventArgs e)
        {
            var logInForm = new Login();
            this.Hide();
            logInForm.ShowDialog();
        }
    }
}
