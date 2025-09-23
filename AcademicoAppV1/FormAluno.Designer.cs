namespace AcademicoAppV1
{
    partial class FormAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            tabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tbSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbUF = new ReaLTaiizor.Controls.MaterialComboBox();
            tbCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            lvwAlunos = new ListView();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            lvwConsulta = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageCadastro);
            tabControlCadastro.Controls.Add(tabPageConsulta);
            tabControlCadastro.Depth = 0;
            resources.ApplyResources(tabControlCadastro, "tabControlCadastro");
            tabControlCadastro.ImageList = imageList1;
            tabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastro.Multiline = true;
            tabControlCadastro.Name = "tabControlCadastro";
            tabControlCadastro.SelectedIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(tbSenha);
            tabPageCadastro.Controls.Add(cbUF);
            tabPageCadastro.Controls.Add(tbCidade);
            tabPageCadastro.Controls.Add(tbBairro);
            tabPageCadastro.Controls.Add(tbEndereco);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(mtbDataNascimento);
            tabPageCadastro.Controls.Add(tbMatricula);
            resources.ApplyResources(tabPageCadastro, "tabPageCadastro");
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            resources.ApplyResources(btnSalvar, "btnSalvar");
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            resources.ApplyResources(btnCancelar, "btnCancelar");
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbSenha
            // 
            tbSenha.AnimateReadOnly = false;
            tbSenha.AutoCompleteMode = AutoCompleteMode.None;
            tbSenha.AutoCompleteSource = AutoCompleteSource.None;
            resources.ApplyResources(tbSenha, "tbSenha");
            tbSenha.CharacterCasing = CharacterCasing.Normal;
            tbSenha.Depth = 0;
            tbSenha.HideSelection = true;
            tbSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            tbSenha.MaxLength = 32767;
            tbSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '●';
            tbSenha.ReadOnly = false;
            tbSenha.SelectedText = "";
            tbSenha.SelectionLength = 0;
            tbSenha.SelectionStart = 0;
            tbSenha.ShortcutsEnabled = true;
            tbSenha.TabStop = false;
            tbSenha.TextAlign = HorizontalAlignment.Left;
            tbSenha.TrailingIcon = null;
            tbSenha.UseSystemPasswordChar = true;
            // 
            // cbUF
            // 
            cbUF.AutoResize = false;
            cbUF.BackColor = Color.FromArgb(255, 255, 255);
            cbUF.Depth = 0;
            cbUF.DrawMode = DrawMode.OwnerDrawVariable;
            cbUF.DropDownHeight = 174;
            cbUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUF.DropDownWidth = 121;
            resources.ApplyResources(cbUF, "cbUF");
            cbUF.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbUF.FormattingEnabled = true;
            cbUF.Items.AddRange(new object[] { resources.GetString("cbUF.Items"), resources.GetString("cbUF.Items1"), resources.GetString("cbUF.Items2"), resources.GetString("cbUF.Items3"), resources.GetString("cbUF.Items4"), resources.GetString("cbUF.Items5"), resources.GetString("cbUF.Items6"), resources.GetString("cbUF.Items7"), resources.GetString("cbUF.Items8"), resources.GetString("cbUF.Items9"), resources.GetString("cbUF.Items10"), resources.GetString("cbUF.Items11"), resources.GetString("cbUF.Items12"), resources.GetString("cbUF.Items13"), resources.GetString("cbUF.Items14"), resources.GetString("cbUF.Items15"), resources.GetString("cbUF.Items16"), resources.GetString("cbUF.Items17"), resources.GetString("cbUF.Items18"), resources.GetString("cbUF.Items19"), resources.GetString("cbUF.Items20"), resources.GetString("cbUF.Items21"), resources.GetString("cbUF.Items22"), resources.GetString("cbUF.Items23"), resources.GetString("cbUF.Items24"), resources.GetString("cbUF.Items25"), resources.GetString("cbUF.Items26") });
            cbUF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbUF.Name = "cbUF";
            cbUF.StartIndex = 0;
            // 
            // tbCidade
            // 
            tbCidade.AnimateReadOnly = false;
            tbCidade.AutoCompleteMode = AutoCompleteMode.None;
            tbCidade.AutoCompleteSource = AutoCompleteSource.None;
            resources.ApplyResources(tbCidade, "tbCidade");
            tbCidade.CharacterCasing = CharacterCasing.Normal;
            tbCidade.Depth = 0;
            tbCidade.HideSelection = true;
            tbCidade.LeadingIcon = null;
            tbCidade.MaxLength = 32767;
            tbCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCidade.Name = "tbCidade";
            tbCidade.PasswordChar = '\0';
            tbCidade.ReadOnly = false;
            tbCidade.SelectedText = "";
            tbCidade.SelectionLength = 0;
            tbCidade.SelectionStart = 0;
            tbCidade.ShortcutsEnabled = true;
            tbCidade.TabStop = false;
            tbCidade.TextAlign = HorizontalAlignment.Left;
            tbCidade.TrailingIcon = null;
            tbCidade.UseSystemPasswordChar = false;
            // 
            // tbBairro
            // 
            tbBairro.AnimateReadOnly = false;
            tbBairro.AutoCompleteMode = AutoCompleteMode.None;
            tbBairro.AutoCompleteSource = AutoCompleteSource.None;
            resources.ApplyResources(tbBairro, "tbBairro");
            tbBairro.CharacterCasing = CharacterCasing.Normal;
            tbBairro.Depth = 0;
            tbBairro.HideSelection = true;
            tbBairro.LeadingIcon = null;
            tbBairro.MaxLength = 32767;
            tbBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbBairro.Name = "tbBairro";
            tbBairro.PasswordChar = '\0';
            tbBairro.ReadOnly = false;
            tbBairro.SelectedText = "";
            tbBairro.SelectionLength = 0;
            tbBairro.SelectionStart = 0;
            tbBairro.ShortcutsEnabled = true;
            tbBairro.TabStop = false;
            tbBairro.TextAlign = HorizontalAlignment.Left;
            tbBairro.TrailingIcon = null;
            tbBairro.UseSystemPasswordChar = false;
            // 
            // tbEndereco
            // 
            tbEndereco.AnimateReadOnly = false;
            tbEndereco.AutoCompleteMode = AutoCompleteMode.None;
            tbEndereco.AutoCompleteSource = AutoCompleteSource.None;
            resources.ApplyResources(tbEndereco, "tbEndereco");
            tbEndereco.CharacterCasing = CharacterCasing.Normal;
            tbEndereco.Depth = 0;
            tbEndereco.HideSelection = true;
            tbEndereco.LeadingIcon = null;
            tbEndereco.MaxLength = 32767;
            tbEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.PasswordChar = '\0';
            tbEndereco.ReadOnly = false;
            tbEndereco.SelectedText = "";
            tbEndereco.SelectionLength = 0;
            tbEndereco.SelectionStart = 0;
            tbEndereco.ShortcutsEnabled = true;
            tbEndereco.TabStop = false;
            tbEndereco.TextAlign = HorizontalAlignment.Left;
            tbEndereco.TrailingIcon = null;
            tbEndereco.UseSystemPasswordChar = false;
            // 
            // tbNome
            // 
            tbNome.AnimateReadOnly = false;
            tbNome.AutoCompleteMode = AutoCompleteMode.None;
            tbNome.AutoCompleteSource = AutoCompleteSource.None;
            resources.ApplyResources(tbNome, "tbNome");
            tbNome.CharacterCasing = CharacterCasing.Normal;
            tbNome.Depth = 0;
            tbNome.HideSelection = true;
            tbNome.LeadingIcon = null;
            tbNome.MaxLength = 32767;
            tbNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbNome.Name = "tbNome";
            tbNome.PasswordChar = '\0';
            tbNome.ReadOnly = false;
            tbNome.SelectedText = "";
            tbNome.SelectionLength = 0;
            tbNome.SelectionStart = 0;
            tbNome.ShortcutsEnabled = true;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // mtbDataNascimento
            // 
            mtbDataNascimento.AllowPromptAsInput = true;
            mtbDataNascimento.AnimateReadOnly = false;
            mtbDataNascimento.AsciiOnly = false;
            resources.ApplyResources(mtbDataNascimento, "mtbDataNascimento");
            mtbDataNascimento.BeepOnError = false;
            mtbDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbDataNascimento.Depth = 0;
            mtbDataNascimento.HidePromptOnLeave = false;
            mtbDataNascimento.HideSelection = true;
            mtbDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            mtbDataNascimento.LeadingIcon = null;
            mtbDataNascimento.Mask = "99/99/9999";
            mtbDataNascimento.MaxLength = 32767;
            mtbDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbDataNascimento.Name = "mtbDataNascimento";
            mtbDataNascimento.PasswordChar = '\0';
            mtbDataNascimento.PromptChar = '_';
            mtbDataNascimento.ReadOnly = false;
            mtbDataNascimento.RejectInputOnFirstFailure = false;
            mtbDataNascimento.ResetOnPrompt = true;
            mtbDataNascimento.ResetOnSpace = true;
            mtbDataNascimento.SelectedText = "";
            mtbDataNascimento.SelectionLength = 0;
            mtbDataNascimento.SelectionStart = 0;
            mtbDataNascimento.ShortcutsEnabled = true;
            mtbDataNascimento.SkipLiterals = true;
            mtbDataNascimento.TabStop = false;
            mtbDataNascimento.TextAlign = HorizontalAlignment.Left;
            mtbDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbDataNascimento.TrailingIcon = null;
            mtbDataNascimento.UseSystemPasswordChar = false;
            mtbDataNascimento.ValidatingType = null;
            // 
            // tbMatricula
            // 
            tbMatricula.AnimateReadOnly = false;
            tbMatricula.AutoCompleteMode = AutoCompleteMode.None;
            tbMatricula.AutoCompleteSource = AutoCompleteSource.None;
            resources.ApplyResources(tbMatricula, "tbMatricula");
            tbMatricula.CharacterCasing = CharacterCasing.Normal;
            tbMatricula.Depth = 0;
            tbMatricula.HideSelection = true;
            tbMatricula.LeadingIcon = null;
            tbMatricula.MaxLength = 32767;
            tbMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbMatricula.Name = "tbMatricula";
            tbMatricula.PasswordChar = '\0';
            tbMatricula.ReadOnly = false;
            tbMatricula.SelectedText = "";
            tbMatricula.SelectionLength = 0;
            tbMatricula.SelectionStart = 0;
            tbMatricula.ShortcutsEnabled = true;
            tbMatricula.TabStop = false;
            tbMatricula.TextAlign = HorizontalAlignment.Left;
            tbMatricula.TrailingIcon = null;
            tbMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(lvwAlunos);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(lvwConsulta);
            resources.ApplyResources(tabPageConsulta, "tabPageConsulta");
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // lvwAlunos
            // 
            resources.ApplyResources(lvwAlunos, "lvwAlunos");
            lvwAlunos.Name = "lvwAlunos";
            lvwAlunos.UseCompatibleStateImageBehavior = false;
            lvwAlunos.MouseDoubleClick += lvwAlunos_MouseDoubleClick;
            // 
            // btnNovo
            // 
            resources.ApplyResources(btnNovo, "btnNovo");
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            resources.ApplyResources(btnEditar, "btnEditar");
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            resources.ApplyResources(btnExcluir, "btnExcluir");
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lvwConsulta
            // 
            lvwConsulta.AutoSizeTable = false;
            lvwConsulta.BackColor = Color.FromArgb(255, 255, 255);
            lvwConsulta.BorderStyle = BorderStyle.None;
            lvwConsulta.Depth = 0;
            resources.ApplyResources(lvwConsulta, "lvwConsulta");
            lvwConsulta.FullRowSelect = true;
            lvwConsulta.MouseLocation = new Point(-1, -1);
            lvwConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            lvwConsulta.Name = "lvwConsulta";
            lvwConsulta.OwnerDraw = true;
            lvwConsulta.UseCompatibleStateImageBehavior = false;
            lvwConsulta.View = View.Details;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormAluno
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlCadastro);
            DrawerTabControl = tabControlCadastro;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAluno";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSenha;
        private ReaLTaiizor.Controls.MaterialComboBox cbUF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbDataNascimento;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialListView lvwConsulta;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbMatricula;
        private ListView lvwAlunos;
    }
}