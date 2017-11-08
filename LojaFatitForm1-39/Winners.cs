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
    public partial class Winners : Form
    {
        public Winners()
        {
            InitializeComponent();
        }

        //kur selektohet gjiro e merr vlerene  id gjiros per me zgjedh nr e qellumeve brenda kesaj gjiro
        private int? GjiroId;
        private int? nrQellumeve;

        private int? CaktoNrQelluemve(ComboBox cmbNrQellumeve)
        {
            switch(cmbNrQellumeve.SelectedItem)
            {
                case "4":nrQellumeve = 4;break;
                case "5":nrQellumeve = 5;break;
                case "6":nrQellumeve = 6;break;
                case "7":nrQellumeve = 7;break;
            }

            return nrQellumeve;
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

        //Mbush grid me nrqellumeve te caktuar
        private void FillGridWithSelectedNrQellumeve()
        {
            using (var context = new LojaContext())
            {
                var tiketat = (from t in context.Tiketat
                                where t.NrQellumeve==nrQellumeve
                                select new
                                {
                                    t.TiketaID,
                                    t.Lojtari.Emri,
                                    t.Lojtari.Mbiemri,
                                    t.Lokacioni,
                                    t.NrQellumeve   
                                }
                                
                                ).ToList();
                dataGridView1.DataSource = tiketat;
            }
        }

        //Mbush grid me gjiro te caktuar
        private void FillGridWithSelectedGjiro()
        {
            using (var context = new LojaContext())
            {
                var tiketat = (from t in context.Tiketat
                               where t.GjiroID == GjiroId && t.NrQellumeve>3
                               select new
                               {
                                   t.TiketaID,
                                   t.Lojtari.Emri,
                                   t.Lojtari.Mbiemri,
                                   t.Lokacioni,
                                   t.NrQellumeve
                               }

                                ).ToList();
                dataGridView1.DataSource = tiketat;
            }
        }

        //Mbush grid me gjiro te caktuar dhe nr e qellumeve te caktuar
        private void FillGridWithSelectedGjiroAndNrQellumeve()
        {
            using (var context = new LojaContext())
            {
                var tiketat = (from t in context.Tiketat
                               where t.GjiroID == GjiroId && t.NrQellumeve==nrQellumeve
                               select new
                               {
                                   t.TiketaID,
                                   t.Lojtari.Emri,
                                   t.Lojtari.Mbiemri,
                                   t.Lokacioni,
                                   t.NrQellumeve
                               }

                                ).ToList();
                dataGridView1.DataSource = tiketat;
            }
        }

        //autmatikisht si hapet forma e mbush me te gjitha tiketat fituese
        private void FillGridFituesit()
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
                                   t.NrQellumeve
                               }

                                ).ToList();
                dataGridView1.DataSource = tiketat;
            }
        }

        //load mbush combo box me te dhena dhe gridin
        private void Winners_Load(object sender, EventArgs e)
        {
            FillCheckBox();
            FillGridFituesit();
            comboBoxGjiro.SelectedIndex = -1;
            comboBoxNrQellumeve.SelectedIndex = -1;
            
        }

        //kthehet ne formen e adminit
        private void btnKthehu_Click(object sender, EventArgs e)
        {
            var admForm = new Admin();
            this.Hide();
            admForm.ShowDialog();
        }

        //kur ndryshohet ose slektohet diqka tjeter ne nrqellumeve combobox
        private void comboBoxNrQellumeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nrQellumeve = CaktoNrQelluemve(comboBoxNrQellumeve);
                if (GjiroId!=null)
                {
                     FillGridWithSelectedGjiroAndNrQellumeve();

                }
                else
                {
                    FillGridWithSelectedNrQellumeve();
                }
               
            }
            catch { }
        }

        //kur ndryshohet ose slektohet diqka tjeter ne gjiro  combobox
        private void comboBoxGjiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GjiroId = int.Parse(comboBoxGjiro.SelectedValue.ToString());
                if(nrQellumeve!=null)
                {
                    FillGridWithSelectedGjiroAndNrQellumeve();
                }
                else
                {
                    FillGridWithSelectedGjiro();
                }
            }
            catch { }

        }
    }
}
