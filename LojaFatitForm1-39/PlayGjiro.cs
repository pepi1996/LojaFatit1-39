using LojaFatitForm1_39.Modeli;
using LojaFatitForm1_39.Classes;
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
    public partial class PlayGjiro : Form
    {
        public PlayGjiro()
        {
            InitializeComponent();
        }

        private int? gjiroid;

        //gjiroId merr vleren e qelules selektume edhe txtbox mushen me nr e gjenerum
        private void dataGridGjiro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridGjiro.Rows[e.RowIndex];
                    gjiroid = int.Parse(row.Cells["GjiroID"].Value.ToString());
                    txtNr1.Text = row.Cells["Numri1"].Value.ToString();
                    txtNr2.Text = row.Cells["Numri2"].Value.ToString();
                    txtNr3.Text = row.Cells["Numri3"].Value.ToString();
                    txtNr4.Text = row.Cells["Numri4"].Value.ToString();
                    txtNr5.Text = row.Cells["Numri5"].Value.ToString();
                    txtNr6.Text = row.Cells["Numri6"].Value.ToString();
                    txtNr7.Text = row.Cells["Numri7"].Value.ToString();
                }
                catch
                {
                    PastroFushat();
                }


            }
        }

        //kthehet ne Admin form->btnKthehu
        private void button1_Click(object sender, EventArgs e)
        {
            var admForm = new Admin();
            this.Hide();
            admForm.ShowDialog();
        }

        private int[] numratFitues = new int[7];

        //Gjeneron 7 nr ne menyre te rastesishme
        private void GjenerimiNumrave()
        {
         //   numratFitues[0] = 1;
         //   numratFitues[1] = 2;
         //   numratFitues[2] = 3;
         //   numratFitues[3] = 4;
         //   numratFitues[4] = 5;
         //   numratFitues[5] = 6;
         //   numratFitues[6] = 7;

           Random rand = new Random();
           for (var i = 0; i < numratFitues.Length; i++)
           {
               numratFitues[i] = rand.Next(1, 40);
               for (var k = i - 1; k > -1; k--)
               {
                   while (true)
                   {
                       if (!(numratFitues[k] == numratFitues[i]))
                       {
                           break;
                       }
                       else
                       {
                           numratFitues[i] = rand.Next(1, 40);
                       }
                   }
               }
           }
        }

        //Mbush gridin me gjiro
        private void FillGridGjiro()
        {
            using (var context = new LojaContext())
            {
                var gjiro = (from gj in context.Gjirot
                             select new
                             {
                                 gj.GjiroID,
                                 gj.Emri,
                                 gj.Date,
                                 gj.numri1,
                                 gj.numri2,
                                 gj.numri3,
                                 gj.numri4,
                                 gj.numri5,
                                 gj.numri6,
                                 gj.numri7
                             }).ToList();

                dataGridGjiro.DataSource = gjiro;
            }
        }

        //Load i formes
        private void LuajGjiro_Load(object sender, EventArgs e)
        {
            PastroFushat();
            FillGridGjiro();
        }

        private void PastroFushat()
        {
            txtNr1.Clear();
            txtNr2.Clear();
            txtNr3.Clear();
            txtNr4.Clear();
            txtNr5.Clear();
            txtNr6.Clear();
            txtNr7.Clear();
        }         
        
        //gjeneron numrat dhe i mbush si dhe gjan fituesit
        private void btngjenero_Click(object sender, EventArgs e)
        {
            
            using (var context = new LojaContext())
            {
                if (gjiroid != null)
                {
                    //merr id e gjiros qe ka selektu edhe me kqyr qe gjiro nuk u lujt
                    var gjiro = (from gj in context.Gjirot
                                  where gj.GjiroID == gjiroid && gj.numri1 == null
                                  select gj).FirstOrDefault();

                    if(gjiro!=null)
                    {
                        //gjeneron nr
                        GjenerimiNumrave();
                        //texBox i mbush me te dhena qe u gjeneru gjiro
                        txtNr1.Text = Convert.ToString(numratFitues[0]);
                        txtNr2.Text = Convert.ToString(numratFitues[1]);
                        txtNr3.Text = Convert.ToString(numratFitues[2]);
                        txtNr4.Text = Convert.ToString(numratFitues[3]);
                        txtNr5.Text = Convert.ToString(numratFitues[4]);
                        txtNr6.Text = Convert.ToString(numratFitues[5]);
                        txtNr7.Text = Convert.ToString(numratFitues[6]);

                        //shton ne db nr e gjeneruar
                        gjiro.numri1 = numratFitues[0];
                        gjiro.numri2 = numratFitues[1];
                        gjiro.numri3 = numratFitues[2];
                        gjiro.numri4 = numratFitues[3];
                        gjiro.numri5 = numratFitues[4];
                        gjiro.numri6 = numratFitues[5];
                        gjiro.numri7 = numratFitues[6];

                        context.SaveChanges();
                        MessageBox.Show("Numrat fitues u shtuan ne xhiro");
                        FillGridGjiro();

                        //shkon ne klasen fituesit metoden gjejfituesit dhe gjan fituesit dhe i shton en databaze
                        Fituesit.GjejFituesit(numratFitues, gjiroid);
                    }
                    else
                    {
                        MessageBox.Show("Xhiro u lujt ma heret ");
                    }
                   
                }
            }

            
        }

    }
}
