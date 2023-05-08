namespace VerduraoDoJoao2._0
{
    partial class ProdutoModificar
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
            nomeProdutoComboBox = new ComboBox();
            custoProdutoComboBox = new ComboBox();
            precoProdutoComboBox = new ComboBox();
            unidadeProdutoComboBox = new ComboBox();
            ModificarProdutoBtn = new Button();
            label1 = new Label();
            unidadeLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // nomeProdutoComboBox
            // 
            nomeProdutoComboBox.FormattingEnabled = true;
            nomeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            nomeProdutoComboBox.Location = new Point(12, 27);
            nomeProdutoComboBox.Name = "nomeProdutoComboBox";
            nomeProdutoComboBox.Size = new Size(221, 23);
            nomeProdutoComboBox.TabIndex = 26;
            nomeProdutoComboBox.SelectedIndexChanged += nomeProdutoComboBox_SelectedIndexChanged;
            // 
            // custoProdutoComboBox
            // 
            custoProdutoComboBox.FormattingEnabled = true;
            custoProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            custoProdutoComboBox.Location = new Point(12, 118);
            custoProdutoComboBox.Name = "custoProdutoComboBox";
            custoProdutoComboBox.Size = new Size(100, 23);
            custoProdutoComboBox.TabIndex = 25;
            // 
            // precoProdutoComboBox
            // 
            precoProdutoComboBox.FormattingEnabled = true;
            precoProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            precoProdutoComboBox.Location = new Point(12, 71);
            precoProdutoComboBox.Name = "precoProdutoComboBox";
            precoProdutoComboBox.Size = new Size(100, 23);
            precoProdutoComboBox.TabIndex = 24;
            // 
            // unidadeProdutoComboBox
            // 
            unidadeProdutoComboBox.FormattingEnabled = true;
            unidadeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            unidadeProdutoComboBox.Location = new Point(133, 71);
            unidadeProdutoComboBox.Name = "unidadeProdutoComboBox";
            unidadeProdutoComboBox.Size = new Size(100, 23);
            unidadeProdutoComboBox.TabIndex = 23;
            // 
            // ModificarProdutoBtn
            // 
            ModificarProdutoBtn.Location = new Point(12, 162);
            ModificarProdutoBtn.Name = "ModificarProdutoBtn";
            ModificarProdutoBtn.Size = new Size(221, 66);
            ModificarProdutoBtn.TabIndex = 22;
            ModificarProdutoBtn.Text = "MODIFICAR";
            ModificarProdutoBtn.UseVisualStyleBackColor = true;
            ModificarProdutoBtn.Click += ModificarProdutoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 21;
            label1.Text = "Nome";
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new Point(136, 53);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new Size(51, 15);
            unidadeLabel.TabIndex = 29;
            unidadeLabel.Text = "Unidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 28;
            label3.Text = "Custo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 53);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 27;
            label2.Text = "Preço";
            // 
            // ProdutoModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 240);
            Controls.Add(unidadeLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nomeProdutoComboBox);
            Controls.Add(custoProdutoComboBox);
            Controls.Add(precoProdutoComboBox);
            Controls.Add(unidadeProdutoComboBox);
            Controls.Add(ModificarProdutoBtn);
            Controls.Add(label1);
            Name = "ProdutoModificar";
            Text = "Modificar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox nomeProdutoComboBox;
        private ComboBox custoProdutoComboBox;
        private ComboBox precoProdutoComboBox;
        private ComboBox unidadeProdutoComboBox;
        private Button ModificarProdutoBtn;
        private Label label1;
        private Label unidadeLabel;
        private Label label3;
        private Label label2;
    }
}