namespace VerduraoDoJoao2._0
{
    partial class Caminhao1
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
            registrarBtn = new Button();
            placaTextBox = new TextBox();
            placaLabel = new Label();
            label2 = new Label();
            KmTextBox = new TextBox();
            label1 = new Label();
            renavamTextBox = new TextBox();
            anoLabel = new Label();
            anoComboBox = new ComboBox();
            modeloLabel = new Label();
            modeloComboBox = new ComboBox();
            fabricanteComboBox = new ComboBox();
            fabricanteLabel = new Label();
            corLabel = new Label();
            corComboBox = new ComboBox();
            idLabel = new Label();
            idTextBox = new TextBox();
            SuspendLayout();
            // 
            // registrarBtn
            // 
            registrarBtn.Location = new Point(12, 199);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(248, 47);
            registrarBtn.TabIndex = 0;
            registrarBtn.Text = "REGISTRAR";
            registrarBtn.UseVisualStyleBackColor = true;
            registrarBtn.Click += registrarBtn_Click;
            // 
            // placaTextBox
            // 
            placaTextBox.Location = new Point(12, 27);
            placaTextBox.Name = "placaTextBox";
            placaTextBox.Size = new Size(121, 23);
            placaTextBox.TabIndex = 1;
            placaTextBox.TextChanged += placaTextBox_TextChanged;
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new Point(12, 9);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new Size(35, 15);
            placaLabel.TabIndex = 2;
            placaLabel.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 15;
            label2.Text = "Km Rodados";
            // 
            // KmTextBox
            // 
            KmTextBox.Location = new Point(12, 159);
            KmTextBox.Name = "KmTextBox";
            KmTextBox.Size = new Size(121, 23);
            KmTextBox.TabIndex = 14;
            KmTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 141);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 17;
            label1.Text = "RENAVAM";
            // 
            // renavamTextBox
            // 
            renavamTextBox.Location = new Point(139, 159);
            renavamTextBox.Name = "renavamTextBox";
            renavamTextBox.Size = new Size(121, 23);
            renavamTextBox.TabIndex = 16;
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new Point(139, 97);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new Size(105, 15);
            anoLabel.TabIndex = 12;
            anoLabel.Text = "Ano de Fabricação";
            // 
            // anoComboBox
            // 
            anoComboBox.FormattingEnabled = true;
            anoComboBox.Items.AddRange(new object[] { "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            anoComboBox.Location = new Point(139, 115);
            anoComboBox.Name = "anoComboBox";
            anoComboBox.Size = new Size(121, 23);
            anoComboBox.TabIndex = 13;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new Point(12, 97);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new Size(48, 15);
            modeloLabel.TabIndex = 6;
            modeloLabel.Text = "Modelo";
            // 
            // modeloComboBox
            // 
            modeloComboBox.Enabled = false;
            modeloComboBox.FormattingEnabled = true;
            modeloComboBox.Location = new Point(12, 115);
            modeloComboBox.Name = "modeloComboBox";
            modeloComboBox.Size = new Size(121, 23);
            modeloComboBox.TabIndex = 5;
            modeloComboBox.SelectedIndexChanged += modeloComboBox_SelectedIndexChanged;
            // 
            // fabricanteComboBox
            // 
            fabricanteComboBox.FormattingEnabled = true;
            fabricanteComboBox.Location = new Point(12, 71);
            fabricanteComboBox.Name = "fabricanteComboBox";
            fabricanteComboBox.Size = new Size(121, 23);
            fabricanteComboBox.TabIndex = 3;
            fabricanteComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // fabricanteLabel
            // 
            fabricanteLabel.AutoSize = true;
            fabricanteLabel.Location = new Point(12, 53);
            fabricanteLabel.Name = "fabricanteLabel";
            fabricanteLabel.Size = new Size(62, 15);
            fabricanteLabel.TabIndex = 4;
            fabricanteLabel.Text = "Fabricante";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new Point(139, 53);
            corLabel.Name = "corLabel";
            corLabel.Size = new Size(26, 15);
            corLabel.TabIndex = 10;
            corLabel.Text = "Cor";
            // 
            // corComboBox
            // 
            corComboBox.FormattingEnabled = true;
            corComboBox.Items.AddRange(new object[] { "Amarelo", "Azul", "Branco", "Cinza", "Laranja", "Marrom", "Prata", "Preto", "Verde", "Vermelho", "" });
            corComboBox.Location = new Point(139, 71);
            corComboBox.Name = "corComboBox";
            corComboBox.Size = new Size(121, 23);
            corComboBox.TabIndex = 11;
            corComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(139, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(60, 15);
            idLabel.TabIndex = 8;
            idLabel.Text = "CPF/CNPJ";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(139, 27);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(121, 23);
            idTextBox.TabIndex = 7;
            // 
            // Caminhao1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(renavamTextBox);
            Controls.Add(label2);
            Controls.Add(KmTextBox);
            Controls.Add(anoComboBox);
            Controls.Add(anoLabel);
            Controls.Add(corComboBox);
            Controls.Add(corLabel);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(modeloLabel);
            Controls.Add(modeloComboBox);
            Controls.Add(fabricanteLabel);
            Controls.Add(fabricanteComboBox);
            Controls.Add(placaLabel);
            Controls.Add(placaTextBox);
            Controls.Add(registrarBtn);
            Name = "Caminhao1";
            Text = "Registra Caminhão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrarBtn;
        private TextBox placaTextBox;
        private Label placaLabel;
        private Label label2;
        private TextBox KmTextBox;
        private Label label1;
        private TextBox renavamTextBox;
        private Label anoLabel;
        private ComboBox anoComboBox;
        private Label modeloLabel;
        private ComboBox modeloComboBox;
        private ComboBox fabricanteComboBox;
        private Label fabricanteLabel;
        private Label corLabel;
        private ComboBox corComboBox;
        private Label idLabel;
        private TextBox idTextBox;
    }
}