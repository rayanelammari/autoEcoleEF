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
    public partial class FrmListeVehicule : Form
    {
        private AUTOECOLEEntities mesDonneesEF;
        public FrmListeVehicule(AUTOECOLEEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgVehicules.DataSource = mesDonneesEF.vehicule.ToList();

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            this.bdgVehicules.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }
    }
}
