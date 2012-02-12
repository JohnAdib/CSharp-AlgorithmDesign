namespace AlgorithmDesign.Forms
{
    partial class SubSet
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
            this.AuthorNote = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Animatedtimer = new System.Windows.Forms.Timer(this.components);
            this.txtset = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AuthorNote
            // 
            this.AuthorNote.BackColor = System.Drawing.Color.Transparent;
            this.AuthorNote.Location = new System.Drawing.Point(9, 231);
            this.AuthorNote.Name = "AuthorNote";
            this.AuthorNote.Size = new System.Drawing.Size(453, 17);
            this.AuthorNote.TabIndex = 7;
            this.AuthorNote.Text = "This simple application created for Algorithm Design by Javad Evazzadeh (87134100" +
    "028)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 195);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "\n\n\n\n\nThis RichTextbox show the subset of input sting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter text to show this SubSet\r\n";
            // 
            // Animatedtimer
            // 
            this.Animatedtimer.Enabled = true;
            this.Animatedtimer.Tick += new System.EventHandler(this.AnimatedtimerTick);
            // 
            // txtset
            // 
            this.txtset.Location = new System.Drawing.Point(164, 7);
            this.txtset.MaxLength = 8;
            this.txtset.Name = "txtset";
            this.txtset.Size = new System.Drawing.Size(298, 20);
            this.txtset.TabIndex = 4;
            this.txtset.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // SubSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(473, 256);
            this.Controls.Add(this.AuthorNote);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtset);
            this.Name = "SubSet";
            this.Text = "AlgorithmDesign-Show SubSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Animatedtimer;
        private System.Windows.Forms.TextBox txtset;


    }
}
