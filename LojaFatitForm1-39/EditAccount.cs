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
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        //kur selektohet cell(qelula) e merr vleren e id te Lojtarit nese bohet ndryshim 
        private int selectedEditID;

        //Load pastro fushat edhe mbush gridin
        private void EditAccount_Load(object sender, EventArgs e)
        {
            FillGridLojtaret();
            PastroFushat();
        }

        //validon fushat nese nuk plotesohet najkusht kthen false perndryshe truee.
        private bool Validimi()
        {
            if (txtEmriEdit.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni emrin.");
                return false;
            }
            if (txtMbiemriEdit.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni mbiemrin.");
                return false;
            }
            if (txtMoshaEdit.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni mosha.");
                return false;
            }
            if (txtUsernameEdit.Text == "")
            {
                MessageBox.Show("Ju lutem! Plotesojeni mosha.");
                return false;
            }
            if (rBtnAdminEdit.Checked == false && rBtnUserEdit.Checked == false)
            {
                MessageBox.Show("Ju lutem! Zgjedheni Statusin.");
                return false;
            }
            if (int.Parse(txtMoshaEdit.Text) < 18)
            {
                MessageBox.Show("Nuk lejohet te regjistroni lojtar me te vogel se 18 vjet");
                return false;
            }

            return true;
        }

        //ben pastrimin e textboxave
        private void PastroFushat()
        {
            txtEmriEdit.Clear();
            txtMbiemriEdit.Clear();
            txtMoshaEdit.Clear();
            txtUsernameEdit.Clear();
            rBtnAdminEdit.Checked = false;
            rBtnUserEdit.Checked = false;
        }

        //Mbush gridin me te dhena
        private void FillGridLojtaret()
        {
            using (var context = new LojaContext())
            {
                var lojtaret = (from g in context.Lojtaret
                              select new
                              {
                                  
                                  g.LojtariID,
                                  g.Emri,
                                  g.Mbiemri,
                                  g.Mosha,
                                  g.Username,
                                  g.Password,
                                  Statusi=(g.Statusi==1?"Admin":"User"),
                              }).ToList();

                dataGridLojtaret.DataSource = lojtaret;  
                
            }           
        }

        //Kur klikohen Cell athere mbush fushat me te dhena
        private void dataGridLojtaret_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridLojtaret.Rows[e.RowIndex];
                selectedEditID = int.Parse(row.Cells["LojtariID"].Value.ToString());
                txtEmriEdit.Text = row.Cells["Emri"].Value.ToString();
                txtMbiemriEdit.Text = row.Cells["Mbiemri"].Value.ToString();
                txtMoshaEdit.Text = row.Cells["Mosha"].Value.ToString();
                txtUsernameEdit.Text = row.Cells["Username"].Value.ToString();
                var statusi = row.Cells["Statusi"].Value.ToString();
                
                if(statusi == "Admin")
                {
                    rBtnAdminEdit.Checked = true;
                }
                else
                {
                    rBtnUserEdit.Checked = true;
                }
            }
        }

        //editimi i dhenave
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validimi())
                {
                    using (var context = new LojaContext())
                    {
                        var Id = int.Parse(dataGridLojtaret.CurrentRow.Cells[0].Value.ToString());
                        var lojtari = context.Lojtaret.Where(l => l.LojtariID == Id).FirstOrDefault();
                        lojtari.Emri = txtEmriEdit.Text;
                        lojtari.Mbiemri = txtMbiemriEdit.Text;
                        lojtari.Mosha = int.Parse(txtMoshaEdit.Text);
                        lojtari.Statusi = rBtnAdminEdit.Checked == true ? 1 : 0;
                        lojtari.Username = txtUsernameEdit.Text;

                        context.SaveChanges();
                        MessageBox.Show("Te dhenat u modifikuan me sukses");
                        PastroFushat();
                        FillGridLojtaret();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format i gabuar.");
                PastroFushat();
            }
            
        }

        //fshirjen e dhenave te fushave
        private void btnClear_Click(object sender, EventArgs e)
        {
            PastroFushat();
        }

        //mbylljen e app
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult pergjigja = MessageBox.Show("A deshironi te dilni prej Aplikacioni ?", "Exit", MessageBoxButtons.YesNo);
            if(pergjigja==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        //ben fshirje e lojtareve
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult pergjigja= MessageBox.Show("A deshironi te fshini lojtarin ?", "Delete", MessageBoxButtons.YesNo);

            if(pergjigja==DialogResult.Yes)
            {
                using (var context = new LojaContext())
                {
                    var Id = int.Parse(dataGridLojtaret.CurrentRow.Cells[0].Value.ToString());
                    var lojtari = context.Lojtaret.Where(l => l.LojtariID == Id).FirstOrDefault();

                    context.Lojtaret.Remove(lojtari);
                    context.SaveChanges();
                    FillGridLojtaret();
                    PastroFushat();
                }
            }
           

        }

        //kthehet ne fq kryesore AdminForm
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admForm = new Admin();
            admForm.ShowDialog();
        }

        //Mbush gridin me te dhena kur kerkohen ne search box
        private void FillGridInSearch(string searchText = null)
        {
            using (var context = new LojaContext())
            {
                var lojtaret = (from l in context.Lojtaret.AsNoTracking()
                                where (searchText != null ? (
                                l.Emri.ToLower().StartsWith(searchText) ||
                                l.Mbiemri.ToLower().StartsWith(searchText) ||
                                l.Username.ToLower().StartsWith(searchText)
                                ) : true)
                                orderby l.LojtariID ascending
                                select new
                                {

                                    l.LojtariID,
                                    l.Emri,
                                    l.Mbiemri,
                                    l.Mosha,
                                    l.Username,
                                    l.Password,
                                    Statusi = (l.Statusi == 1 ? "Admin" : "User"),
                                }).ToList();
                dataGridLojtaret.DataSource = lojtaret;
            }
        }

        //kur teksti ndryshon ne textbox thirret metoda me kerku
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGridInSearch(txtSearch.Text.ToLower());
        }
    }
}

