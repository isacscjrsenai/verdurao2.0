namespace VerduraoDoJoao2._0
{
    partial class VendaModificaItem
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
            quantidadeProdutoTextBox = new TextBox();
            modificaProdutoBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // quantidadeProdutoTextBox
            // 
            quantidadeProdutoTextBox.Location = new Point(12, 27);
            quantidadeProdutoTextBox.Name = "quantidadeProdutoTextBox";
            quantidadeProdutoTextBox.Size = new Size(100, 23);
            quantidadeProdutoTextBox.TabIndex = 0;
            quantidadeProdutoTextBox.TextChanged += textBox1_TextChanged;
            quantidadeProdutoTextBox.KeyPress += quantidadeProdutoTextBox_KeyPress;
            // 
            // modificaProdutoBtn
            // 
            modificaProdutoBtn.Enabled = false;
            modificaProdutoBtn.Location = new Point(23, 56);
            modificaProdutoBtn.Name = "modificaProdutoBtn";
            modificaProdutoBtn.Size = new Size(75, 23);
            modificaProdutoBtn.TabIndex = 1;
            modificaProdutoBtn.Text = "Modificar";
            modificaProdutoBtn.UseVisualStyleBackColor = true;
            modificaProdutoBtn.Click += modificaProdutoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Nova Quantidade";
            // 
            // VendaModificaItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(125, 86);
            Controls.Add(label1);
            Controls.Add(modificaProdutoBtn);
            Controls.Add(quantidadeProdutoTextBox);
            Name = "VendaModificaItem";
            Text = "VendaModificaItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox quantidadeProdutoTextBox;
        private Button modificaProdutoBtn;
        private Label label1;
    }
}