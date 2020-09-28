namespace TipCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputBox = new System.Windows.Forms.TextBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(377, 218);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(125, 27);
            this.outputBox.TabIndex = 1;
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(377, 175);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(125, 27);
            this.tipBox.TabIndex = 2;
            this.tipBox.TextChanged += new System.EventHandler(this.tipBox_TextChanged);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(377, 121);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(125, 27);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(259, 175);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(33, 20);
            this.TipLabel.TabIndex = 4;
            this.TipLabel.Text = "Tip:";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(259, 121);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(33, 20);
            this.billLabel.TabIndex = 5;
            this.billLabel.Text = "Bill:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label billLabel;
    }
}

