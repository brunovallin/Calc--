namespace CALC__
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomeVarDecisaoGroupBox = new System.Windows.Forms.GroupBox();
            this.funcaoObjetivoYLabel = new System.Windows.Forms.Label();
            this.nomeYTextBox = new System.Windows.Forms.TextBox();
            this.funcaoObjetivoXLabel = new System.Windows.Forms.Label();
            this.nomeXTextBox = new System.Windows.Forms.TextBox();
            this.tipoFuncaoGroupBox = new System.Windows.Forms.GroupBox();
            this.minimizacaoRadioButton = new System.Windows.Forms.RadioButton();
            this.maximizacaoRadioButton = new System.Windows.Forms.RadioButton();
            this.funcaoObjetivoValoresgroupBox = new System.Windows.Forms.GroupBox();
            this.nomeYLabel = new System.Windows.Forms.Label();
            this.nomeXLabel = new System.Windows.Forms.Label();
            this.valorYTextBox = new System.Windows.Forms.TextBox();
            this.valorXTextBox = new System.Windows.Forms.TextBox();
            this.funcaoObjetivoButton = new System.Windows.Forms.Button();
            this.funcaoObjetivodefGroupBox = new System.Windows.Forms.GroupBox();
            this.restricaoGroupBox = new System.Windows.Forms.GroupBox();
            this.restricaoInequaComboBox = new System.Windows.Forms.ComboBox();
            this.delRestricaoButton = new System.Windows.Forms.Button();
            this.addRestricaoButton = new System.Windows.Forms.Button();
            this.limiteRestricaoTextBox = new System.Windows.Forms.TextBox();
            this.restricaoYTextBox = new System.Windows.Forms.TextBox();
            this.restricaoXTextBox = new System.Windows.Forms.TextBox();
            this.restricaoYLabel = new System.Windows.Forms.Label();
            this.restricaoXLabel = new System.Windows.Forms.Label();
            this.restricoesListBox = new System.Windows.Forms.ListBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.copyClipboarButton = new System.Windows.Forms.Button();
            this.resetOperaçãoButton = new System.Windows.Forms.Button();
            this.solucaoOtimaGroupBox = new System.Windows.Forms.GroupBox();
            this.resolucaoDoProblemaButton = new System.Windows.Forms.Button();
            this.msglabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nomeVarDecisaoGroupBox.SuspendLayout();
            this.tipoFuncaoGroupBox.SuspendLayout();
            this.funcaoObjetivoValoresgroupBox.SuspendLayout();
            this.funcaoObjetivodefGroupBox.SuspendLayout();
            this.restricaoGroupBox.SuspendLayout();
            this.solucaoOtimaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 31);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nomeVarDecisaoGroupBox
            // 
            this.nomeVarDecisaoGroupBox.Controls.Add(this.funcaoObjetivoYLabel);
            this.nomeVarDecisaoGroupBox.Controls.Add(this.nomeYTextBox);
            this.nomeVarDecisaoGroupBox.Controls.Add(this.funcaoObjetivoXLabel);
            this.nomeVarDecisaoGroupBox.Controls.Add(this.nomeXTextBox);
            this.nomeVarDecisaoGroupBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeVarDecisaoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.nomeVarDecisaoGroupBox.Location = new System.Drawing.Point(6, 27);
            this.nomeVarDecisaoGroupBox.Name = "nomeVarDecisaoGroupBox";
            this.nomeVarDecisaoGroupBox.Size = new System.Drawing.Size(505, 90);
            this.nomeVarDecisaoGroupBox.TabIndex = 2;
            this.nomeVarDecisaoGroupBox.TabStop = false;
            this.nomeVarDecisaoGroupBox.Text = "Nomenclatura das variáveis de decisão";
            // 
            // funcaoObjetivoYLabel
            // 
            this.funcaoObjetivoYLabel.AutoSize = true;
            this.funcaoObjetivoYLabel.Location = new System.Drawing.Point(6, 57);
            this.funcaoObjetivoYLabel.Name = "funcaoObjetivoYLabel";
            this.funcaoObjetivoYLabel.Size = new System.Drawing.Size(22, 18);
            this.funcaoObjetivoYLabel.TabIndex = 3;
            this.funcaoObjetivoYLabel.Text = "Y:";
            // 
            // nomeYTextBox
            // 
            this.nomeYTextBox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeYTextBox.Location = new System.Drawing.Point(35, 55);
            this.nomeYTextBox.MaxLength = 55;
            this.nomeYTextBox.Name = "nomeYTextBox";
            this.nomeYTextBox.Size = new System.Drawing.Size(464, 20);
            this.nomeYTextBox.TabIndex = 1;
            this.nomeYTextBox.TextChanged += new System.EventHandler(this.nomeYTextBox_TextChanged);
            // 
            // funcaoObjetivoXLabel
            // 
            this.funcaoObjetivoXLabel.AutoSize = true;
            this.funcaoObjetivoXLabel.Location = new System.Drawing.Point(6, 31);
            this.funcaoObjetivoXLabel.Name = "funcaoObjetivoXLabel";
            this.funcaoObjetivoXLabel.Size = new System.Drawing.Size(23, 18);
            this.funcaoObjetivoXLabel.TabIndex = 1;
            this.funcaoObjetivoXLabel.Text = "X:";
            // 
            // nomeXTextBox
            // 
            this.nomeXTextBox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeXTextBox.Location = new System.Drawing.Point(35, 29);
            this.nomeXTextBox.MaxLength = 55;
            this.nomeXTextBox.Name = "nomeXTextBox";
            this.nomeXTextBox.Size = new System.Drawing.Size(464, 20);
            this.nomeXTextBox.TabIndex = 0;
            this.nomeXTextBox.TextChanged += new System.EventHandler(this.nomeXTextBox_TextChanged);
            // 
            // tipoFuncaoGroupBox
            // 
            this.tipoFuncaoGroupBox.Controls.Add(this.minimizacaoRadioButton);
            this.tipoFuncaoGroupBox.Controls.Add(this.maximizacaoRadioButton);
            this.tipoFuncaoGroupBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.tipoFuncaoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.tipoFuncaoGroupBox.Location = new System.Drawing.Point(6, 213);
            this.tipoFuncaoGroupBox.Name = "tipoFuncaoGroupBox";
            this.tipoFuncaoGroupBox.Size = new System.Drawing.Size(246, 52);
            this.tipoFuncaoGroupBox.TabIndex = 3;
            this.tipoFuncaoGroupBox.TabStop = false;
            this.tipoFuncaoGroupBox.Text = "Função desejada";
            // 
            // minimizacaoRadioButton
            // 
            this.minimizacaoRadioButton.AutoSize = true;
            this.minimizacaoRadioButton.Location = new System.Drawing.Point(126, 20);
            this.minimizacaoRadioButton.Name = "minimizacaoRadioButton";
            this.minimizacaoRadioButton.Size = new System.Drawing.Size(110, 22);
            this.minimizacaoRadioButton.TabIndex = 5;
            this.minimizacaoRadioButton.TabStop = true;
            this.minimizacaoRadioButton.Text = "Minimização";
            this.minimizacaoRadioButton.UseVisualStyleBackColor = true;
            // 
            // maximizacaoRadioButton
            // 
            this.maximizacaoRadioButton.AutoSize = true;
            this.maximizacaoRadioButton.Checked = true;
            this.maximizacaoRadioButton.Location = new System.Drawing.Point(6, 20);
            this.maximizacaoRadioButton.Name = "maximizacaoRadioButton";
            this.maximizacaoRadioButton.Size = new System.Drawing.Size(114, 22);
            this.maximizacaoRadioButton.TabIndex = 4;
            this.maximizacaoRadioButton.TabStop = true;
            this.maximizacaoRadioButton.Text = "Maximização";
            this.maximizacaoRadioButton.UseVisualStyleBackColor = true;
            // 
            // funcaoObjetivoValoresgroupBox
            // 
            this.funcaoObjetivoValoresgroupBox.Controls.Add(this.nomeYLabel);
            this.funcaoObjetivoValoresgroupBox.Controls.Add(this.nomeXLabel);
            this.funcaoObjetivoValoresgroupBox.Controls.Add(this.valorYTextBox);
            this.funcaoObjetivoValoresgroupBox.Controls.Add(this.valorXTextBox);
            this.funcaoObjetivoValoresgroupBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcaoObjetivoValoresgroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.funcaoObjetivoValoresgroupBox.Location = new System.Drawing.Point(6, 123);
            this.funcaoObjetivoValoresgroupBox.Name = "funcaoObjetivoValoresgroupBox";
            this.funcaoObjetivoValoresgroupBox.Size = new System.Drawing.Size(505, 84);
            this.funcaoObjetivoValoresgroupBox.TabIndex = 4;
            this.funcaoObjetivoValoresgroupBox.TabStop = false;
            this.funcaoObjetivoValoresgroupBox.Text = "Coeficientes da Função Objetivo";
            // 
            // nomeYLabel
            // 
            this.nomeYLabel.AutoSize = true;
            this.nomeYLabel.Location = new System.Drawing.Point(85, 50);
            this.nomeYLabel.MaximumSize = new System.Drawing.Size(416, 18);
            this.nomeYLabel.MinimumSize = new System.Drawing.Size(18, 18);
            this.nomeYLabel.Name = "nomeYLabel";
            this.nomeYLabel.Size = new System.Drawing.Size(18, 18);
            this.nomeYLabel.TabIndex = 3;
            this.nomeYLabel.Text = "Y";
            // 
            // nomeXLabel
            // 
            this.nomeXLabel.AutoSize = true;
            this.nomeXLabel.Location = new System.Drawing.Point(84, 23);
            this.nomeXLabel.MaximumSize = new System.Drawing.Size(416, 18);
            this.nomeXLabel.MinimumSize = new System.Drawing.Size(18, 18);
            this.nomeXLabel.Name = "nomeXLabel";
            this.nomeXLabel.Size = new System.Drawing.Size(19, 18);
            this.nomeXLabel.TabIndex = 2;
            this.nomeXLabel.Text = "X";
            // 
            // valorYTextBox
            // 
            this.valorYTextBox.Location = new System.Drawing.Point(14, 47);
            this.valorYTextBox.Name = "valorYTextBox";
            this.valorYTextBox.Size = new System.Drawing.Size(64, 21);
            this.valorYTextBox.TabIndex = 3;
            // 
            // valorXTextBox
            // 
            this.valorXTextBox.Location = new System.Drawing.Point(14, 20);
            this.valorXTextBox.Name = "valorXTextBox";
            this.valorXTextBox.Size = new System.Drawing.Size(64, 21);
            this.valorXTextBox.TabIndex = 2;
            // 
            // funcaoObjetivoButton
            // 
            this.funcaoObjetivoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.funcaoObjetivoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.funcaoObjetivoButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcaoObjetivoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.funcaoObjetivoButton.Location = new System.Drawing.Point(313, 229);
            this.funcaoObjetivoButton.Name = "funcaoObjetivoButton";
            this.funcaoObjetivoButton.Size = new System.Drawing.Size(198, 36);
            this.funcaoObjetivoButton.TabIndex = 4;
            this.funcaoObjetivoButton.Text = "Definir Função Objetivo";
            this.funcaoObjetivoButton.UseVisualStyleBackColor = false;
            this.funcaoObjetivoButton.Click += new System.EventHandler(this.funcaoObjetivoButton_Click);
            // 
            // funcaoObjetivodefGroupBox
            // 
            this.funcaoObjetivodefGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.funcaoObjetivodefGroupBox.Controls.Add(this.funcaoObjetivoButton);
            this.funcaoObjetivodefGroupBox.Controls.Add(this.funcaoObjetivoValoresgroupBox);
            this.funcaoObjetivodefGroupBox.Controls.Add(this.tipoFuncaoGroupBox);
            this.funcaoObjetivodefGroupBox.Controls.Add(this.nomeVarDecisaoGroupBox);
            this.funcaoObjetivodefGroupBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcaoObjetivodefGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.funcaoObjetivodefGroupBox.Location = new System.Drawing.Point(12, 49);
            this.funcaoObjetivodefGroupBox.Name = "funcaoObjetivodefGroupBox";
            this.funcaoObjetivodefGroupBox.Size = new System.Drawing.Size(521, 274);
            this.funcaoObjetivodefGroupBox.TabIndex = 5;
            this.funcaoObjetivodefGroupBox.TabStop = false;
            this.funcaoObjetivodefGroupBox.Text = "Definição da função objetivo";
            // 
            // restricaoGroupBox
            // 
            this.restricaoGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.restricaoGroupBox.Controls.Add(this.restricaoInequaComboBox);
            this.restricaoGroupBox.Controls.Add(this.delRestricaoButton);
            this.restricaoGroupBox.Controls.Add(this.addRestricaoButton);
            this.restricaoGroupBox.Controls.Add(this.limiteRestricaoTextBox);
            this.restricaoGroupBox.Controls.Add(this.restricaoYTextBox);
            this.restricaoGroupBox.Controls.Add(this.restricaoXTextBox);
            this.restricaoGroupBox.Controls.Add(this.restricaoYLabel);
            this.restricaoGroupBox.Controls.Add(this.restricaoXLabel);
            this.restricaoGroupBox.Controls.Add(this.restricoesListBox);
            this.restricaoGroupBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.restricaoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.restricaoGroupBox.Location = new System.Drawing.Point(533, 49);
            this.restricaoGroupBox.Name = "restricaoGroupBox";
            this.restricaoGroupBox.Size = new System.Drawing.Size(396, 274);
            this.restricaoGroupBox.TabIndex = 6;
            this.restricaoGroupBox.TabStop = false;
            this.restricaoGroupBox.Text = "Restrições";
            // 
            // restricaoInequaComboBox
            // 
            this.restricaoInequaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restricaoInequaComboBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.5F);
            this.restricaoInequaComboBox.ItemHeight = 15;
            this.restricaoInequaComboBox.Location = new System.Drawing.Point(215, 24);
            this.restricaoInequaComboBox.Name = "restricaoInequaComboBox";
            this.restricaoInequaComboBox.Size = new System.Drawing.Size(70, 23);
            this.restricaoInequaComboBox.TabIndex = 8;
            // 
            // delRestricaoButton
            // 
            this.delRestricaoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(45)))));
            this.delRestricaoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delRestricaoButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRestricaoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delRestricaoButton.Location = new System.Drawing.Point(37, 58);
            this.delRestricaoButton.Name = "delRestricaoButton";
            this.delRestricaoButton.Size = new System.Drawing.Size(160, 36);
            this.delRestricaoButton.TabIndex = 10;
            this.delRestricaoButton.Text = "Remover Restrição";
            this.delRestricaoButton.UseVisualStyleBackColor = false;
            this.delRestricaoButton.Click += new System.EventHandler(this.delRestricaoButton_Click);
            // 
            // addRestricaoButton
            // 
            this.addRestricaoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addRestricaoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRestricaoButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRestricaoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRestricaoButton.Location = new System.Drawing.Point(205, 58);
            this.addRestricaoButton.Name = "addRestricaoButton";
            this.addRestricaoButton.Size = new System.Drawing.Size(160, 36);
            this.addRestricaoButton.TabIndex = 11;
            this.addRestricaoButton.Text = "Adicionar Restrição";
            this.addRestricaoButton.UseVisualStyleBackColor = false;
            this.addRestricaoButton.Click += new System.EventHandler(this.addRestricaoButton_Click);
            // 
            // limiteRestricaoTextBox
            // 
            this.limiteRestricaoTextBox.Location = new System.Drawing.Point(299, 24);
            this.limiteRestricaoTextBox.Name = "limiteRestricaoTextBox";
            this.limiteRestricaoTextBox.Size = new System.Drawing.Size(66, 21);
            this.limiteRestricaoTextBox.TabIndex = 9;
            // 
            // restricaoYTextBox
            // 
            this.restricaoYTextBox.Location = new System.Drawing.Point(119, 24);
            this.restricaoYTextBox.Name = "restricaoYTextBox";
            this.restricaoYTextBox.Size = new System.Drawing.Size(66, 21);
            this.restricaoYTextBox.TabIndex = 7;
            // 
            // restricaoXTextBox
            // 
            this.restricaoXTextBox.Location = new System.Drawing.Point(11, 24);
            this.restricaoXTextBox.Name = "restricaoXTextBox";
            this.restricaoXTextBox.Size = new System.Drawing.Size(66, 21);
            this.restricaoXTextBox.TabIndex = 6;
            // 
            // restricaoYLabel
            // 
            this.restricaoYLabel.AutoSize = true;
            this.restricaoYLabel.Location = new System.Drawing.Point(191, 27);
            this.restricaoYLabel.Name = "restricaoYLabel";
            this.restricaoYLabel.Size = new System.Drawing.Size(18, 18);
            this.restricaoYLabel.TabIndex = 2;
            this.restricaoYLabel.Text = "Y";
            // 
            // restricaoXLabel
            // 
            this.restricaoXLabel.AutoSize = true;
            this.restricaoXLabel.Location = new System.Drawing.Point(83, 27);
            this.restricaoXLabel.Name = "restricaoXLabel";
            this.restricaoXLabel.Size = new System.Drawing.Size(30, 18);
            this.restricaoXLabel.TabIndex = 1;
            this.restricaoXLabel.Text = "X +";
            // 
            // restricoesListBox
            // 
            this.restricoesListBox.FormattingEnabled = true;
            this.restricoesListBox.ItemHeight = 18;
            this.restricoesListBox.Location = new System.Drawing.Point(6, 99);
            this.restricoesListBox.Name = "restricoesListBox";
            this.restricoesListBox.Size = new System.Drawing.Size(384, 166);
            this.restricoesListBox.TabIndex = 12;
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Enabled = false;
            this.resultadoTextBox.Location = new System.Drawing.Point(6, 20);
            this.resultadoTextBox.Multiline = true;
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(332, 155);
            this.resultadoTextBox.TabIndex = 7;
            // 
            // copyClipboarButton
            // 
            this.copyClipboarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.copyClipboarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyClipboarButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyClipboarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copyClipboarButton.Location = new System.Drawing.Point(351, 86);
            this.copyClipboarButton.Name = "copyClipboarButton";
            this.copyClipboarButton.Size = new System.Drawing.Size(160, 36);
            this.copyClipboarButton.TabIndex = 14;
            this.copyClipboarButton.Text = "Copiar Resultado";
            this.copyClipboarButton.UseVisualStyleBackColor = false;
            this.copyClipboarButton.Click += new System.EventHandler(this.copyClipboarButton_Click);
            // 
            // resetOperaçãoButton
            // 
            this.resetOperaçãoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(45)))));
            this.resetOperaçãoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetOperaçãoButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetOperaçãoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetOperaçãoButton.Location = new System.Drawing.Point(351, 139);
            this.resetOperaçãoButton.Name = "resetOperaçãoButton";
            this.resetOperaçãoButton.Size = new System.Drawing.Size(160, 36);
            this.resetOperaçãoButton.TabIndex = 15;
            this.resetOperaçãoButton.Text = "Reiniciar Operação";
            this.resetOperaçãoButton.UseVisualStyleBackColor = false;
            this.resetOperaçãoButton.Click += new System.EventHandler(this.resetOperaçãoButton_Click);
            // 
            // solucaoOtimaGroupBox
            // 
            this.solucaoOtimaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.solucaoOtimaGroupBox.Controls.Add(this.resolucaoDoProblemaButton);
            this.solucaoOtimaGroupBox.Controls.Add(this.resetOperaçãoButton);
            this.solucaoOtimaGroupBox.Controls.Add(this.resultadoTextBox);
            this.solucaoOtimaGroupBox.Controls.Add(this.copyClipboarButton);
            this.solucaoOtimaGroupBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.solucaoOtimaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.solucaoOtimaGroupBox.Location = new System.Drawing.Point(12, 323);
            this.solucaoOtimaGroupBox.Name = "solucaoOtimaGroupBox";
            this.solucaoOtimaGroupBox.Size = new System.Drawing.Size(521, 188);
            this.solucaoOtimaGroupBox.TabIndex = 10;
            this.solucaoOtimaGroupBox.TabStop = false;
            this.solucaoOtimaGroupBox.Text = "Solução Ótima";
            // 
            // resolucaoDoProblemaButton
            // 
            this.resolucaoDoProblemaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resolucaoDoProblemaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolucaoDoProblemaButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.resolucaoDoProblemaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resolucaoDoProblemaButton.Location = new System.Drawing.Point(351, 20);
            this.resolucaoDoProblemaButton.Name = "resolucaoDoProblemaButton";
            this.resolucaoDoProblemaButton.Size = new System.Drawing.Size(160, 48);
            this.resolucaoDoProblemaButton.TabIndex = 13;
            this.resolucaoDoProblemaButton.Text = "Gerar Resultado Ótimo";
            this.resolucaoDoProblemaButton.UseVisualStyleBackColor = false;
            this.resolucaoDoProblemaButton.Click += new System.EventHandler(this.resolucaoDoProblemaButton_Click);
            // 
            // msglabel
            // 
            this.msglabel.AutoSize = true;
            this.msglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msglabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.msglabel.Location = new System.Drawing.Point(140, 16);
            this.msglabel.Name = "msglabel";
            this.msglabel.Size = new System.Drawing.Size(51, 20);
            this.msglabel.TabIndex = 11;
            this.msglabel.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.linkLabel1.Location = new System.Drawing.Point(528, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 25);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.msglabel);
            this.Controls.Add(this.solucaoOtimaGroupBox);
            this.Controls.Add(this.restricaoGroupBox);
            this.Controls.Add(this.funcaoObjetivodefGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Calc+-";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nomeVarDecisaoGroupBox.ResumeLayout(false);
            this.nomeVarDecisaoGroupBox.PerformLayout();
            this.tipoFuncaoGroupBox.ResumeLayout(false);
            this.tipoFuncaoGroupBox.PerformLayout();
            this.funcaoObjetivoValoresgroupBox.ResumeLayout(false);
            this.funcaoObjetivoValoresgroupBox.PerformLayout();
            this.funcaoObjetivodefGroupBox.ResumeLayout(false);
            this.restricaoGroupBox.ResumeLayout(false);
            this.restricaoGroupBox.PerformLayout();
            this.solucaoOtimaGroupBox.ResumeLayout(false);
            this.solucaoOtimaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox nomeVarDecisaoGroupBox;
        private System.Windows.Forms.TextBox nomeXTextBox;
        private System.Windows.Forms.Label funcaoObjetivoYLabel;
        private System.Windows.Forms.TextBox nomeYTextBox;
        private System.Windows.Forms.Label funcaoObjetivoXLabel;
        private System.Windows.Forms.GroupBox tipoFuncaoGroupBox;
        private System.Windows.Forms.RadioButton minimizacaoRadioButton;
        private System.Windows.Forms.RadioButton maximizacaoRadioButton;
        private System.Windows.Forms.GroupBox funcaoObjetivoValoresgroupBox;
        private System.Windows.Forms.Label nomeXLabel;
        private System.Windows.Forms.TextBox valorYTextBox;
        private System.Windows.Forms.TextBox valorXTextBox;
        private System.Windows.Forms.Label nomeYLabel;
        private System.Windows.Forms.Button funcaoObjetivoButton;
        private System.Windows.Forms.GroupBox funcaoObjetivodefGroupBox;
        private System.Windows.Forms.GroupBox restricaoGroupBox;
        private System.Windows.Forms.Label restricaoXLabel;
        private System.Windows.Forms.ListBox restricoesListBox;
        private System.Windows.Forms.Label restricaoYLabel;
        private System.Windows.Forms.TextBox restricaoYTextBox;
        private System.Windows.Forms.TextBox restricaoXTextBox;
        private System.Windows.Forms.Button addRestricaoButton;
        private System.Windows.Forms.TextBox limiteRestricaoTextBox;
        private System.Windows.Forms.Button delRestricaoButton;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.Button copyClipboarButton;
        private System.Windows.Forms.ComboBox restricaoInequaComboBox;
        private System.Windows.Forms.Button resetOperaçãoButton;
        private System.Windows.Forms.GroupBox solucaoOtimaGroupBox;
        private System.Windows.Forms.Button resolucaoDoProblemaButton;
        private System.Windows.Forms.Label msglabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}