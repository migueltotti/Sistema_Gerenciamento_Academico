using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace AcademicoAppV1;

public partial class FormAluno : MaterialForm
{
    #region Variaveis

    private const string alunosFileName = "Data/alunos_data.txt";
    private bool isEditMode = false;
    private int indexSelecionado = 0;

    #endregion

    #region Metodos
    public FormAluno()
    {
        InitializeComponent();
    }

    private void LimpaCampos()
    {
        isEditMode = false;
        foreach (var field in tabPageCadastro.Controls)
        {
            if (field is MaterialTextBoxEdit tb)
                tb.Text = string.Empty;
            if (field is MaterialMaskedTextBox mtb)
                mtb.Text = string.Empty;
            if (field is MaterialComboBox cb)
                cb.SelectedIndex = 0;
        }
    }

    private void SalvarAluno()
    {
        var aluno = $"{tbMatricula.Text};" +
                $"{mtbDataNascimento.Text};" +
                $"{tbNome.Text};" +
                $"{tbEndereco.Text};" +
                $"{tbBairro.Text};" +
                $"{tbCidade.Text};" +
                $"{cbUF.Text};" +
                $"{tbSenha.Text};";

        if (!isEditMode)
        {
            using var sw = new StreamWriter(alunosFileName, true);

            sw.WriteLine(aluno);
        }
        else
        {
            var fileLines = File.ReadAllLines(alunosFileName);

            fileLines[indexSelecionado] = aluno;

            File.WriteAllLines(alunosFileName, fileLines);

            isEditMode = false;
        }
    }

    private bool ValidaFormulario()
    {
        var erro = "";

        foreach (var field in tabPageCadastro.Controls)
        {
            if (field is MaterialTextBoxEdit tb)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    erro += $"- {tb.Hint} é obrigatório!\n";
                }
            }
            if (field is MaterialMaskedTextBox mtb)
            {
                if (string.IsNullOrWhiteSpace(mtb.Text) || mtb.Text.Contains("_"))
                {
                    erro += $"- {mtb.Hint} é obrigatório!\n";
                }
            }
            if (field is MaterialComboBox cb)
            {
                if (cb.SelectedIndex == 0)
                {
                    erro += $"- {cb.Hint} é obrigatório!\n";
                }
            }
        }

        if (!string.IsNullOrWhiteSpace(erro))
        {
            MessageBox.Show($"Atenção aos campos obrigatórios:\n\n{erro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void CarregaAlunosListView()
    {
        Cursor.Current = Cursors.WaitCursor;

        lvwAlunos.View = View.Details;

        lvwAlunos.Columns.Clear();
        lvwAlunos.Items.Clear();
        lvwAlunos.Columns.Add("Matrícula");
        lvwAlunos.Columns.Add("Data Nasc.");
        lvwAlunos.Columns.Add("Nome");
        lvwAlunos.Columns.Add("Endereço");
        lvwAlunos.Columns.Add("Bairro");
        lvwAlunos.Columns.Add("Cidade");
        lvwAlunos.Columns.Add("UF");
        lvwAlunos.Columns.Add("Senha");

        lvwAlunos.FullRowSelect = true;

        var alunos = File.ReadAllLines(alunosFileName);

        foreach (var aluno in alunos)
        {
            var dados = aluno.Split(';');

            lvwAlunos.Items.Add(new ListViewItem(dados));
        }

        lvwAlunos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        Cursor.Current = Cursors.Default;
    }

    private void EditarAluno()
    {
        if (lvwAlunos.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecione um aluno para editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        indexSelecionado = lvwAlunos.SelectedItems[0].Index;
        var alunos = lvwAlunos.SelectedItems[0];

        tbMatricula.Text = alunos.SubItems[0].Text;
        mtbDataNascimento.Text = alunos.SubItems[1].Text;
        tbNome.Text = alunos.SubItems[2].Text;
        tbEndereco.Text = alunos.SubItems[3].Text;
        tbBairro.Text = alunos.SubItems[4].Text;
        tbCidade.Text = alunos.SubItems[5].Text;
        cbUF.Text = alunos.SubItems[6].Text;
        tbSenha.Text = alunos.SubItems[7].Text;

        tabControlCadastro.SelectedIndex = 0;
        tbMatricula.Focus();

        isEditMode = true;
    }

    private void RemoveAluno()
    {
        if (lvwAlunos.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecione um aluno para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show(
            "Deseja realmente excluir o aluno selecionado?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }

        indexSelecionado = lvwAlunos.SelectedItems[0].Index;

        var alunos = File.ReadAllLines(alunosFileName).ToList();

        alunos.RemoveAt(indexSelecionado);

        File.WriteAllLines(alunosFileName, alunos);
    }

    #endregion

    #region Eventos

    private void btnNovo_Click(object sender, EventArgs e)
    {
        LimpaCampos();

        tabControlCadastro.SelectedIndex = 0;

        tbMatricula.Focus();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(
            "Informações não salvas serão perdidas!\n" +
            "Deseja realmente cancelar ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            LimpaCampos();
            tabControlCadastro.SelectedIndex = 1;
            isEditMode = false;
        }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (ValidaFormulario())
        {
            SalvarAluno();
            MessageBox.Show("Aluno salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
            tabControlCadastro.SelectedIndex = 1;
        }
    }

    private void tabPageConsulta_Enter(object sender, EventArgs e)
    {
        CarregaAlunosListView();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        EditarAluno();
    }

    private void lvwAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        EditarAluno();
    }
    #endregion

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        RemoveAluno();

        CarregaAlunosListView();
    }
}
