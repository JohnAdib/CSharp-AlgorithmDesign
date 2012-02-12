namespace AlgorithmDesign.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Animatedtimer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKeypad = new System.Windows.Forms.Button();
            this.btnSum2String = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.lblAuthorNote = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnSubSet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Animatedtimer
            // 
            this.Animatedtimer.Tick += new System.EventHandler(this.AnimatedtimerTick);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(12, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 38);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "خروج";
            this.toolTip1.SetToolTip(this.btnExit, "خروج از برنامه");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.CloseProgram);
            // 
            // btnKeypad
            // 
            this.btnKeypad.ForeColor = System.Drawing.Color.Navy;
            this.btnKeypad.Location = new System.Drawing.Point(12, 180);
            this.btnKeypad.Name = "btnKeypad";
            this.btnKeypad.Size = new System.Drawing.Size(455, 39);
            this.btnKeypad.TabIndex = 1;
            this.btnKeypad.Text = "پروژه نهایی: محاسبه کوتاه‌ترین صفحه کلید موبایل برای نوشتن متن وارد شده";
            this.toolTip1.SetToolTip(this.btnKeypad, "پروژه نهایی 20 نمره ای!");
            this.btnKeypad.UseVisualStyleBackColor = true;
            this.btnKeypad.Click += new System.EventHandler(this.BtnKeypadClick);
            // 
            // btnSum2String
            // 
            this.btnSum2String.Location = new System.Drawing.Point(12, 135);
            this.btnSum2String.Name = "btnSum2String";
            this.btnSum2String.Size = new System.Drawing.Size(172, 39);
            this.btnSum2String.TabIndex = 10;
            this.btnSum2String.Text = "برنامه جمع دو عدد بزرگ";
            this.toolTip1.SetToolTip(this.btnSum2String, "فقط برای تست");
            this.btnSum2String.UseVisualStyleBackColor = true;
            this.btnSum2String.Click += new System.EventHandler(this.BtnSum2StringClick);
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(190, 135);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(277, 39);
            this.btnProduction.TabIndex = 5;
            this.btnProduction.Text = "برنامه ضرب دو عدد بزرگ";
            this.toolTip1.SetToolTip(this.btnProduction, "برنامه 5 نمره ای!");
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.OpenProduction);
            // 
            // lblAuthorNote
            // 
            this.lblAuthorNote.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorNote.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold);
            this.lblAuthorNote.Location = new System.Drawing.Point(71, 229);
            this.lblAuthorNote.Name = "lblAuthorNote";
            this.lblAuthorNote.Size = new System.Drawing.Size(396, 30);
            this.lblAuthorNote.TabIndex = 2;
            this.lblAuthorNote.Text = "این برنامه ها توسط جواد عوض زاده برای درس طراحی الگوریتم نوشته شده است";
            this.lblAuthorNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthorNote.Click += new System.EventHandler(this.LblAuthorNoteClick);
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("IranNastaliq", 25F, System.Drawing.FontStyle.Bold);
            this.lblDesc.Location = new System.Drawing.Point(12, -1);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(455, 88);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "تمرین های درس طراحی الگوریتم";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc.Click += new System.EventHandler(this.LblDescClick);
            // 
            // btnSubSet
            // 
            this.btnSubSet.Location = new System.Drawing.Point(12, 90);
            this.btnSubSet.Name = "btnSubSet";
            this.btnSubSet.Size = new System.Drawing.Size(455, 39);
            this.btnSubSet.TabIndex = 15;
            this.btnSubSet.Text = "برنامه ای که زیرمجموعه های یک مجموعه را نمایش می دهد";
            this.toolTip1.SetToolTip(this.btnSubSet, "این برنامه بدون استفاده از تابع بازگشتی نوشته شده است.");
            this.btnSubSet.UseVisualStyleBackColor = true;
            this.btnSubSet.Click += new System.EventHandler(this.OpenSubSet);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(479, 272);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKeypad);
            this.Controls.Add(this.btnSum2String);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.lblAuthorNote);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnSubSet);
            this.Font = new System.Drawing.Font("B Koodak", 11.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubSet;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAuthorNote;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnSum2String;
        private System.Windows.Forms.Button btnKeypad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer Animatedtimer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
