namespace VerduraoDoJoao2._0
{
    partial class CaminhaoProcuraPorPlaca
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
            label2 = new Label();
            anoLabel = new Label();
            corLabel = new Label();
            idLabel = new Label();
            modeloLabel = new Label();
            fabricanteLabel = new Label();
            placaComboBox = new ComboBox();
            placaLabel = new Label();
            fabricanteTextBox = new TextBox();
            modeloTextBox = new TextBox();
            kmTextBox = new TextBox();
            renavamTexBox = new TextBox();
            anoTextBox = new TextBox();
            corTextBox = new TextBox();
            idTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 141);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 48;
            label1.Text = "RENAVAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 46;
            label2.Text = "Km Rodados";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new Point(139, 97);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new Size(105, 15);
            anoLabel.TabIndex = 43;
            anoLabel.Text = "Ano de Fabricação";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new Point(139, 53);
            corLabel.Name = "corLabel";
            corLabel.Size = new Size(26, 15);
            corLabel.TabIndex = 41;
            corLabel.Text = "Cor";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(139, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(60, 15);
            idLabel.TabIndex = 40;
            idLabel.Text = "CPF/CNPJ";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new Point(12, 97);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new Size(48, 15);
            modeloLabel.TabIndex = 38;
            modeloLabel.Text = "Modelo";
            // 
            // fabricanteLabel
            // 
            fabricanteLabel.AutoSize = true;
            fabricanteLabel.Location = new Point(12, 53);
            fabricanteLabel.Name = "fabricanteLabel";
            fabricanteLabel.Size = new Size(62, 15);
            fabricanteLabel.TabIndex = 36;
            fabricanteLabel.Text = "Fabricante";
            // 
            // placaComboBox
            // 
            placaComboBox.FormattingEnabled = true;
            placaComboBox.Location = new Point(12, 27);
            placaComboBox.Name = "placaComboBox";
            placaComboBox.Size = new Size(121, 23);
            placaComboBox.TabIndex = 34;
            placaComboBox.SelectedIndexChanged += placaComboBox_SelectedIndexChanged;
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new Point(12, 9);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new Size(35, 15);
            placaLabel.TabIndex = 33;
            placaLabel.Text = "Placa";
            // 
            // fabricanteTextBox
            // 
            fabricanteTextBox.Location = new Point(12, 71);
            fabricanteTextBox.Name = "fabricanteTextBox";
            fabricanteTextBox.Size = new Size(121, 23);
            fabricanteTextBox.TabIndex = 49;
            // 
            // modeloTextBox
            // 
            modeloTextBox.Location = new Point(12, 115);
            modeloTextBox.Name = "modeloTextBox";
            modeloTextBox.Size = new Size(121, 23);
            modeloTextBox.TabIndex = 50;
            // 
            // kmTextBox
            // 
            kmTextBox.Location = new Point(12, 159);
            kmTextBox.Name = "kmTextBox";
            kmTextBox.Size = new Size(121, 23);
            kmTextBox.TabIndex = 51;
            // 
            // renavamTexBox
            // 
            renavamTexBox.Location = new Point(139, 159);
            renavamTexBox.Name = "renavamTexBox";
            renavamTexBox.Size = new Size(121, 23);
            renavamTexBox.TabIndex = 54;
            // 
            // anoTextBox
            // 
            anoTextBox.Location = new Point(139, 115);
            anoTextBox.Name = "anoTextBox";
            anoTextBox.Size = new Size(121, 23);
            anoTextBox.TabIndex = 53;
            // 
            // corTextBox
            // 
            corTextBox.Location = new Point(139, 71);
            corTextBox.Name = "corTextBox";
            corTextBox.Size = new Size(121, 23);
            corTextBox.TabIndex = 52;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(139, 27);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(121, 23);
            idTextBox.TabIndex = 55;
            // 
            // CaminhaoProcuraPorPlaca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(idTextBox);
            Controls.Add(renavamTexBox);
            Controls.Add(anoTextBox);
            Controls.Add(corTextBox);
            Controls.Add(kmTextBox);
            Controls.Add(modeloTextBox);
            Controls.Add(fabricanteTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(anoLabel);
            Controls.Add(corLabel);
            Controls.Add(idLabel);
            Controls.Add(modeloLabel);
            Controls.Add(fabricanteLabel);
            Controls.Add(placaComboBox);
            Controls.Add(placaLabel);
            Name = "CaminhaoProcuraPorPlaca";
            Text = "CaminhaoProcuraPorPlaca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label anoLabel;
        private Label corLabel;
        private Label idLabel;
        private Label modeloLabel;
        private Label fabricanteLabel;
        private ComboBox placaComboBox;
        private Label placaLabel;
        private TextBox fabricanteTextBox;
        private TextBox modeloTextBox;
        private TextBox kmTextBox;
        private TextBox renavamTexBox;
        private TextBox anoTextBox;
        private TextBox corTextBox;
        private TextBox idTextBox;
    }
}