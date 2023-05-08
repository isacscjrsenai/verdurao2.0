namespace VerduraoDoJoao2._0
{
    partial class ProdutoRegistrar
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
            label1 = new Label();
            nomeProdutoTextBox = new TextBox();
            precoProdutoTextBox = new TextBox();
            label2 = new Label();
            custoProdutoTextBox = new TextBox();
            label3 = new Label();
            RegistraProdutoBtn = new Button();
            unidadeProdutoComboBox = new ComboBox();
            unidadeLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // nomeProdutoTextBox
            // 
            nomeProdutoTextBox.Location = new Point(12, 27);
            nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            nomeProdutoTextBox.Size = new Size(221, 23);
            nomeProdutoTextBox.TabIndex = 1;
            nomeProdutoTextBox.TextChanged += nomeProdutoTextBox_TextChanged;
            // 
            // precoProdutoTextBox
            // 
            precoProdutoTextBox.Location = new Point(12, 71);
            precoProdutoTextBox.Name = "precoProdutoTextBox";
            precoProdutoTextBox.Size = new Size(100, 23);
            precoProdutoTextBox.TabIndex = 3;
            precoProdutoTextBox.TextChanged += precoProdutoTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Preço";
            // 
            // custoProdutoTextBox
            // 
            custoProdutoTextBox.Location = new Point(12, 118);
            custoProdutoTextBox.Name = "custoProdutoTextBox";
            custoProdutoTextBox.Size = new Size(100, 23);
            custoProdutoTextBox.TabIndex = 5;
            custoProdutoTextBox.TextChanged += custoProdutoTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Custo";
            // 
            // RegistraProdutoBtn
            // 
            RegistraProdutoBtn.Location = new Point(12, 162);
            RegistraProdutoBtn.Name = "RegistraProdutoBtn";
            RegistraProdutoBtn.Size = new Size(221, 66);
            RegistraProdutoBtn.TabIndex = 6;
            RegistraProdutoBtn.Text = "REGISTRAR";
            RegistraProdutoBtn.UseVisualStyleBackColor = true;
            RegistraProdutoBtn.Click += RegistraProdutoBtn_Click;
            // 
            // unidadeProdutoComboBox
            // 
            unidadeProdutoComboBox.FormattingEnabled = true;
            unidadeProdutoComboBox.Items.AddRange(new object[] { "Kg", "Caixa", "Bandeja", "Saca" });
            unidadeProdutoComboBox.Location = new Point(133, 71);
            unidadeProdutoComboBox.Name = "unidadeProdutoComboBox";
            unidadeProdutoComboBox.Size = new Size(100, 23);
            unidadeProdutoComboBox.TabIndex = 7;
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new Point(133, 53);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new Size(51, 15);
            unidadeLabel.TabIndex = 8;
            unidadeLabel.Text = "Unidade";
            // 
            // ProdutoRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 242);
            Controls.Add(unidadeLabel);
            Controls.Add(unidadeProdutoComboBox);
            Controls.Add(RegistraProdutoBtn);
            Controls.Add(custoProdutoTextBox);
            Controls.Add(label3);
            Controls.Add(precoProdutoTextBox);
            Controls.Add(label2);
            Controls.Add(nomeProdutoTextBox);
            Controls.Add(label1);
            Name = "ProdutoRegistrar";
            Text = "Registra Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeProdutoTextBox;
        private TextBox precoProdutoTextBox;
        private Label label2;
        private TextBox custoProdutoTextBox;
        private Label label3;
        private Button RegistraProdutoBtn;
        private ComboBox unidadeProdutoComboBox;
        private Label unidadeLabel;
    }
}