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
    public partial class OpenGjiro : Form
    {
        public OpenGjiro()
        {
            InitializeComponent();
        }

        //Validimi 
        private bool Validimi()
        {
            if(txtEmri.Text=="")
            {
                MessageBox.Show("Ju lutem plotesoni emrin.");
                return false;
            }
            return true;
        }

        //Mbushja e gridit
        private void FillGridGjiro()
        {
            using (var context =new LojaContext())
            {
                var gjiro = (from gj in context.Gjirot
                                select new
                                {
                                    gj.GjiroID,
                                    gj.Emri,
                                    gj.Date
                                }).ToList();

                dataGridGjirot.DataSource = gjiro;
            }
        }

        //Load ku mbushet me te dhena gridi te bohet clear txtEmri kur hapet Forma
        private void Gjiro_Load(object sender, EventArgs e)
        {
            FillGridGjiro();
            txtEmri.Clear();
        }

        //Butoni kthehu -> te kthen en forme kryesore
        private void button1_Click(object sender, EventArgs e)
        {
            var admForm = new Admin();
            this.Hide();
            admForm.ShowDialog();
        }

        // e hap gjiron nese plotesohen kushtet
        private void btnHapeGjiro_Click(object sender, EventArgs e)
        {
            if(Validimi())
            {
                using (var context =new LojaContext())
                {
                    var gjiro = (from gj in context.Gjirot
                                 where gj.Emri.Replace(" ", "").ToLower() == txtEmri.Text.Replace(" ", "").ToLower()
                                 select gj).FirstOrDefault();

                    if(gjiro==null)
                    {
                        var gjiroNew  = new Gjiro();
                        gjiroNew.Emri = txtEmri.Text;
                        gjiroNew.Date = Convert.ToDateTime(dataGjiro.Value.ToString("MM-dd-yyyy"));


                        context.Gjirot.Add(gjiroNew);
                        context.SaveChanges();
                        MessageBox.Show("Gjiro u hap me sukses");
                        FillGridGjiro();
                        txtEmri.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Nuk lejohet gjiro me emer te njejte");
                        txtEmri.Clear();
                    }
                    
                }
            }

        }
    }
}
