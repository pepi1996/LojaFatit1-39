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
using LojaFatitForm1_39.Classes;

namespace LojaFatitForm1_39
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        //btnLogOut->kthen ne formen Log In
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logForm = new Login();
            logForm.ShowDialog();
        }

        //mesazhi kur nr i jepur nuk ploteson kriteret 
        private void Mesazhi()
        {
            MessageBox.Show("Nuk lejohet nr me i vogel se 1 dhe me i madh se 39 ");
        }

        private bool Validimi()
        {
            if(txtLokacioni.Text=="")
            {
                MessageBox.Show("Ju lutem Plotesoni Lokacionin");
                return false;
            }
            if (txtNr1.Text == "")
            {
                MessageBox.Show("Ju lutem Plotesoni Nr1");
                return false;
            }
            if (txtNr2.Text == "")
            {
                MessageBox.Show("Ju lutem Plotesoni Nr2");
                return false;
            }
            if (txtNr3.Text == "")
            {
                MessageBox.Show("Ju lutem Plotesoni Nr3");
                return false;
            }
            if (txtNr4.Text == "")
            {
                MessageBox.Show("Ju lutem Plotesoni Nr4");
                return false;
            }
            if (txtNr5.Text == "")
            {
                MessageBox.Show("Ju lutem Plotesoni Nr5");
                return false;
            }
            if (txtNr6.Text == "")
            {
                MessageBox.Show("Ju lutem Plotesoni Nr6");
                return false;
            }
            if (txtNr7.Text == "")
            {
                MessageBox.Show("Ju lutem Plotesoni Nr7");
                return false;
            }
            if (int.Parse(txtNr1.Text)<=0 || int.Parse(txtNr1.Text) >= 40)
            {
                Mesazhi();
                return false;
            }
            if (int.Parse(txtNr2.Text) <= 0 || int.Parse(txtNr2.Text) >= 40)
            {
                Mesazhi();
                return false;
            }
            if (int.Parse(txtNr3.Text) <= 0 || int.Parse(txtNr3.Text) >= 40)
            {
                Mesazhi();
                return false;
            }
            if (int.Parse(txtNr4.Text) <= 0 || int.Parse(txtNr4.Text) >= 40)
            {
                Mesazhi();
                return false;
            }
            if (int.Parse(txtNr5.Text) <= 0 || int.Parse(txtNr5.Text) >= 40)
            {
                Mesazhi();
                return false;
            }
            if (int.Parse(txtNr6.Text) <= 0 || int.Parse(txtNr6.Text) >= 40)
            {
                Mesazhi();
                return false;
            }
            if (int.Parse(txtNr7.Text) <= 0 || int.Parse(txtNr7.Text) >= 40)
            {
                Mesazhi();
                return false;
            }
            if(ValidimiNumrave())
            {
                MessageBox.Show("Nuk lejhen nr te njejte");
                return false;
            }
            return true;
        }
        
        //validimi i nr qe mos me lene nr te njejte
        private bool ValidimiNumrave()
        {
            int[] numrat = new int[7];
            numrat[0] = int.Parse(txtNr1.Text);
            numrat[1] = int.Parse(txtNr2.Text);
            numrat[2] = int.Parse(txtNr3.Text);
            numrat[3] = int.Parse(txtNr4.Text);
            numrat[4] = int.Parse(txtNr5.Text);
            numrat[5] = int.Parse(txtNr6.Text);
            numrat[6] = int.Parse(txtNr7.Text);

            for(var i=0;i<7;i++)
            {
                for(var j=0;j<7;j++)
                {
                    if(i!=j)
                    {
                        if(numrat[i]==numrat[j])
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        //Ben pastrimin e fushave te textBox-ave
        private void PastroFushat()
        {
            txtLokacioni.Clear();
            txtNr1.Clear();
            txtNr2.Clear();
            txtNr3.Clear();
            txtNr4.Clear();
            txtNr5.Clear();
            txtNr6.Clear();
            txtNr7.Clear();
        }

        //Load i formes si thapet pastrohen fushat edhe mbushet gridi
        private void Tiketa_Load(object sender, EventArgs e)
        {
            PastroFushat();
            FillGridTiketa();
            FillCheckBox();
            comboBoxGjiro.SelectedIndex = -1;
        }

        //Mbushja e gridit me te dhena
        private void FillGridTiketa()
        {
            using (var context = new LojaContext())
            {
                var lojtari = (from l in context.Lojtaret
                               where l.Username == UserValidimi.username
                               select l).FirstOrDefault();

                var tiketat = (from t in context.Tiketat 
                               where t.LojtariID==lojtari.LojtariID
                               select new
                               {

                                   t.TiketaID,
                                   t.Lojtari.Emri,
                                   t.Lojtari.Mbiemri,
                                   t.Lokacioni,
                                   t.Statusi,
                                   t.NrQellumeve,
                                   t.numri1,
                                   t.numri2,
                                   t.numri3,
                                   t.numri4,
                                   t.numri5,
                                   t.numri6,
                                   t.numri7
                               }).ToList();
                dataGridView1.DataSource = tiketat;
            }
        }

        //Mbush grid me gjiro te caktuar
        private void FillGridWithSelectedGjiro(int Id)
        { 
            using (var context = new LojaContext())
            {
                var lojtari = (from l in context.Lojtaret
                               where l.Username == UserValidimi.username
                               select l).FirstOrDefault();

                var tiketat = (from t in context.Tiketat
                               where t.GjiroID == Id && t.LojtariID==lojtari.LojtariID
                               select new
                               {
                                   t.TiketaID,
                                   t.Lojtari.Emri,
                                   t.Lojtari.Mbiemri,
                                   t.Lokacioni,
                                   t.Statusi,
                                   t.NrQellumeve,
                                   t.numri1,
                                   t.numri2,
                                   t.numri3,
                                   t.numri4,
                                   t.numri5,
                                   t.numri6,
                                   t.numri7
                               }).ToList();
                dataGridView1.DataSource = tiketat;
            }
        }

        //btnLuaj nese plotesohen ksuhetet athere e luan tiketen
        private void btnLuaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validimi())
                {
                    using (var context = new LojaContext())
                    {
                        var lojtari = (from l in context.Lojtaret
                                       where l.Username == UserValidimi.username
                                       select l).FirstOrDefault();

                        var gjiro = (from gj in context.Gjirot
                                     where gj.numri1 == null
                                     orderby gj.GjiroID descending
                                     select gj).FirstOrDefault();

                        if (gjiro != null)
                        {
                            var tiketa = new Modeli.Tiketa();

                            tiketa.GjiroID = gjiro.GjiroID;
                            tiketa.LojtariID = lojtari.LojtariID;
                            tiketa.Lokacioni = txtLokacioni.Text;
                            tiketa.numri1 = int.Parse(txtNr1.Text);
                            tiketa.numri2 = int.Parse(txtNr2.Text);
                            tiketa.numri3 = int.Parse(txtNr3.Text);
                            tiketa.numri4 = int.Parse(txtNr4.Text);
                            tiketa.numri5 = int.Parse(txtNr5.Text);
                            tiketa.numri6 = int.Parse(txtNr6.Text);
                            tiketa.numri7 = int.Parse(txtNr7.Text);

                            context.Tiketat.Add(tiketa);
                            context.SaveChanges();
                            MessageBox.Show("Tiketa eshte luajtur me sukses");
                            PastroFushat();
                            FillGridTiketa();
                        }
                        else
                        {
                            MessageBox.Show("Nuk ka gjiro te hapur");
                            PastroFushat();
                        }
                    }
                }
            }
            catch(FormatException f)
            {
                MessageBox.Show("Format i gabuar.");
                PastroFushat();
            }

           

        }

        //mbush checkbox prej tabeles gjiro DisplayMember->emrin ndersa si ValueMember->GjiroID
        private void FillCheckBox()
        {
            using (var context = new LojaContext())
            {
                var gjiro = context.Gjirot.ToList();
                comboBoxGjiro.DataSource = gjiro;
                comboBoxGjiro.DisplayMember = "Emri";
                comboBoxGjiro.ValueMember = "GjiroID";

            }
        }

        //mbush gridin kur e zgjedh gjiron ne combo box
        private void comboBoxGjiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboBoxGjiro.SelectedValue.ToString());
                FillGridWithSelectedGjiro(id);
                ShtypjaNumratFitues(id);    
            }
            catch
            {}
        }

        //btnClose
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult pergjigja = MessageBox.Show("A deshironi te dilni prej Aplikacioni ?", "Exit", MessageBoxButtons.YesNo);
            if (pergjigja == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        //metode per paraqitjen e nr fitues kur zgjedhet gjiro
        private void ShtypjaNumratFitues(int IdGjiros)
        {
            var contex = new LojaContext();
            var gjiro = contex.Gjirot.Where(gj => gj.GjiroID == IdGjiros).FirstOrDefault();
            txtNum1.Text = gjiro.numri1.ToString();
            txtNum2.Text = gjiro.numri2.ToString();
            txtNum3.Text = gjiro.numri3.ToString();
            txtNum4.Text = gjiro.numri4.ToString();
            txtNum5.Text = gjiro.numri5.ToString();
            txtNum6.Text = gjiro.numri6.ToString();
            txtNum7.Text = gjiro.numri7.ToString();
        }
    }
}
