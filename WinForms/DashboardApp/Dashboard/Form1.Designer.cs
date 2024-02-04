namespace Dashboard
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
            messageLabel = new Label();
            messageBox = new TextBox();
            messageListBox = new ListBox();
            label1 = new Label();
            addMessageButton = new Button();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(185, 119);
            messageLabel.Margin = new Padding(5, 0, 5, 0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(86, 25);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Message";
            // 
            // messageBox
            // 
            messageBox.Location = new Point(279, 116);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(183, 33);
            messageBox.TabIndex = 1;
            // 
            // messageListBox
            // 
            messageListBox.FormattingEnabled = true;
            messageListBox.ItemHeight = 25;
            messageListBox.Location = new Point(185, 203);
            messageListBox.Name = "messageListBox";
            messageListBox.Size = new Size(277, 179);
            messageListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 175);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 3;
            label1.Text = "Message List";
            // 
            // addMessageButton
            // 
            addMessageButton.Location = new Point(468, 116);
            addMessageButton.Name = "addMessageButton";
            addMessageButton.Size = new Size(125, 33);
            addMessageButton.TabIndex = 2;
            addMessageButton.Text = "Add";
            addMessageButton.UseVisualStyleBackColor = true;
            addMessageButton.Click += AddMessageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 584);
            Controls.Add(addMessageButton);
            Controls.Add(label1);
            Controls.Add(messageListBox);
            Controls.Add(messageBox);
            Controls.Add(messageLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageLabel;
        private TextBox messageBox;
        private ListBox messageListBox;
        private Label label1;
        private Button addMessageButton;
    }
}