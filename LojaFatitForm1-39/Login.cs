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
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool Validimi()
        {
            if(txtUsername.Text=="")
            {
                MessageBox.Show("Ju lutem! Jepeni username.");
                return false;
            }
            if(txtPassword.Text=="")
            {
                MessageBox.Show("Ju lutem! Jepeni passwordin.");
                return false;
            }

            return true;
        }

        private void PastroFushat()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PastroFushat();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            if(Validimi())
            {
                var context = new LojaContext();                
                var lojtari = (from l in context.Lojtaret
                           where l.Username == txtUsername.Text
                           select l).FirstOrDefault();

                if (lojtari != null)
                {
                    string password = Enkriptimi.Md5(txtPassword.Text);

                    var lojt = (from l in context.Lojtaret
                                   where l.Username == txtUsername.Text && l.Password == password
                                   select l).FirstOrDefault();

                    if(lojt!=null)
                    {
                        if (lojtari.Statusi == 1)
                        {
                            this.Hide();
                            var admForm = new Admin();
                            admForm.ShowDialog();

                        }
                        else
                        {
                            this.Hide();
                            var tiketaForm = new Tickets();
                            UserValidimi.username = txtUsername.Text;
                            tiketaForm.ShowDialog();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Keni gabuar fjalekalimin.");
                        txtPassword.Clear();
                    }
                }
                else
                {
                    PastroFushat();
                    MessageBox.Show("Nuk egziston ky account");
                }
            }


        }

        //Link qe qon ne formen changPassword dhe e percjell username
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ju lutem!Per ndrrim Passwordi duhet te jepni Username");
            }
            else
            {
                UserValidimi.username = txtUsername.Text;
                var context = new LojaContext();
                var lojtari =(from l in context.Lojtaret
                                    where l.Username == UserValidimi.username
                                    select l).FirstOrDefault();

                if (lojtari != null)
                {
                    this.Hide();
                    var changeForm = new ChangePassword();
                    changeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ky username nuk egziston.");
                }
               
            }
        }

        //btnClose
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult pergjigja = MessageBox.Show("A deshironi te dilni prej Aplikacioni ?", "Exit", MessageBoxButtons.YesNo);
            if (pergjigja == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
