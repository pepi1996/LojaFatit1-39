using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaFatitForm1_39.Modeli;

namespace LojaFatitForm1_39
{
    public partial class PlayedTickets : Form
    {
        public PlayedTickets()
        {
            InitializeComponent();
        }

        //Mbush grid me te gjitha gjirot
        private void FillGridWithAllGjiro()
        {
            using (var context = new LojaContext())
            {
                var tiketat = (from t in context.Tiketat
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
                dataGridTiketatLuajtura.DataSource = tiketat;
            }
        }

        //Mbush grid me gjiro te caktuar
        private void FillGridWithSelectedGjiro(int Id)
        {
            using (var context = new LojaContext())
            {
                var tiketat = (from t in context.Tiketat
                               where t.GjiroID==Id
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
                dataGridTiketatLuajtura.DataSource = tiketat;
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

        //ben fshirjen e fushave dhe mbush gridin
        private void TiketatLuajtura_Load(object sender, EventArgs e)
        {
            FillGridWithAllGjiro();
            FillCheckBox();
            comboBoxGjiro.SelectedIndex = -1;
        }

        //ne rast se selektojme ndonje vlere ne checkbox athere mbushet gridi me gjiron perkatese
        private void comboBoxGjiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboBoxGjiro.SelectedValue.ToString());
                FillGridWithSelectedGjiro(id);
            }
            catch { }
                    
        }

        //btnKthehu ->kthehet te forma kryesore
        private void button1_Click(object sender, EventArgs e)
        {
            var admForm = new Admin();
            this.Hide();
            admForm.ShowDialog();
        }
    }
}
