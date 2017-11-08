using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaFatitForm1_39.Modeli;
using System.Windows.Forms;

namespace LojaFatitForm1_39.Classes
{
    static class Fituesit
    {
        public static void GjejFituesit(int[] numratFitues,int? gjiroId)
        {
            using (var context = new LojaContext())
            {
                var tiketat = (from t in context.Tiketat
                               where t.GjiroID==gjiroId
                               select t).ToList();

                int nrQellumeve;
                int[] tiketaLuajtur = new int[7];
                int Id;

                for (var i = 0; i < tiketat.Count; i++)
                {
                    tiketaLuajtur[0] = tiketat[i].numri1;
                    tiketaLuajtur[1] = tiketat[i].numri2;
                    tiketaLuajtur[2] = tiketat[i].numri3;
                    tiketaLuajtur[3] = tiketat[i].numri4;
                    tiketaLuajtur[4] = tiketat[i].numri5;
                    tiketaLuajtur[5] = tiketat[i].numri6;
                    tiketaLuajtur[6] = tiketat[i].numri7;
                    Id = tiketat[i].TiketaID;

                    nrQellumeve = 0;
                    for (var j = 0; j < 7; j++)
                    {
                        for (var k = 0; k < 7; k++)
                        {
                            if (tiketaLuajtur[j] == numratFitues[k])
                            {
                                nrQellumeve++;
                            }
                        }
                    }

                    ShtoDhenaFituesit(context, Id, nrQellumeve);
                }

            }

        }

        public static void ShtoDhenaFituesit(LojaContext context,int Id,int nrQellumeve)
        {
            var tiketa = (from t in context.Tiketat
                          where t.TiketaID == Id
                          select t).FirstOrDefault();
            tiketa.Statusi = nrQellumeve > 3 ? "Fitues" : "Jo Fitues";
            tiketa.NrQellumeve = nrQellumeve;
            context.SaveChanges();
        }

    }
}
