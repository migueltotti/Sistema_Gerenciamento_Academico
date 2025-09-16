using ReaLTaiizor.Forms;

namespace AcademicoAppV1
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAluno = new FormAluno();

            // Definindo que o FormPrincipal é o pai de FormAluno
            formAluno.MdiParent = this;
            formAluno.Show();
        }
    }
}
