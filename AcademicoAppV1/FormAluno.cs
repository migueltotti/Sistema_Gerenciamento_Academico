using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace AcademicoAppV1
{
    public partial class FormAluno : MaterialForm
    {
        private const string alunosFileName = "alunos_data.txt";
        private bool isEditing = false;

        public FormAluno()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            isEditing = false;
            foreach(var field in tabPageCadastro.Controls)
            {
                if (field is MaterialTextBoxEdit tb)
                    tb.Text = string.Empty;
                if (field is MaterialMaskedTextBox mtb)
                    mtb.Text = string.Empty;
                if (field is MaterialComboBox cb)
                    cb.SelectedIndex = 0;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            tabControlCadastro.SelectedIndex = 0;

            tbMatricula.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Informações não salvas serão perdidas!\n" +
                "Deseja realmente cancelar ?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastro.SelectedIndex = 1;
            }
        }
    }
}
