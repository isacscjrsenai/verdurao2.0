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
            diaDaSemanaCheckedListBox = new CheckedListBox();
            label1 = new Label();
            nomeProdutoComboBox = new ComboBox();
            label2 = new Label();
            incluiItemBtn = new Button();
            label3 = new Label();
            descontoTextBox = new TextBox();
            label4 = new Label();
            checkedListBox2 = new CheckedListBox();
            itemDaPromocaoListBox = new ListBox();
            label5 = new Label();
            modificaItemBtn = new Button();
            SuspendLayout();
            // 
            // registraPromocaoBtn
            // 
            registraPromocaoBtn.Location = new Point(239, 400);
            registraPromocaoBtn.Name = "registraPromocaoBtn";
            registraPromocaoBtn.Size = new Size(258, 23);
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
            // 
            // diaDaSemanaCheckedListBox
            // 
            diaDaSemanaCheckedListBox.FormattingEnabled = true;
            diaDaSemanaCheckedListBox.Items.AddRange(new object[] { "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado", "Domingo" });
            diaDaSemanaCheckedListBox.Location = new Point(12, 71);
            diaDaSemanaCheckedListBox.Name = "diaDaSemanaCheckedListBox";
            diaDaSemanaCheckedListBox.Size = new Size(120, 130);
            diaDaSemanaCheckedListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Dia da Semana";
            // 
            // nomeProdutoComboBox
            // 
            nomeProdutoComboBox.FormattingEnabled = true;
            nomeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            nomeProdutoComboBox.Location = new Point(12, 222);
            nomeProdutoComboBox.Name = "nomeProdutoComboBox";
            nomeProdutoComboBox.Size = new Size(221, 23);
            nomeProdutoComboBox.TabIndex = 23;
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
            incluiItemBtn.Location = new Point(12, 376);
            incluiItemBtn.Name = "incluiItemBtn";
            incluiItemBtn.Size = new Size(75, 23);
            incluiItemBtn.TabIndex = 25;
            incluiItemBtn.Text = "INCLUIR";
            incluiItemBtn.UseVisualStyleBackColor = true;
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
            descontoTextBox.Location = new Point(12, 266);
            descontoTextBox.MaxLength = 2;
            descontoTextBox.Name = "descontoTextBox";
            descontoTextBox.Size = new Size(31, 23);
            descontoTextBox.TabIndex = 27;
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
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Valor Total acima de", "Valor do item acima de", "Quantidade do item acima de" });
            checkedListBox2.Location = new Point(12, 312);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(221, 58);
            checkedListBox2.TabIndex = 29;
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
            modificaItemBtn.Location = new Point(239, 371);
            modificaItemBtn.Name = "modificaItemBtn";
            modificaItemBtn.Size = new Size(258, 23);
            modificaItemBtn.TabIndex = 32;
            modificaItemBtn.Text = "MODIFICAR ITEM DA PROMOÇÃO";
            modificaItemBtn.UseVisualStyleBackColor = true;
            // 
            // Promocao_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 429);
            Controls.Add(modificaItemBtn);
            Controls.Add(label5);
            Controls.Add(itemDaPromocaoListBox);
            Controls.Add(checkedListBox2);
            Controls.Add(label4);
            Controls.Add(descontoTextBox);
            Controls.Add(label3);
            Controls.Add(incluiItemBtn);
            Controls.Add(label2);
            Controls.Add(nomeProdutoComboBox);
            Controls.Add(label1);
            Controls.Add(diaDaSemanaCheckedListBox);
            Controls.Add(nomeDaPromocaoTextBox);
            Controls.Add(nomePromocaoLabel);
            Controls.Add(registraPromocaoBtn);
            Name = "Promocao_Registro";
            Text = "VERDURÃO DO JOÃO - REGISTRO DE PROMOÇÃO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registraPromocaoBtn;
        private Label nomePromocaoLabel;
        private TextBox nomeDaPromocaoTextBox;
        private CheckedListBox diaDaSemanaCheckedListBox;
        private Label label1;
        private ComboBox nomeProdutoComboBox;
        private Label label2;
        private Button incluiItemBtn;
        private Label label3;
        private TextBox descontoTextBox;
        private Label label4;
        private CheckedListBox checkedListBox2;
        private ListBox itemDaPromocaoListBox;
        private Label label5;
        private Button modificaItemBtn;
    }
}