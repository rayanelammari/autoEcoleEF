using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace autoEcoleEF
{
    public partial class FrmValiderLecon : Form
    {
        private AUTOECOLEEntities mesDonneesEF;
        public FrmValiderLecon(AUTOECOLEEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF=mesDonneesEF;
            this.bdgSLecon.DataSource= mesDonneesEF.lecon.ToList();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSLecon.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }
    }
}
