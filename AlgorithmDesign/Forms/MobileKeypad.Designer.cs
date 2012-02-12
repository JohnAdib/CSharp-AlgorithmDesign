namespace AlgorithmDesign.Forms
{
    partial class MobileKeypad
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AuthorNote = new System.Windows.Forms.Label();
            this.Animatedtimer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlphabetize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Keypadtimer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 13);
            this.txtInput.MaxLength = 200;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(348, 20);
            this.txtInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtInput, "رشته ورودی");
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInputTextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(87, 363);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Keypad Counter";
            this.toolTip1.SetToolTip(this.richTextBox1, "تعداد دفعات فشردن هر دکمه");
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
            // 
            // AuthorNote
            // 
            this.AuthorNote.BackColor = System.Drawing.Color.Transparent;
            this.AuthorNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AuthorNote.Location = new System.Drawing.Point(9, 440);
            this.AuthorNote.Name = "AuthorNote";
            this.AuthorNote.Size = new System.Drawing.Size(396, 17);
            this.AuthorNote.TabIndex = 8;
            this.AuthorNote.Text = "This application created for Algorithm Design by Javad Evazzadeh (87134100028)";
            this.toolTip1.SetToolTip(this.AuthorNote, "evazzadeh.com");
            // 
            // Animatedtimer
            // 
            this.Animatedtimer.Enabled = true;
            this.Animatedtimer.Tick += new System.EventHandler(this.AnimatedtimerTick);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(105, 65);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(139, 137);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "Created keypad";
            this.toolTip1.SetToolTip(this.richTextBox2, "کیبورد طراحی شده");
            this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(250, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "تعداد کاراکترهای منحصر به فرد وارد شده");
            // 
            // txtAlphabetize
            // 
            this.txtAlphabetize.Location = new System.Drawing.Point(105, 39);
            this.txtAlphabetize.MaxLength = 200;
            this.txtAlphabetize.Multiline = true;
            this.txtAlphabetize.Name = "txtAlphabetize";
            this.txtAlphabetize.ReadOnly = true;
            this.txtAlphabetize.Size = new System.Drawing.Size(256, 20);
            this.txtAlphabetize.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtAlphabetize, "رشته مرتب شده بر اساس حروف الفبا");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alphabetize";
            this.toolTip1.SetToolTip(this.label2, "با کلیک کردن جعبه زیر بر حسب تعداد تکرار یا حروف الفبا مرتب خواهد شد");
            this.label2.Click += new System.EventHandler(this.Label2Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(250, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 112);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            this.toolTip1.SetToolTip(this.label3, "روش فشردن متن با استفاده از این کیبورد\r\nشماره دکمه(دفعات تکرار)");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(250, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type text by pressing";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(105, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = "Press in x time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(367, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label7, "طول رشته وارد شده");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "ABC";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "DEF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 41);
            this.button3.TabIndex = 22;
            this.button3.Text = "GHI";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 41);
            this.button4.TabIndex = 23;
            this.button4.Text = "JKL";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 41);
            this.button5.TabIndex = 24;
            this.button5.Text = "MNO";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(198, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 41);
            this.button6.TabIndex = 25;
            this.button6.Text = "PQR";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 113);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 41);
            this.button7.TabIndex = 26;
            this.button7.Text = "STU";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(102, 113);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 41);
            this.button8.TabIndex = 27;
            this.button8.Text = "VWX";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(198, 113);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 41);
            this.button9.TabIndex = 28;
            this.button9.Text = "YZ";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(105, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 167);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KeyPad Design";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(358, 381);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comboBox1, "الگوریتم طراحی صفحه کلید");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AlgorithmDesign.Properties.Resources.Help_Info_2_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(367, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "برای خواندن راهنما کلیک کنید");
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
            // 
            // Keypadtimer
            // 
            this.Keypadtimer.Tick += new System.EventHandler(this.KeypadtimerTick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(105, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Count of unique character :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MobileKeypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(416, 460);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlphabetize);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.AuthorNote);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtInput);
            this.Name = "MobileKeypad";
            this.Load += new System.EventHandler(this.MobileKeypadLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label AuthorNote;
        private System.Windows.Forms.Timer Animatedtimer;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlphabetize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer Keypadtimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}
