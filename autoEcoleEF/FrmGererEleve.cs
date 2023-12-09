using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmGererEleve : Form
        
    {
        private AUTOECOLEEntities mesDonneesEF;
        public FrmGererEleve(AUTOECOLEEntities mesDonneesEF)
        {
            InitializeComponent();
            for (int i=0;i<30;i++)
            {
                this.cmbCredit.Items.Add(i);
            }
            
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceEleve.DataSource=mesDonneesEF.eleve.ToList();
        }

   

        private int getNumEleve()
        {
            var reqDernier = (from el in this.mesDonneesEF.eleve
                              orderby el.id descending
                              select el);
            eleve dernierEleve = reqDernier.First();
            int n = dernierEleve.id + 1;
            return n;
        }

       
        private eleve newEleve()
        {
            eleve newEleve = new eleve();
            newEleve.id = Convert.ToInt16(txtNumero.Text);
            newEleve.nom=txtNom.Text;
            newEleve.prenom=txtPrenom.Text;
            newEleve.adresse = txtAdresse.Text;
            newEleve.dateInscription = dtInscription.Value;
            return newEleve;
        }

        private void tsEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            try
            {
                this.mesDonneesEF.eleve.Add(newEleve());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }catch(Exception ex) 
            { 
                MessageBox.Show($"Erreur lors de l'enregistrement :   { ex.Message}");

            }
        }

       

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new AUTOECOLEEntities())
            {
                var idASupprimer = Convert.ToInt16(txtNumero.Text);
                var entierASupprimer = context.eleve.FirstOrDefault(el=>el.id==idASupprimer);

                if(entierASupprimer!= null) 
                {
                    context.eleve.Remove(entierASupprimer);
                    context.SaveChanges();
                    bdgSourceEleve.RemoveCurrent();
                    MessageBox.Show("Enregistrement supprimé");
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text = this.getNumEleve().ToString();

        
        }

       
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if(txtAdresse.Text== "" || txtNom.Text== "" || txtPrenom.Text == "")
            {
                MessageBox.Show("Il faut remplir tout les champs du nouvelle élève");
                bdgSourceEleve.CancelEdit();// annuler l'ajout.
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "" || txtNom.Text == "" || txtPrenom.Text == "")
            {
                MessageBox.Show("Il faut remplir tout les champs du nouvelle élève");
                bdgSourceEleve.CancelEdit();// annuler l'ajout.
            }
        }

        private void FrmGererEleve_Load(object sender, EventArgs e)
        {

        }
    }
}
