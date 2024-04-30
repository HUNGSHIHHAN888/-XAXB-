namespace 視窗版本的XAXB_遊戲
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
            userInputTextBox = new TextBox();
            luckyNumberLabel = new Label();
            historyListBox = new ListBox();
            resultLabel = new Label();
            submitButton = new Button();
            SuspendLayout();
            // 
            // userInputTextBox
            // 
            userInputTextBox.Location = new Point(726, 226);
            userInputTextBox.Margin = new Padding(6);
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.Size = new Size(232, 38);
            userInputTextBox.TabIndex = 1;
            // 
            // luckyNumberLabel
            // 
            luckyNumberLabel.AutoSize = true;
            luckyNumberLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            luckyNumberLabel.Location = new Point(599, 107);
            luckyNumberLabel.Margin = new Padding(6, 0, 6, 0);
            luckyNumberLabel.Name = "luckyNumberLabel";
            luckyNumberLabel.Size = new Size(483, 41);
            luckyNumberLabel.TabIndex = 2;
            luckyNumberLabel.Text = "請輸入不重複的三個數字(0~9) :  ";
            // 
            // historyListBox
            // 
            historyListBox.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            historyListBox.FormattingEnabled = true;
            historyListBox.ItemHeight = 37;
            historyListBox.Location = new Point(35, 45);
            historyListBox.Margin = new Padding(6);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(477, 522);
            historyListBox.TabIndex = 3;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resultLabel.Location = new Point(690, 337);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 35);
            resultLabel.TabIndex = 4;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(776, 454);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(150, 46);
            submitButton.TabIndex = 5;
            submitButton.Text = "檢測";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 625);
            Controls.Add(submitButton);
            Controls.Add(resultLabel);
            Controls.Add(historyListBox);
            Controls.Add(luckyNumberLabel);
            Controls.Add(userInputTextBox);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "XAXB遊戲";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userInputTextBox;
        private Label luckyNumberLabel;
        private ListBox historyListBox;
        private Label resultLabel;
        private Button submitButton;
    }
}