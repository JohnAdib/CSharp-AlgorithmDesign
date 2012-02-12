namespace AlgorithmDesign.Forms
{
    partial class FrmProduction
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "number1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(59, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(347, 20);
            this.txtNum1.TabIndex = 6;
            this.txtNum1.TextChanged += new System.EventHandler(this.Checktxt);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(59, 35);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(347, 20);
            this.txtNum2.TabIndex = 8;
            this.txtNum2.TextChanged += new System.EventHandler(this.Checktxt);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(59, 61);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(347, 126);
            this.txtResult.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(21, 64);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 13);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "number2";
            // 
            // FrmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(418, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum1);
            this.Name = "FrmProduction";
            this.Text = "AlgorithmDesign - Production 2 Big Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
    }
}
