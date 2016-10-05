namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.billLabel = new System.Windows.Forms.Label();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.tipBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billLabel.Location = new System.Drawing.Point(12, 9);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(76, 20);
            this.billLabel.TabIndex = 0;
            this.billLabel.Text = "Enter Bill:";
            // 
            // billTextBox
            // 
            this.billTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billTextBox.Location = new System.Drawing.Point(94, 6);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(100, 26);
            this.billTextBox.TabIndex = 1;
            this.billTextBox.TextChanged += new System.EventHandler(this.billTextBox_TextChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultLabel.Location = new System.Drawing.Point(12, 151);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(108, 20);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Total Amount:";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultTextBox.Location = new System.Drawing.Point(138, 148);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 26);
            this.resultTextBox.TabIndex = 3;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.percentageLabel.Location = new System.Drawing.Point(12, 60);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(120, 20);
            this.percentageLabel.TabIndex = 5;
            this.percentageLabel.Text = "Tip Percentage:";
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.percentageTextBox.Location = new System.Drawing.Point(138, 57);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new System.Drawing.Size(100, 26);
            this.percentageTextBox.TabIndex = 6;
            this.percentageTextBox.TextChanged += new System.EventHandler(this.percentageTextBox_TextChanged);
            // 
            // tipBox
            // 
            this.tipBox.Enabled = false;
            this.tipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipBox.Location = new System.Drawing.Point(138, 101);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(100, 26);
            this.tipBox.TabIndex = 7;
            // 
            // tipBoxLabel
            // 
            this.tipBoxLabel.AutoSize = true;
            this.tipBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipBoxLabel.Location = new System.Drawing.Point(12, 104);
            this.tipBoxLabel.Name = "tipBoxLabel";
            this.tipBoxLabel.Size = new System.Drawing.Size(94, 20);
            this.tipBoxLabel.TabIndex = 8;
            this.tipBoxLabel.Text = "Tip Amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 351);
            this.Controls.Add(this.tipBoxLabel);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.percentageTextBox);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.billLabel);
            this.Name = "Form1";
            this.Text = "FreeTip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.Label tipBoxLabel;
    }
}

