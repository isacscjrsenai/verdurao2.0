namespace VerduraoDoJoao2._0
{
    partial class Venda
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
            placaComboBox = new ComboBox();
            placaLabel = new Label();
            nomeProdutoComboBox = new ComboBox();
            label1 = new Label();
            adicionarProdutoBtn = new Button();
            quantidadeProdutoTextBox = new TextBox();
            unidadeLabel = new Label();
            quantidadeLabel = new Label();
            listaDeComprasListBox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            modificaItemBtn = new Button();
            deletaItemBtn = new Button();
            fechaVendaBtn = new Button();
            SuspendLayout();
            // 
            // placaComboBox
            // 
            placaComboBox.FormattingEnabled = true;
            placaComboBox.Location = new Point(12, 27);
            placaComboBox.Name = "placaComboBox";
            placaComboBox.Size = new Size(121, 23);
            placaComboBox.TabIndex = 8;
            placaComboBox.SelectedIndexChanged += placaComboBox_SelectedIndexChanged;
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new Point(12, 9);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new Size(35, 15);
            placaLabel.TabIndex = 7;
            placaLabel.Text = "Placa";
            // 
            // nomeProdutoComboBox
            // 
            nomeProdutoComboBox.FormattingEnabled = true;
            nomeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            nomeProdutoComboBox.Location = new Point(12, 83);
            nomeProdutoComboBox.Name = "nomeProdutoComboBox";
            nomeProdutoComboBox.Size = new Size(221, 23);
            nomeProdutoComboBox.TabIndex = 22;
            nomeProdutoComboBox.SelectedIndexChanged += nomeProdutoComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 21;
            label1.Text = "Produto";
            // 
            // adicionarProdutoBtn
            // 
            adicionarProdutoBtn.Location = new Point(12, 162);
            adicionarProdutoBtn.Name = "adicionarProdutoBtn";
            adicionarProdutoBtn.Size = new Size(75, 23);
            adicionarProdutoBtn.TabIndex = 23;
            adicionarProdutoBtn.Text = "Adicionar";
            adicionarProdutoBtn.UseVisualStyleBackColor = true;
            adicionarProdutoBtn.Click += button1_Click;
            // 
            // quantidadeProdutoTextBox
            // 
            quantidadeProdutoTextBox.Location = new Point(12, 133);
            quantidadeProdutoTextBox.Name = "quantidadeProdutoTextBox";
            quantidadeProdutoTextBox.Size = new Size(100, 23);
            quantidadeProdutoTextBox.TabIndex = 24;
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new Point(118, 136);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new Size(50, 15);
            unidadeLabel.TabIndex = 25;
            unidadeLabel.Text = "unidade";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new Point(12, 115);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(69, 15);
            quantidadeLabel.TabIndex = 28;
            quantidadeLabel.Text = "Quantidade";
            // 
            // listaDeComprasListBox
            // 
            listaDeComprasListBox.FormattingEnabled = true;
            listaDeComprasListBox.ItemHeight = 15;
            listaDeComprasListBox.Location = new Point(383, 133);
            listaDeComprasListBox.Name = "listaDeComprasListBox";
            listaDeComprasListBox.Size = new Size(405, 214);
            listaDeComprasListBox.TabIndex = 29;
            listaDeComprasListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 30;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 115);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 31;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 115);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 32;
            label4.Text = "Preço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(648, 115);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 33;
            label5.Text = "Promoção";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(756, 115);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 34;
            label6.Text = "Total";
            // 
            // modificaItemBtn
            // 
            modificaItemBtn.Enabled = false;
            modificaItemBtn.Location = new Point(593, 356);
            modificaItemBtn.Name = "modificaItemBtn";
            modificaItemBtn.Size = new Size(93, 23);
            modificaItemBtn.TabIndex = 35;
            modificaItemBtn.Text = "Modificar";
            modificaItemBtn.UseVisualStyleBackColor = true;
            modificaItemBtn.Click += modificaItemBtn_Click;
            // 
            // deletaItemBtn
            // 
            deletaItemBtn.Enabled = false;
            deletaItemBtn.Location = new Point(692, 356);
            deletaItemBtn.Name = "deletaItemBtn";
            deletaItemBtn.Size = new Size(96, 23);
            deletaItemBtn.TabIndex = 36;
            deletaItemBtn.Text = "Deletar Item";
            deletaItemBtn.UseVisualStyleBackColor = true;
            // 
            // fechaVendaBtn
            // 
            fechaVendaBtn.Location = new Point(593, 385);
            fechaVendaBtn.Name = "fechaVendaBtn";
            fechaVendaBtn.Size = new Size(195, 53);
            fechaVendaBtn.TabIndex = 37;
            fechaVendaBtn.Text = "FECHA VENDA";
            fechaVendaBtn.UseVisualStyleBackColor = true;
            // 
            // Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaVendaBtn);
            Controls.Add(deletaItemBtn);
            Controls.Add(modificaItemBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listaDeComprasListBox);
            Controls.Add(quantidadeLabel);
            Controls.Add(unidadeLabel);
            Controls.Add(quantidadeProdutoTextBox);
            Controls.Add(adicionarProdutoBtn);
            Controls.Add(nomeProdutoComboBox);
            Controls.Add(label1);
            Controls.Add(placaComboBox);
            Controls.Add(placaLabel);
            Name = "Venda";
            Text = "Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox placaComboBox;
        private Label placaLabel;
        private ComboBox nomeProdutoComboBox;
        private Label label1;
        private Button adicionarProdutoBtn;
        private TextBox quantidadeProdutoTextBox;
        private Label unidadeLabel;
        private Label quantidadeLabel;
        private ListBox listaDeComprasListBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button modificaItemBtn;
        private Button deletaItemBtn;
        private Button fechaVendaBtn;
    }
}