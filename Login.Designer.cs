namespace VerduraoDoJoao2._0
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            LoginBtn = new Button();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(89, 267);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(120, 43);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 214);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '*';
            maskedTextBox1.Size = new Size(287, 38);
            maskedTextBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(6, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 38);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(LoginBtn);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Font = new Font("Cooper Black", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(250, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 316);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 181);
            label2.Name = "label2";
            label2.Size = new Size(96, 31);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 98);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 454);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginBtn;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox1;
    }
}