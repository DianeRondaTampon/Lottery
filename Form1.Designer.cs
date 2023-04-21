namespace Lottery
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.cmbBet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(188, 38);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(33, 20);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bet";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(188, 111);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(125, 27);
            this.txtBet.TabIndex = 3;
            // 
            // cmbBet
            // 
            this.cmbBet.FormattingEnabled = true;
            this.cmbBet.Items.AddRange(new object[] {
            "Even",
            "Odd"});
            this.cmbBet.Location = new System.Drawing.Point(376, 110);
            this.cmbBet.Name = "cmbBet";
            this.cmbBet.Size = new System.Drawing.Size(151, 28);
            this.cmbBet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Money to bet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Option to bet";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(188, 184);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(175, 76);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(188, 291);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBet);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblMoney;
        private Label label2;
        private TextBox txtBet;
        private ComboBox cmbBet;
        private Label label3;
        private Label label4;
        private Button btnPlay;
        private Label lblResult;
        private Label label6;
    }
}