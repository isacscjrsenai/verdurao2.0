namespace VerduraoDoJoao2._0
{
    partial class ProdutoDeletar
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
            unidadeLabel = new Label();
            unidadeProdutoComboBox = new ComboBox();
            DeletarProdutoBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            precoProdutoComboBox = new ComboBox();
            custoProdutoComboBox = new ComboBox();
            nomeProdutoComboBox = new ComboBox();
            SuspendLayout();
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new Point(133, 47);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new Size(51, 15);
            unidadeLabel.TabIndex = 17;
            unidadeLabel.Text = "Unidade";
            // 
            // unidadeProdutoComboBox
            // 
            unidadeProdutoComboBox.FormattingEnabled = true;
            unidadeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            unidadeProdutoComboBox.Location = new Point(133, 65);
            unidadeProdutoComboBox.Name = "unidadeProdutoComboBox";
            unidadeProdutoComboBox.Size = new Size(100, 23);
            unidadeProdutoComboBox.TabIndex = 16;
            // 
            // DeletarProdutoBtn
            // 
            DeletarProdutoBtn.Location = new Point(12, 156);
            DeletarProdutoBtn.Name = "DeletarProdutoBtn";
            DeletarProdutoBtn.Size = new Size(221, 66);
            DeletarProdutoBtn.TabIndex = 15;
            DeletarProdutoBtn.Text = "DELETAR";
            DeletarProdutoBtn.UseVisualStyleBackColor = true;
            DeletarProdutoBtn.Click += DeletarProdutoBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "Custo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // precoProdutoComboBox
            // 
            precoProdutoComboBox.FormattingEnabled = true;
            precoProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            precoProdutoComboBox.Location = new Point(12, 65);
            precoProdutoComboBox.Name = "precoProdutoComboBox";
            precoProdutoComboBox.Size = new Size(100, 23);
            precoProdutoComboBox.TabIndex = 18;
            // 
            // custoProdutoComboBox
            // 
            custoProdutoComboBox.FormattingEnabled = true;
            custoProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            custoProdutoComboBox.Location = new Point(12, 112);
            custoProdutoComboBox.Name = "custoProdutoComboBox";
            custoProdutoComboBox.Size = new Size(100, 23);
            custoProdutoComboBox.TabIndex = 19;
            // 
            // nomeProdutoComboBox
            // 
            nomeProdutoComboBox.FormattingEnabled = true;
            nomeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            nomeProdutoComboBox.Location = new Point(12, 21);
            nomeProdutoComboBox.Name = "nomeProdutoComboBox";
            nomeProdutoComboBox.Size = new Size(221, 23);
            nomeProdutoComboBox.TabIndex = 20;
            nomeProdutoComboBox.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // ProdutoDeletar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 241);
            Controls.Add(nomeProdutoComboBox);
            Controls.Add(custoProdutoComboBox);
            Controls.Add(precoProdutoComboBox);
            Controls.Add(unidadeLabel);
            Controls.Add(unidadeProdutoComboBox);
            Controls.Add(DeletarProdutoBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProdutoDeletar";
            Text = "Deletar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label unidadeLabel;
        private ComboBox unidadeProdutoComboBox;
        private Button DeletarProdutoBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox precoProdutoComboBox;
        private ComboBox custoProdutoComboBox;
        private ComboBox nomeProdutoComboBox;
    }
}