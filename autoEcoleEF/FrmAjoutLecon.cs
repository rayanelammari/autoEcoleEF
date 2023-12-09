using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmAjoutLecon : Form
    {
        private AUTOECOLEEntities mesDonneeEF;
        public FrmAjoutLecon(AUTOECOLEEntities mesDonneeEF)
        {
            InitializeComponent();
            this.mesDonneeEF = mesDonneeEF;
            this.bdgEleve.DataSource= this.mesDonneeEF.eleve.ToList();
            for (int i = 8; i < 20; i++)
                this.cmbHeure.Items.Add(i);
        }

        public int newNumLecon()
        {
            int n;
            int dernier = (from ra in this.mesDonneeEF.lecon select ra.id).Max();
            n = dernier + 1;
            return n;
        }

        private lecon nouvelleLecon()
        {
            int n = newNumLecon();

            eleve el = (eleve)cmbEleve.SelectedValue;
            DateTime d = this.dtLecon.Value;
            int heureLecon = Convert.ToInt32(this.cmbHeure.SelectedItem);
            int nbHeures = 1;
            if(this.rdButton2.Checked)
                nbHeures= 2;
            lecon l = new lecon();
            l.date= d;
            l.heure= heureLecon;
            l.duree= nbHeures;
            l.id= n;
            l.eleve= el;
            return l;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonneeEF.lecon.Add(nouvelleLecon());
            this.mesDonneeEF.SaveChanges();
            MessageBox.Show("Enregistrement validé");
        }
    }
}
