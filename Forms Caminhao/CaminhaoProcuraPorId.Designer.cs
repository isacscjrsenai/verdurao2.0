namespace VerduraoDoJoao2._0
{
    partial class CaminhaoProcuraPorId
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
            anoComboBox = new ComboBox();
            anoLabel = new Label();
            corComboBox = new ComboBox();
            corLabel = new Label();
            idLabel = new Label();
            modeloLabel = new Label();
            modeloComboBox = new ComboBox();
            fabricanteLabel = new Label();
            fabricanteComboBox = new ComboBox();
            placaLabel = new Label();
            idComboBox = new ComboBox();
            placaComboBox = new ComboBox();
            renavamComboBox = new ComboBox();
            kmComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 141);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 64;
            label1.Text = "RENAVAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 62;
            label2.Text = "Km Rodados";
            // 
            // anoComboBox
            // 
            anoComboBox.Enabled = false;
            anoComboBox.FormattingEnabled = true;
            anoComboBox.Items.AddRange(new object[] { "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            anoComboBox.Location = new Point(139, 115);
            anoComboBox.Name = "anoComboBox";
            anoComboBox.Size = new Size(121, 23);
            anoComboBox.TabIndex = 60;
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new Point(139, 97);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new Size(105, 15);
            anoLabel.TabIndex = 59;
            anoLabel.Text = "Ano de Fabricação";
            // 
            // corComboBox
            // 
            corComboBox.Enabled = false;
            corComboBox.FormattingEnabled = true;
            corComboBox.Items.AddRange(new object[] { "Amarelo", "Azul", "Branco", "Cinza", "Laranja", "Marrom", "Prata", "Preto", "Verde", "Vermelho", "" });
            corComboBox.Location = new Point(139, 71);
            corComboBox.Name = "corComboBox";
            corComboBox.Size = new Size(121, 23);
            corComboBox.TabIndex = 58;
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new Point(139, 53);
            corLabel.Name = "corLabel";
            corLabel.Size = new Size(26, 15);
            corLabel.TabIndex = 57;
            corLabel.Text = "Cor";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(139, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(60, 15);
            idLabel.TabIndex = 56;
            idLabel.Text = "CPF/CNPJ";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new Point(12, 97);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new Size(48, 15);
            modeloLabel.TabIndex = 54;
            modeloLabel.Text = "Modelo";
            // 
            // modeloComboBox
            // 
            modeloComboBox.Enabled = false;
            modeloComboBox.FormattingEnabled = true;
            modeloComboBox.Location = new Point(12, 115);
            modeloComboBox.Name = "modeloComboBox";
            modeloComboBox.Size = new Size(121, 23);
            modeloComboBox.TabIndex = 53;
            // 
            // fabricanteLabel
            // 
            fabricanteLabel.AutoSize = true;
            fabricanteLabel.Location = new Point(12, 53);
            fabricanteLabel.Name = "fabricanteLabel";
            fabricanteLabel.Size = new Size(62, 15);
            fabricanteLabel.TabIndex = 52;
            fabricanteLabel.Text = "Fabricante";
            // 
            // fabricanteComboBox
            // 
            fabricanteComboBox.Enabled = false;
            fabricanteComboBox.FormattingEnabled = true;
            fabricanteComboBox.Location = new Point(12, 71);
            fabricanteComboBox.Name = "fabricanteComboBox";
            fabricanteComboBox.Size = new Size(121, 23);
            fabricanteComboBox.TabIndex = 51;
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new Point(12, 9);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new Size(35, 15);
            placaLabel.TabIndex = 49;
            placaLabel.Text = "Placa";
            // 
            // idComboBox
            // 
            idComboBox.FormattingEnabled = true;
            idComboBox.Location = new Point(139, 27);
            idComboBox.Name = "idComboBox";
            idComboBox.Size = new Size(121, 23);
            idComboBox.TabIndex = 65;
            idComboBox.SelectedIndexChanged += idComboBox_SelectedIndexChanged;
            idComboBox.TextUpdate += idComboBox_TextChanged;
            // 
            // placaComboBox
            // 
            placaComboBox.Enabled = false;
            placaComboBox.FormattingEnabled = true;
            placaComboBox.Location = new Point(12, 27);
            placaComboBox.Name = "placaComboBox";
            placaComboBox.Size = new Size(121, 23);
            placaComboBox.TabIndex = 66;
            placaComboBox.SelectedIndexChanged += placaComboBox_SelectedIndexChanged;
            // 
            // renavamComboBox
            // 
            renavamComboBox.Enabled = false;
            renavamComboBox.FormattingEnabled = true;
            renavamComboBox.Items.AddRange(new object[] { "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            renavamComboBox.Location = new Point(139, 159);
            renavamComboBox.Name = "renavamComboBox";
            renavamComboBox.Size = new Size(121, 23);
            renavamComboBox.TabIndex = 68;
            renavamComboBox.SelectedIndexChanged += renavamComboBox_SelectedIndexChanged;
            // 
            // kmComboBox
            // 
            kmComboBox.Enabled = false;
            kmComboBox.FormattingEnabled = true;
            kmComboBox.Location = new Point(12, 159);
            kmComboBox.Name = "kmComboBox";
            kmComboBox.Size = new Size(121, 23);
            kmComboBox.TabIndex = 67;
            // 
            // CaminhaoProcuraPorId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(renavamComboBox);
            Controls.Add(kmComboBox);
            Controls.Add(placaComboBox);
            Controls.Add(idComboBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(anoComboBox);
            Controls.Add(anoLabel);
            Controls.Add(corComboBox);
            Controls.Add(corLabel);
            Controls.Add(idLabel);
            Controls.Add(modeloLabel);
            Controls.Add(modeloComboBox);
            Controls.Add(fabricanteLabel);
            Controls.Add(fabricanteComboBox);
            Controls.Add(placaLabel);
            Name = "CaminhaoProcuraPorId";
            Text = "CaminhaoProcuraPorId";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox anoComboBox;
        private Label anoLabel;
        private ComboBox corComboBox;
        private Label corLabel;
        private Label idLabel;
        private Label modeloLabel;
        private ComboBox modeloComboBox;
        private Label fabricanteLabel;
        private ComboBox fabricanteComboBox;
        private Label placaLabel;
        private ComboBox idComboBox;
        private ComboBox placaComboBox;
        private ComboBox renavamComboBox;
        private ComboBox kmComboBox;
    }
}