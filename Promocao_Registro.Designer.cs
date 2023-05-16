namespace VerduraoDoJoao2._0
{
    partial class Promocao_Registro
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
            registraPromocaoBtn = new Button();
            nomePromocaoLabel = new Label();
            nomeDaPromocaoTextBox = new TextBox();
            nomeProdutoComboBox = new ComboBox();
            label2 = new Label();
            incluiItemBtn = new Button();
            label3 = new Label();
            descontoTextBox = new TextBox();
            label4 = new Label();
            condicoesCheckedListBox = new CheckedListBox();
            itemDaPromocaoListBox = new ListBox();
            label5 = new Label();
            modificaItemBtn = new Button();
            diasGroupBox = new GroupBox();
            feriadoCheckBox = new CheckBox();
            fimDeSemanaCheckBox = new CheckBox();
            diaUtilCheckBox = new CheckBox();
            domingoCheckBox = new CheckBox();
            sabadoCheckBox = new CheckBox();
            SextaCheckBox = new CheckBox();
            QuintaCheckBox = new CheckBox();
            quartaCheckBox = new CheckBox();
            tercaCheckBox = new CheckBox();
            segundaCheckBox = new CheckBox();
            condicaoValorTotalTextBox = new TextBox();
            condicaoValorTotalLabel = new Label();
            condicaoValorItemLabel = new Label();
            condicaoValorItemTextBox = new TextBox();
            condicaoQuantidadeLabel = new Label();
            condicaoQuantidadeTextBox = new TextBox();
            diasGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // registraPromocaoBtn
            // 
            registraPromocaoBtn.Enabled = false;
            registraPromocaoBtn.Location = new Point(239, 400);
            registraPromocaoBtn.Name = "registraPromocaoBtn";
            registraPromocaoBtn.Size = new Size(258, 43);
            registraPromocaoBtn.TabIndex = 0;
            registraPromocaoBtn.Text = "REGISTRAR PROMOÇÃO";
            registraPromocaoBtn.UseVisualStyleBackColor = true;
            // 
            // nomePromocaoLabel
            // 
            nomePromocaoLabel.AutoSize = true;
            nomePromocaoLabel.Location = new Point(12, 9);
            nomePromocaoLabel.Name = "nomePromocaoLabel";
            nomePromocaoLabel.Size = new Size(40, 15);
            nomePromocaoLabel.TabIndex = 1;
            nomePromocaoLabel.Text = "Nome";
            // 
            // nomeDaPromocaoTextBox
            // 
            nomeDaPromocaoTextBox.Location = new Point(12, 27);
            nomeDaPromocaoTextBox.MaxLength = 12;
            nomeDaPromocaoTextBox.Name = "nomeDaPromocaoTextBox";
            nomeDaPromocaoTextBox.Size = new Size(120, 23);
            nomeDaPromocaoTextBox.TabIndex = 1;
            nomeDaPromocaoTextBox.TextChanged += nomeDaPromocaoTextBox_TextChanged;
            // 
            // nomeProdutoComboBox
            // 
            nomeProdutoComboBox.Enabled = false;
            nomeProdutoComboBox.FormattingEnabled = true;
            nomeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            nomeProdutoComboBox.Location = new Point(12, 222);
            nomeProdutoComboBox.Name = "nomeProdutoComboBox";
            nomeProdutoComboBox.Size = new Size(221, 23);
            nomeProdutoComboBox.TabIndex = 23;
            nomeProdutoComboBox.SelectedIndexChanged += nomeProdutoComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 204);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 24;
            label2.Text = "Produto";
            // 
            // incluiItemBtn
            // 
            incluiItemBtn.Enabled = false;
            incluiItemBtn.Location = new Point(12, 420);
            incluiItemBtn.Name = "incluiItemBtn";
            incluiItemBtn.Size = new Size(221, 23);
            incluiItemBtn.TabIndex = 25;
            incluiItemBtn.Text = "INCLUIR";
            incluiItemBtn.UseVisualStyleBackColor = true;
            incluiItemBtn.Click += incluiItemBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 248);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 26;
            label3.Text = "Desconto";
            // 
            // descontoTextBox
            // 
            descontoTextBox.Enabled = false;
            descontoTextBox.Location = new Point(12, 266);
            descontoTextBox.MaxLength = 2;
            descontoTextBox.Name = "descontoTextBox";
            descontoTextBox.Size = new Size(31, 23);
            descontoTextBox.TabIndex = 27;
            descontoTextBox.TextChanged += descontoTextBox_TextChanged;
            descontoTextBox.KeyPress += descontoTextBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 294);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 28;
            label4.Text = "Condição";
            // 
            // condicoesCheckedListBox
            // 
            condicoesCheckedListBox.Enabled = false;
            condicoesCheckedListBox.FormattingEnabled = true;
            condicoesCheckedListBox.Items.AddRange(new object[] { "Valor Total acima de", "Valor do item acima de", "Quantidade do item acima de" });
            condicoesCheckedListBox.Location = new Point(12, 312);
            condicoesCheckedListBox.Name = "condicoesCheckedListBox";
            condicoesCheckedListBox.Size = new Size(221, 58);
            condicoesCheckedListBox.TabIndex = 29;
            condicoesCheckedListBox.ItemCheck += condicoesCheckedListBox_ItemCheck;
            // 
            // itemDaPromocaoListBox
            // 
            itemDaPromocaoListBox.FormattingEnabled = true;
            itemDaPromocaoListBox.ItemHeight = 15;
            itemDaPromocaoListBox.Location = new Point(239, 31);
            itemDaPromocaoListBox.Name = "itemDaPromocaoListBox";
            itemDaPromocaoListBox.Size = new Size(258, 334);
            itemDaPromocaoListBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 9);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 31;
            label5.Text = "Item da Promoção";
            // 
            // modificaItemBtn
            // 
            modificaItemBtn.Enabled = false;
            modificaItemBtn.Location = new Point(239, 371);
            modificaItemBtn.Name = "modificaItemBtn";
            modificaItemBtn.Size = new Size(258, 23);
            modificaItemBtn.TabIndex = 32;
            modificaItemBtn.Text = "MODIFICAR ITEM DA PROMOÇÃO";
            modificaItemBtn.UseVisualStyleBackColor = true;
            // 
            // diasGroupBox
            // 
            diasGroupBox.Controls.Add(feriadoCheckBox);
            diasGroupBox.Controls.Add(fimDeSemanaCheckBox);
            diasGroupBox.Controls.Add(diaUtilCheckBox);
            diasGroupBox.Controls.Add(domingoCheckBox);
            diasGroupBox.Controls.Add(sabadoCheckBox);
            diasGroupBox.Controls.Add(SextaCheckBox);
            diasGroupBox.Controls.Add(QuintaCheckBox);
            diasGroupBox.Controls.Add(quartaCheckBox);
            diasGroupBox.Controls.Add(tercaCheckBox);
            diasGroupBox.Controls.Add(segundaCheckBox);
            diasGroupBox.Enabled = false;
            diasGroupBox.Location = new Point(12, 56);
            diasGroupBox.Name = "diasGroupBox";
            diasGroupBox.Size = new Size(221, 145);
            diasGroupBox.TabIndex = 33;
            diasGroupBox.TabStop = false;
            diasGroupBox.Text = "Dias da Semana";
            // 
            // feriadoCheckBox
            // 
            feriadoCheckBox.AutoSize = true;
            feriadoCheckBox.Location = new Point(106, 120);
            feriadoCheckBox.Name = "feriadoCheckBox";
            feriadoCheckBox.Size = new Size(65, 19);
            feriadoCheckBox.TabIndex = 43;
            feriadoCheckBox.Text = "Feriado";
            feriadoCheckBox.UseVisualStyleBackColor = true;
            feriadoCheckBox.CheckedChanged += feriadoCheckBox_CheckedChanged;
            // 
            // fimDeSemanaCheckBox
            // 
            fimDeSemanaCheckBox.AutoSize = true;
            fimDeSemanaCheckBox.Location = new Point(106, 97);
            fimDeSemanaCheckBox.Name = "fimDeSemanaCheckBox";
            fimDeSemanaCheckBox.Size = new Size(112, 19);
            fimDeSemanaCheckBox.TabIndex = 42;
            fimDeSemanaCheckBox.Text = "Final de Semana";
            fimDeSemanaCheckBox.UseVisualStyleBackColor = true;
            fimDeSemanaCheckBox.CheckedChanged += fimDeSemanaCheckBox_CheckedChanged;
            // 
            // diaUtilCheckBox
            // 
            diaUtilCheckBox.AutoSize = true;
            diaUtilCheckBox.Location = new Point(105, 72);
            diaUtilCheckBox.Name = "diaUtilCheckBox";
            diaUtilCheckBox.Size = new Size(77, 19);
            diaUtilCheckBox.TabIndex = 41;
            diaUtilCheckBox.Text = "Dias Utéis";
            diaUtilCheckBox.UseVisualStyleBackColor = true;
            diaUtilCheckBox.CheckedChanged += diaUtilCheckBox_CheckedChanged;
            // 
            // domingoCheckBox
            // 
            domingoCheckBox.AutoSize = true;
            domingoCheckBox.Location = new Point(106, 47);
            domingoCheckBox.Name = "domingoCheckBox";
            domingoCheckBox.Size = new Size(76, 19);
            domingoCheckBox.TabIndex = 40;
            domingoCheckBox.Text = "Domingo";
            domingoCheckBox.UseVisualStyleBackColor = true;
            domingoCheckBox.CheckedChanged += domingoCheckBox_CheckedChanged;
            // 
            // sabadoCheckBox
            // 
            sabadoCheckBox.AutoSize = true;
            sabadoCheckBox.Location = new Point(106, 22);
            sabadoCheckBox.Name = "sabadoCheckBox";
            sabadoCheckBox.Size = new Size(65, 19);
            sabadoCheckBox.TabIndex = 39;
            sabadoCheckBox.Text = "Sábado";
            sabadoCheckBox.UseVisualStyleBackColor = true;
            sabadoCheckBox.CheckedChanged += sabadoCheckBox_CheckedChanged;
            // 
            // SextaCheckBox
            // 
            SextaCheckBox.AutoSize = true;
            SextaCheckBox.Location = new Point(6, 120);
            SextaCheckBox.Name = "SextaCheckBox";
            SextaCheckBox.Size = new Size(84, 19);
            SextaCheckBox.TabIndex = 38;
            SextaCheckBox.Text = "Sexta-Feira";
            SextaCheckBox.UseVisualStyleBackColor = true;
            SextaCheckBox.CheckedChanged += SextaCheckBox_CheckedChanged;
            // 
            // QuintaCheckBox
            // 
            QuintaCheckBox.AutoSize = true;
            QuintaCheckBox.Location = new Point(6, 97);
            QuintaCheckBox.Name = "QuintaCheckBox";
            QuintaCheckBox.Size = new Size(92, 19);
            QuintaCheckBox.TabIndex = 37;
            QuintaCheckBox.Text = "Quinta-Feira";
            QuintaCheckBox.UseVisualStyleBackColor = true;
            QuintaCheckBox.CheckedChanged += QuintaCheckBox_CheckedChanged;
            // 
            // quartaCheckBox
            // 
            quartaCheckBox.AutoSize = true;
            quartaCheckBox.Location = new Point(6, 72);
            quartaCheckBox.Name = "quartaCheckBox";
            quartaCheckBox.Size = new Size(92, 19);
            quartaCheckBox.TabIndex = 36;
            quartaCheckBox.Text = "Quarta-Feira";
            quartaCheckBox.UseVisualStyleBackColor = true;
            quartaCheckBox.CheckedChanged += quartaCheckBox_CheckedChanged;
            // 
            // tercaCheckBox
            // 
            tercaCheckBox.AutoSize = true;
            tercaCheckBox.Location = new Point(6, 47);
            tercaCheckBox.Name = "tercaCheckBox";
            tercaCheckBox.Size = new Size(83, 19);
            tercaCheckBox.TabIndex = 35;
            tercaCheckBox.Text = "Terça-Feira";
            tercaCheckBox.UseVisualStyleBackColor = true;
            tercaCheckBox.CheckedChanged += tercaCheckBox_CheckedChanged;
            // 
            // segundaCheckBox
            // 
            segundaCheckBox.AutoSize = true;
            segundaCheckBox.Location = new Point(6, 22);
            segundaCheckBox.Name = "segundaCheckBox";
            segundaCheckBox.Size = new Size(102, 19);
            segundaCheckBox.TabIndex = 34;
            segundaCheckBox.Text = "Segunda-Feira";
            segundaCheckBox.UseVisualStyleBackColor = true;
            segundaCheckBox.CheckedChanged += segundaCheckBox_CheckedChanged;
            // 
            // condicaoValorTotalTextBox
            // 
            condicaoValorTotalTextBox.Location = new Point(11, 391);
            condicaoValorTotalTextBox.MaxLength = 6;
            condicaoValorTotalTextBox.Name = "condicaoValorTotalTextBox";
            condicaoValorTotalTextBox.Size = new Size(74, 23);
            condicaoValorTotalTextBox.TabIndex = 34;
            condicaoValorTotalTextBox.Visible = false;
            condicaoValorTotalTextBox.TextChanged += condicaoTextBox_TextChanged;
            condicaoValorTotalTextBox.KeyPress += condicaoTextBox_KeyPress;
            // 
            // condicaoValorTotalLabel
            // 
            condicaoValorTotalLabel.AutoSize = true;
            condicaoValorTotalLabel.Location = new Point(12, 373);
            condicaoValorTotalLabel.Name = "condicaoValorTotalLabel";
            condicaoValorTotalLabel.Size = new Size(64, 15);
            condicaoValorTotalLabel.TabIndex = 35;
            condicaoValorTotalLabel.Text = "Valor Total ";
            // 
            // condicaoValorItemLabel
            // 
            condicaoValorItemLabel.AutoSize = true;
            condicaoValorItemLabel.Location = new Point(83, 373);
            condicaoValorItemLabel.Name = "condicaoValorItemLabel";
            condicaoValorItemLabel.Size = new Size(77, 15);
            condicaoValorItemLabel.TabIndex = 37;
            condicaoValorItemLabel.Text = "Valor do Item";
            // 
            // condicaoValorItemTextBox
            // 
            condicaoValorItemTextBox.Location = new Point(89, 391);
            condicaoValorItemTextBox.MaxLength = 6;
            condicaoValorItemTextBox.Name = "condicaoValorItemTextBox";
            condicaoValorItemTextBox.Size = new Size(64, 23);
            condicaoValorItemTextBox.TabIndex = 36;
            condicaoValorItemTextBox.Visible = false;
            condicaoValorItemTextBox.TextChanged += condicaoValorItemTextBox_TextChanged;
            // 
            // condicaoQuantidadeLabel
            // 
            condicaoQuantidadeLabel.AutoSize = true;
            condicaoQuantidadeLabel.Location = new Point(163, 373);
            condicaoQuantidadeLabel.Name = "condicaoQuantidadeLabel";
            condicaoQuantidadeLabel.Size = new Size(69, 15);
            condicaoQuantidadeLabel.TabIndex = 39;
            condicaoQuantidadeLabel.Text = "Quantidade";
            // 
            // condicaoQuantidadeTextBox
            // 
            condicaoQuantidadeTextBox.Location = new Point(159, 391);
            condicaoQuantidadeTextBox.MaxLength = 6;
            condicaoQuantidadeTextBox.Name = "condicaoQuantidadeTextBox";
            condicaoQuantidadeTextBox.Size = new Size(74, 23);
            condicaoQuantidadeTextBox.TabIndex = 38;
            condicaoQuantidadeTextBox.Visible = false;
            condicaoQuantidadeTextBox.TextChanged += condicaoQuantidadeTextBox_TextChanged;
            // 
            // Promocao_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 465);
            Controls.Add(condicaoQuantidadeLabel);
            Controls.Add(condicaoQuantidadeTextBox);
            Controls.Add(condicaoValorItemLabel);
            Controls.Add(condicaoValorItemTextBox);
            Controls.Add(condicaoValorTotalLabel);
            Controls.Add(condicaoValorTotalTextBox);
            Controls.Add(diasGroupBox);
            Controls.Add(modificaItemBtn);
            Controls.Add(label5);
            Controls.Add(itemDaPromocaoListBox);
            Controls.Add(condicoesCheckedListBox);
            Controls.Add(label4);
            Controls.Add(descontoTextBox);
            Controls.Add(label3);
            Controls.Add(incluiItemBtn);
            Controls.Add(label2);
            Controls.Add(nomeProdutoComboBox);
            Controls.Add(nomeDaPromocaoTextBox);
            Controls.Add(nomePromocaoLabel);
            Controls.Add(registraPromocaoBtn);
            Name = "Promocao_Registro";
            Text = "VERDURÃO DO JOÃO - REGISTRO DE PROMOÇÃO";
            diasGroupBox.ResumeLayout(false);
            diasGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registraPromocaoBtn;
        private Label nomePromocaoLabel;
        private TextBox nomeDaPromocaoTextBox;
        private ComboBox nomeProdutoComboBox;
        private Label label2;
        private Button incluiItemBtn;
        private Label label3;
        private TextBox descontoTextBox;
        private Label label4;
        private CheckedListBox condicoesCheckedListBox;
        private ListBox itemDaPromocaoListBox;
        private Label label5;
        private Button modificaItemBtn;
        private GroupBox diasGroupBox;
        private CheckBox fimDeSemanaCheckBox;
        private CheckBox diaUtilCheckBox;
        private CheckBox domingoCheckBox;
        private CheckBox sabadoCheckBox;
        private CheckBox SextaCheckBox;
        private CheckBox QuintaCheckBox;
        private CheckBox quartaCheckBox;
        private CheckBox tercaCheckBox;
        private CheckBox segundaCheckBox;
        private CheckBox feriadoCheckBox;
        private TextBox condicaoValorTotalTextBox;
        private Label condicaoValorTotalLabel;
        private Label condicaoValorItemLabel;
        private TextBox condicaoValorItemTextBox;
        private Label condicaoQuantidadeLabel;
        private TextBox condicaoQuantidadeTextBox;
    }
}