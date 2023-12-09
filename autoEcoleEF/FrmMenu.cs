using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmMenu : Form
    {
        private AUTOECOLEEntities mesDonneesEF;
        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonneesEF = new AUTOECOLEEntities();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

    

        private void gererVehicule_Click(object sender, EventArgs e)
        {
            FrmGererVehicule f1 = new FrmGererVehicule(this.mesDonneesEF);
            f1.MdiParent = this;
            f1.Show();
        }

    

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeVehicule fl = new FrmListeVehicule(this.mesDonneesEF);
            fl.MdiParent = this;
            fl.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutLecon fa = new FrmAjoutLecon(this.mesDonneesEF);
            fa.MdiParent = this;
            fa.Show();
        }

        private void validerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValiderLecon fv = new FrmValiderLecon(this.mesDonneesEF);
            fv.MdiParent = this;
            fv.Show();
        }

     
    }
    




}
