using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmGererVehicule : Form
    {
        private AUTOECOLEEntities mesDonneesEF;
        public FrmGererVehicule(AUTOECOLEEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF= mesDonneesEF;
            this.bdgVehicule.DataSource = mesDonneesEF.vehicule.ToList();

        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNumero.ReadOnly = false;
            this.txtModele.ReadOnly = false;
            this.txtCouleur.ReadOnly = false;
        }


        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text=="" || txtModele.Text=="" || txtCouleur.Text=="")
            {
                MessageBox.Show("Il faut remplir tout les champs");
                bdgVehicule.CancelEdit();
                
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtModele.Text == "" || txtCouleur.Text == "")
            {
                MessageBox.Show("Il faut remplir tout les champs");
                bdgVehicule.CancelEdit();

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new AUTOECOLEEntities())
            {
                var idASupprimer = Convert.ToString(txtNumero.Text);
                var entierASupprimer = context.vehicule.FirstOrDefault(el => el.numImma == idASupprimer);

                if (entierASupprimer != null)
                {
                    context.vehicule.Remove(entierASupprimer);
                    context.SaveChanges();
                    bdgVehicule.RemoveCurrent();
                    MessageBox.Show("Enregistrement supprimé");
                }
            }
        }
        private vehicule newVehicule()
        {
            vehicule newVehicule = new vehicule();
            newVehicule.numImma = txtNumero.Text;
            newVehicule.modele = txtModele.Text;
            newVehicule.couleur = txtCouleur.Text;
            return newVehicule;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bdgVehicule.EndEdit();
            try
            {
                this.mesDonneesEF.vehicule.Add(newVehicule());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement :   {ex.Message}");

            }
        }

        private void FrmGererVehicule_Load(object sender, EventArgs e)
        {

        }

        private void bdNav2_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
